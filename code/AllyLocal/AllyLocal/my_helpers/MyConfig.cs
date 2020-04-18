using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ally_Local.helpers
{
    class MyConfig
    {
        public static string Key_Title = "Programming (38PROG)";
        public static string Key_AppName = "app_name";
        public static string Key_ModuleCatalog = "module_catalog";
        public static string Key_ModuleName = "module_name";
        public static string Key_StudentName = "student_name";
        public static string Key_StudentHash = "student_hash";
        public static string Key_SuperUserPrefix = "super_user_prefix";

        public static string GetSetting(string key)
        {
            return ConfigSettings.GetSetting(key);
        }

        public static string SetSetting(string key, string value)
        {
            return ConfigSettings.SetSetting(key, value);
        }

        public static string GetHashFromName(string name)
        {
            string hash = "";
            // hash = DesCipher.GetSHA256String(name.ToLower());
            hash = FileHelper.SanitizeFileName(name.ToLower());
            return hash;
        }
    }
}