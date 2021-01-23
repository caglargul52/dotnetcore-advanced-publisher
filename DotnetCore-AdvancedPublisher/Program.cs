using System;
using System.Windows.Forms;

namespace DotnetCoreAdvancedPublisher
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //bool statusSdks = CheckDotnetSdkVersion();

            //if (!statusSdks)
            //{
            //    MessageBox.Show(".NET Core SDK must be at least 3.1 version!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}

            //bool statusRuntimes = CheckDotnetRuntimeVersion();

            //if (!statusRuntimes)
            //{
            //    MessageBox.Show(".NET Core Runtime must be at least 3.1 version!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}

            Application.Run(new MainForm());
        }

        //private static bool CheckDotnetSdkVersion()
        //{
        //    ProcessStartInfo _startInfo = new ProcessStartInfo("cmd");

        //    _startInfo.UseShellExecute = false;
        //    _startInfo.RedirectStandardOutput = true;
        //    _startInfo.CreateNoWindow = true;
        //    _startInfo.Verb = "runas";

        //    _startInfo.Arguments = $@"/c dotnet --list-sdks";

        //    using (Process process = Process.Start(_startInfo))
        //    {
        //        using (StreamReader reader = process.StandardOutput)
        //        {
        //            string result = reader.ReadToEnd();

        //            if (string.IsNullOrEmpty(result))
        //            {
        //                return false;
        //            }
        //            else
        //            {
        //                List<string> list = new List<string>(result.Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries));

        //                List<Version> _sdkVersions = new List<Version>();

        //                foreach (var item in list)
        //                {
        //                    var splitted = item.Split(' ')[0];

        //                    _sdkVersions.Add(new Version(splitted));
        //                }

        //                var exist = _sdkVersions.FirstOrDefault(x => x >= Version.Parse("3.1.0"));

        //                if (exist == null)
        //                {
        //                    return false;
        //                }
        //            }

        //            return true;
        //        }
        //    }
        //}

        //private static bool CheckDotnetRuntimeVersion()
        //{
        //    ProcessStartInfo _startInfo = new ProcessStartInfo("cmd");

        //    _startInfo.UseShellExecute = false;
        //    _startInfo.RedirectStandardOutput = true;
        //    _startInfo.CreateNoWindow = true;
        //    _startInfo.Verb = "runas";

        //    _startInfo.Arguments = $@"/c dotnet --list-runtimes";

        //    using (Process process = Process.Start(_startInfo))
        //    {
        //        using (StreamReader reader = process.StandardOutput)
        //        {
        //            string result = reader.ReadToEnd();

        //            if (string.IsNullOrEmpty(result))
        //            {
        //                return false;
        //            }
        //            else
        //            {
        //                List<string> list = new List<string>(result.Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries));

        //                List<Version> _sdkRuntimes = new List<Version>();

        //                foreach (var item in list)
        //                {
        //                    var splitted = item.Split(' ')[1];

        //                    _sdkRuntimes.Add(new Version(splitted));
        //                }

        //                var exist = _sdkRuntimes.FirstOrDefault(x => x >= Version.Parse("3.1.0"));

        //                if (exist == null)
        //                {
        //                    return false;
        //                }
        //            }

        //            return true;
        //        }
        //    }
        //}

    }
}
