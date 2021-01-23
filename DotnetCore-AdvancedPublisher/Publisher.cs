using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetCoreAdvancedPublisher
{
    public static class Publisher
    {
        static ProcessStartInfo _startInfo = new ProcessStartInfo("cmd");

        public static void Execute(string workingDirectory, bool isSelfContained, bool isReadyToRun, bool isSingleFile, bool isTrimmed, string rid, string outputPath)
        {
            if (Directory.Exists(outputPath))
            {
                Directory.Delete(outputPath, true);
            }

            _startInfo.UseShellExecute = false;
            _startInfo.RedirectStandardOutput = true;
            _startInfo.CreateNoWindow = true;
            _startInfo.Verb = "runas";
            _startInfo.WorkingDirectory = workingDirectory;

            _startInfo.Arguments = $@"/c dotnet restore -r {rid}";

            Process.Start(_startInfo);

            _startInfo.Arguments = $@"/c dotnet publish -c Release -r {rid} --output {outputPath} -p:PublishReadyToRun={isReadyToRun} -p:PublishSingleFile={isSingleFile} -p:PublishTrimmed={isTrimmed} --self-contained {isSelfContained}".Trim();

            Process.Start(_startInfo);
        }
    }
}
