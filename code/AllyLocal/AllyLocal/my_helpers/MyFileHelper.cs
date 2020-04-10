using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;
using Ally_Local.helpers;

namespace Ally_Local.my_helpers
{
    class MyFileHelper
    {
        public const string FOLDER_EXERCISES = "exercises";
        public const string FOLDER_COMPULSORY = FOLDER_EXERCISES + "/compulsory";
        public const string FOLDER_ADDITIONAL = FOLDER_EXERCISES + "/additional";
        public const string FILE_LST_NAME = "files.lst";


        public static string GetSubfolderPath(string subfolder)
        {
            string appName = MyConfig.GetSetting(MyConfig.Key_AppName);
            string userhash = MyConfig.GetSetting(MyConfig.Key_StudentHash);

            string folderpath = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
                appName,
                userhash,
                subfolder);

            return folderpath;
        }

        public static void GenerateEmptyFilesFromList()
        {
            string toFolder = GetSubfolderPath(FOLDER_COMPULSORY);
            string filePath = Path.Combine(toFolder, FILE_LST_NAME);
            FileHelper.GenerateEmptyFilesFromList(filePath, toFolder);

            // toFolder = GetAdditionalExerciseFolder(userhash);
            toFolder = GetSubfolderPath(FOLDER_ADDITIONAL);
            filePath = Path.Combine(toFolder, FILE_LST_NAME);
            FileHelper.GenerateEmptyFilesFromList(filePath, toFolder);
        }

        public static void CopyExerciseFolders()
        {
            string sourceFolder = FOLDER_EXERCISES;
            string destFolderPath = GetSubfolderPath(FOLDER_EXERCISES);

            FileHelper.CopyFolderContent(sourceFolder, destFolderPath);
        }

        public static void DeleteExerciseFolder()
        {
            string folder = GetSubfolderPath(FOLDER_EXERCISES);
            if (Directory.Exists(folder))
            {
                try
                {
                    Directory.Delete(folder, true);
                }
                catch
                {
                }
            }
        }
    }
}