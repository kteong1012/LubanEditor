using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEditor
{
    internal class WindowsTools
    {
        public static void RunBatch(string batchFileName, string workDir, bool showCmd = true, bool pause = true)
        {
            var arguments = $"/c {batchFileName}";
            if (pause && showCmd)
            {
                var batText = File.ReadAllText(Path.Combine(workDir, batchFileName));
                if (!batText.Trim().EndsWith("pause"))
                {
                    arguments += " & pause";
                }
            }
            RunProcess("cmd.exe", arguments, workDir, showCmd);
        }

        public static void RunProcess(string fileName, string arguments, string workDir, bool showCmd = false)
        {
            var processInfo = new ProcessStartInfo(fileName, arguments)
            {
                UseShellExecute = showCmd,
                CreateNoWindow = !showCmd,
                WorkingDirectory = workDir,
                RedirectStandardError = !showCmd,
                RedirectStandardOutput = !showCmd
            };

            var process = Process.Start(processInfo);
            if (process == null)
            {
                UnityEngine.Debug.LogError("Can not start process!");
                return;
            }
            process.WaitForExit();

            if (!showCmd)
            {
                process.OutputDataReceived += (sender, args) => UnityEngine.Debug.Log(args.Data);

                var errorMsg = process.StandardError.ReadToEnd();
                if (!string.IsNullOrEmpty(errorMsg))
                {
                    UnityEngine.Debug.LogError(errorMsg);
                }
            }
            process.Close();
        }
    }
}
