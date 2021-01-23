using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetCoreAdvancedPublisher
{
    public static class RuntimeIdentifier
    {
        public static List<string> GetLinuxRids()
        {
            return new List<string>
            {
                "linux-x64",
                "linux-musl-x64",
                "linux-arm",
                "linux-arm64",
                "rhel-x64",
                "rhel.6-x64",
                "tizen",
                "tizen.4.0.0",
                "tizen.5.0.0"
            };
        }

        public static List<string> GetWindowsRids()
        {
            return new List<string>
            {
                "win-x64",
                "win-x86",
                "win-arm",
                "win-arm64",
                "win7-x64",
                "win7-x86",
                "win81-x64",
                "win81-x86",
                "win81-arm",
                "win10-x64",
                "win10-x86",
                "win10-arm",
                "win10-arm64"
            };
        }

        public static List<string> GetMacOsRids()
        {
            return new List<string>
            {
                "osx-x64",
                "osx.10.10-x64",
                "osx.10.11-x64",
                "osx.10.12-x64",
                "osx.10.13-x64",
                "osx.10.14-x64",
                "osx.10.15-x64",
                "osx.11.0-x64",
                "osx.11.0-arm64"
            };
        }
    }
}
