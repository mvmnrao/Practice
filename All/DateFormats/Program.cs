using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DateFormats
{
    class Program
    {
        static void Main(string[] args)
        {
            int val = int.Parse(Console.ReadLine());
            Console.WriteLine(DateTime.Now.ToString("yyyymmdd"));
            Console.WriteLine(" ");
            Console.WriteLine(DateTime.Now.ToString("yyyyMMdd"));
            Console.WriteLine(" ");
            Console.WriteLine(DateTime.Now.ToString("hhmss"));
            Console.WriteLine(" ");
            Console.WriteLine(val / 25);
            Console.ReadKey();
            string s = "";
            String S = "";
        }
    }
}
