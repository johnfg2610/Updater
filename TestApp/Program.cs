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
            Class1 class1 = new Class1();
            Console.WriteLine(class1.GetVersionInformation());
        }
    }
}