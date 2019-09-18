using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//
using System.IO;

namespace file_search
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("SCAN....");
            GetAllFilesForExtension(@"C:\");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("FINALIZED.....");
            Console.ReadKey();
            //
        }

        //
        private static void GetAllFilesForExtension(string sDir)
        {
            foreach (string dir in Directory.GetDirectories(sDir))
            {
                string found = "Found file: ";
                try
                {
                    foreach (string file in Directory.GetFiles(dir, "*.tmp"))
                    {
                        string ar = Path.GetFileName(file);
                        string fd = file;
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine(found + ar);
                        //File.Delete(fd);
                    }
                    //
                    foreach (string file in Directory.GetFiles(dir, "*._mp"))
                    {
                        string ar = Path.GetFileName(file);
                        string fd = file;
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine(found + ar);
                        //File.Delete(fd);
                    }
                    //
                    foreach (string file in Directory.GetFiles(dir, "*.log"))
                    {
                        string ar = Path.GetFileName(file);
                        string fd = file;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine(found + ar);
                        //File.Delete(fd);
                    }
                    //
                    foreach (string file in Directory.GetFiles(dir, "*.gid"))
                    {
                        string ar = Path.GetFileName(file);
                        string fd = file;
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine(found + ar);
                        //File.Delete(fd);
                    }
                    //
                    foreach (string file in Directory.GetFiles(dir, "*.chk"))
                    {
                        string ar = Path.GetFileName(file);
                        string fd = file;
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine(found + ar);
                        //File.Delete(fd);
                    }
                    //
                    foreach (string file in Directory.GetFiles(dir, "*.old"))
                    {
                        string ar = Path.GetFileName(file);
                        string fd = file;
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine(found + ar);
                        //File.Delete(fd);
                    }
                    //
                    //recursive
                    GetAllFilesForExtension(dir);
                }
                catch (Exception Error)
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine(Error.Message);
                }
            }
        }
    }
}
