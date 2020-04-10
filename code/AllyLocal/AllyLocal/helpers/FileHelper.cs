using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ally_Local.helpers
{
    class FileHelper
    {
        public static int GenerateEmptyFilesFromList(string sourceFilePath, string toFolder, bool overwrite = false)
        {
            // Create file and directory if they don't exist
            string dir = System.IO.Path.GetDirectoryName(sourceFilePath);
            if (!System.IO.Directory.Exists(dir))
                System.IO.Directory.CreateDirectory(dir);

            if (!File.Exists(sourceFilePath))
                File.Create(sourceFilePath).Dispose();

            // Read the file and display it line by line.  
            int counter = 0;
            using (System.IO.StreamReader file = new System.IO.StreamReader(sourceFilePath))
            {
                string line;
                while ((line = file.ReadLine()) != null)
                {
                    if (!string.IsNullOrEmpty(line))
                    {
                        string filePath = Path.Combine(toFolder, line.Trim());
                        if (!string.IsNullOrEmpty(filePath))
                        {
                            if (File.Exists(filePath) && !overwrite)
                            {
                                continue;
                            }
                            WriteFile(filePath, "");
                            counter++;
                        }
                    }
                }
            }

            return counter;
        }

        public static string WriteFile(string filePath, string data, bool encrypt = false,
            string passPhrase = "dummy_phase")
        {
            if (string.IsNullOrEmpty(filePath))
            {
                return null;
            }

            if (encrypt == true)
                data = DesCipher.Encrypt(data, passPhrase);

            using (StreamWriter sw = new StreamWriter(filePath))
            {
                sw.WriteLine(data);
            }

            return filePath;
        }

        public static string[] ListFiles(string folderPath, string filePattern = "*.c", bool includeSubfolder = false)
        {
            if (!System.IO.Directory.Exists(folderPath))
                System.IO.Directory.CreateDirectory(folderPath);

            if (includeSubfolder)
            {
                return Directory.GetFiles(folderPath, filePattern, SearchOption.AllDirectories);
            }
            else
            {
                return Directory.GetFiles(folderPath, filePattern);
            }
        }

        public static bool CopyFolderContent(string sourceFolder, string targetFolderPath)
        {
            var diSource = new DirectoryInfo(sourceFolder);
            var diTarget = new DirectoryInfo(targetFolderPath);
            if (!System.IO.Directory.Exists(sourceFolder))
                return false;

            if (!System.IO.Directory.Exists(targetFolderPath))
                System.IO.Directory.CreateDirectory(sourceFolder);

            CopyAllContent(diSource, diTarget);
            return true;
        }

        private static void CopyAllContent(DirectoryInfo source, DirectoryInfo target, bool overwrite = false)
        {
            Directory.CreateDirectory(target.FullName);

            // Copy each file into the new directory.
            foreach (FileInfo fi in source.GetFiles())
            {
                Console.WriteLine(@"Copying {0}\{1}", target.FullName, fi.Name);
                string targetFile = Path.Combine(target.FullName, fi.Name);
                if (overwrite == false && File.Exists(targetFile))
                    continue;
                fi.CopyTo(targetFile, overwrite);
            }

            // Copy each subdirectory using recursion.
            foreach (DirectoryInfo diSourceSubDir in source.GetDirectories())
            {
                DirectoryInfo nextTargetSubDir =
                    target.CreateSubdirectory(diSourceSubDir.Name);
                CopyAllContent(diSourceSubDir, nextTargetSubDir, overwrite);
            }
        }

        public static string ReadFile(string filePath, bool decrypt = false, string passPhrase = "dummy_phase")
        {
            string result;
            using (System.IO.StreamReader file = new System.IO.StreamReader(filePath))
            {
                result = file.ReadToEnd();
            }

            if (decrypt)
                result = DesCipher.Decrypt(result, passPhrase);

            return result;
        }


        public static string SanitizeFileName(string fileName)
        {
            foreach (char c in System.IO.Path.GetInvalidFileNameChars())
            {
                fileName = fileName.Replace(c, '_');
            }

            return fileName;
        }
    }
}