using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ally_Local.helpers;

namespace Ally_Local.my_helpers
{
    class MyFileHelper
    {
        public const string FOLDER_EXERCISES = "exercises";
        public const string FOLDER_COMPULSORY = FOLDER_EXERCISES + "/compulsory";
        public const string FOLDER_ADDITIONAL = FOLDER_EXERCISES + "/additional";
        public const string FILE_LST_NAME = "files.lst";

        public static string GetExercisesFolder()
        {
            string appName = MyConfig.GetSetting(MyConfig.Key_AppName);
            string folder = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
                appName,
                FOLDER_EXERCISES);
            return folder;
        }

        public static string GetCompulsoryExerciseFolder()
        {
            string appName = MyConfig.GetSetting(MyConfig.Key_AppName);
            string folder = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
                appName,
                FOLDER_COMPULSORY);
            return folder;
        }

        public static string GetAdditionalExerciseFolder()
        {
            string appName = MyConfig.GetSetting(MyConfig.Key_AppName);
            string folder = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
                appName,
                FOLDER_ADDITIONAL);
            return folder;
        }

        public static string GetPathToFolder(string subfolder)
        {
            string appName = MyConfig.GetSetting(MyConfig.Key_AppName);
            string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
                appName,
                subfolder);
            return path;
        }

        public static void GenerateEmptyFilesFromList()
        {
            string toFolder = GetCompulsoryExerciseFolder();
            string filePath = Path.Combine(toFolder, FILE_LST_NAME);
            FileHelper.GenerateEmptyFilesFromList(filePath, toFolder);

            toFolder = GetAdditionalExerciseFolder();
            filePath = Path.Combine(toFolder, FILE_LST_NAME);
            FileHelper.GenerateEmptyFilesFromList(filePath, toFolder);
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

        public static void CopyExerciseFolders()
        {
            string sourceFolderPath = FOLDER_EXERCISES;
            string destFolderPath = GetExercisesFolder();

            FileHelper.CopyFolderContent(sourceFolderPath, destFolderPath);
        }
    }
}