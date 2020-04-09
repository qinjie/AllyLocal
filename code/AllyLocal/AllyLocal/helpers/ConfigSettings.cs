using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Use App.config file to save settings in the program
// Reference: https://stackoverflow.com/questions/4758598/write-values-in-app-config-file/15739745

namespace Ally_Local.helpers
{
    class ConfigSettings
    {
        public static string GetSetting(string key)
        {
            return ConfigurationManager.AppSettings[key];
        }

        public static string SetSetting(string key, string value)
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.AppSettings.Settings[key].Value = value;
            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSettings");

            return ConfigurationManager.AppSettings[key];
        }

        public static string AddSetting(string key, string value)
        {
            // Add a value to an existing setting
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.AppSettings.Settings.Add(key, value);
            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSettings");

            return ConfigurationManager.AppSettings[key];
        }
    }
}
