using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Text.RegularExpressions;
using System.Data.SqlClient;
using System.Collections;
using System.Net;
using System.Xml;
using System.Xml.Serialization;
using System.Xml.Linq;
using System.Threading.Tasks;
using System.Threading;

namespace Ally_Local.helpers
{
    class TccHelper
    {
        public static string WriteToTempFile(string code, string filename = "temp.c")
        {
            string subfolder = MyConfig.GetSetting(MyConfig.Key_AppName);
            string filepath = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
                subfolder,
                filename);
            using (StreamWriter sw = new StreamWriter(filepath))
            {
                sw.WriteLine(code);
            }

            return filepath;
        }

        public static void RunByTcc(string code)
        {
            string filepath = WriteToTempFile(code);

            using (Process process = new Process())
            {
                process.StartInfo.WorkingDirectory = @".\libraries\tcc";
                process.StartInfo.FileName = "cmd";
                process.StartInfo.Arguments = "/k tcc -run " + "\"" + filepath + "\"";

                // process.StartInfo.CreateNoWindow = true;
                // process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                // process.StartInfo.RedirectStandardOutput = true;
                // process.StartInfo.RedirectStandardError = true;

                process.StartInfo.UseShellExecute = false;
                process.Start();
                process.WaitForExit();
                process.Dispose();
            }
        }

        public static string[] CompileByTcc(string code)
        {
            string filepath = WriteToTempFile(code);
            int timeout = 3000;

            StringBuilder output = new StringBuilder();
            StringBuilder error = new StringBuilder();

            using (Process process = new Process())
            {
                process.StartInfo.WorkingDirectory = @".\libraries\tcc";
                process.StartInfo.FileName = "cmd";
                process.StartInfo.Arguments = "/c tcc -c " + "\"" + filepath + "\"";

                process.StartInfo.CreateNoWindow = true;
                process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                process.StartInfo.UseShellExecute = false;
                process.StartInfo.RedirectStandardOutput = true;
                process.StartInfo.RedirectStandardError = true;

                using (AutoResetEvent outputWaitHandle = new AutoResetEvent(false))
                using (AutoResetEvent errorWaitHandle = new AutoResetEvent(false))
                {
                    process.OutputDataReceived += (sender, e) =>
                    {
                        if (e.Data == null)
                        {
                            outputWaitHandle.Set();
                        }
                        else
                        {
                            output.AppendLine(e.Data);
                        }
                    };
                    process.ErrorDataReceived += (sender, e) =>
                    {
                        if (e.Data == null)
                        {
                            errorWaitHandle.Set();
                        }
                        else
                        {
                            error.AppendLine(e.Data);
                        }
                    };

                    process.Start();

                    process.BeginOutputReadLine();
                    process.BeginErrorReadLine();

                    if (!(process.WaitForExit(timeout) &&
                          outputWaitHandle.WaitOne(timeout) &&
                          errorWaitHandle.WaitOne(timeout)))
                    {
                        error.AppendLine("Time out!");
                    }
                }
            }

            // contains error and output
            string[] result = new string[2];
            result[0] = error.ToString();
            result[1] = output.ToString();
            return result;
        }
    }
}