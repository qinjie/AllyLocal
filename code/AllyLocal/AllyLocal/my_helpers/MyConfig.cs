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
        public static string Key_DisableProfileRename = "disable_profile_rename";

        public static string GetSetting(string key)
        {
            return ConfigSettings.GetSetting(key);
        }

        public static string SetSetting(string key, string value)
        {
            return ConfigSettings.SetSetting(key, value);
        }
    }
}