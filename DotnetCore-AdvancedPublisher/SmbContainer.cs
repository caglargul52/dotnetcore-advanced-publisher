using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace DotnetCoreAdvancedPublisher
{
    public class SmbContainer
    {
        private readonly NetworkCredential networkCredential;
        private readonly string networkPath;

        public SmbContainer(string networkPath, string username, string password, string domain = "")
        {
            this.networkPath = networkPath;
            networkCredential = new NetworkCredential(username, password, domain);
        }

        public bool Connect()
        {
            try
            {
                using(var network = new NetworkConnection($"{networkPath}", networkCredential))
                {
                    var result = network.Connect();
                    return result == 0;
                }
            }
            catch
            {
                return false;
            }
        }


        //public void CreateFile(string targetFile, string content)
        //{
        //    using(var network = new NetworkConnection(networkPath, networkCredential))
        //    {
        //        network.Connect();

        //        var files = Directory.GetFiles(this.networkPath);

        //        File.Copy("Device Simulator Core.rar", Path.Combine(this.networkPath, "Device Simulator Core.rar"));
        //        var file = Path.Combine(this.networkPath, targetFile);
        //        if(!File.Exists(file))
        //        {
        //            using(File.Create(file)) { };
        //            using(StreamWriter sw = File.CreateText(file))
        //            {
        //                sw.WriteLine(content);
        //            }
        //        }
        //    }
        //}
    }

}
