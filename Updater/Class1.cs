using System;
using System.Net;
using System.Xml;
using Newtonsoft.Json.Linq;

namespace Updater
{
    public class Class1
    {

        public string GetVersionInformation(string location)
        {
            var client = new WebClient();

            string json = @client.DownloadString(location);

            JObject o = JObject.Parse(json);

            string ProjectName = (string)o["ProjectName"];

            return ProjectName;
        }

        public string UpdateVersion()
        {

        }
    }
}