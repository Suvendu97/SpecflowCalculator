using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace UnitTestProject1.Configuration
{
    public class Configuration
    {
        public static string path()
        {
            string path = File.ReadAllText("Apppath.txt");
            Console.WriteLine(path);
            return path;
        }
    }
}

