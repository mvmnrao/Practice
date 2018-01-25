using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GetServerName
{
    class Program
    {
        static void Main(string[] args)
        {
            System.IO.File.Copy(@"D:\Manik\Practice\GetServerName\GetServerName\Temp.txt", @"D:\Manik\Practice\GetServerName\GetServerName\Temp\Sample.txt");

            Console.WriteLine(System.Environment.MachineName);
            Console.ReadKey();
        }
    }
}
