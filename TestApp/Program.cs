using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using Updater;

namespace TestApp
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            using (var client = new WebClient())
            {
                Console.WriteLine(client.DownloadString("https://raw.githubusercontent.com/Johnfg12/Updater/master/Version"));
            }
        }
    }
}