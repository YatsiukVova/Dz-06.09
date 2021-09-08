using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text;

namespace ConsoleApp1
{
    public static class Logger
    {
        private static string _str = "";
        public static void Info()
        {
            _str += "{" + DateTime.Now+"}: {Info}: {Start method:Info}\n";
            Console.WriteLine("{" + DateTime.Now + "}: {Info}: {Start method:Info}\n");
        }
        public static void Warning()
        {
            _str += "{" + DateTime.Now + "}: {Warning}: {Skipped logic in method:Warning}\n";
            Console.WriteLine("{" + DateTime.Now + "}: {Warning}: {Skipped logic in method:Warning}\n");
        }
        public static void WriteFile()
        {
            File.WriteAllText("log.txt",_str);
        }
    }
}
