using System;
using System.Net;

namespace Updater
{
    public class Class1
    {
        public void CheckSorce(string location)
        {
            using (var client = new WebClient())
            {
                client.DownloadFile("https://raw.githubusercontent.com/Johnfg12/Updater/master/Version", "txt");
            }
        }
    }
}