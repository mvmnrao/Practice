using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CalculateChecksum
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dateTime = DateTime.Parse("09-20-2017 18:04:51");
            List<string> fields = new List<string>() {
                                                        dateTime.ToString(),
                                                        dateTime.AddDays(1).ToString(),
                                                        dateTime.AddMilliseconds(1).ToString(),
                                                        dateTime.ToString(),
                                                        dateTime.AddDays(2).ToString(),
                                                        dateTime.AddMilliseconds(2).ToString(),
                                                        dateTime.AddDays(3).ToString(),
                                                        dateTime.AddMilliseconds(3).ToString(),
                                                        dateTime.ToString(),
                                                        dateTime.AddDays(4).ToString(),
                                                        dateTime.AddMilliseconds(4).ToString(),
                                                        dateTime.AddDays(5).ToString(),
                                                        dateTime.AddMilliseconds(5).ToString(),
                                                        dateTime.ToString(),
                                                        dateTime.AddDays(6).ToString(),
                                                        dateTime.AddMilliseconds(6).ToString(),
                                                        dateTime.AddDays(7).ToString(),
                                                        dateTime.AddMilliseconds(7).ToString(),
                                                        dateTime.ToString(),
                                                        dateTime.AddDays(8).ToString(),
                                                        dateTime.AddMilliseconds(8).ToString(),
            "this is sample string for checksum",
            "this is sample string for checksumthis is sample string for checksumthis is sample string for checksumthis is sample string for checksum",
            "this is sample string for checksumthis is sample string for checksumthis is sample string for checksumthis is sample string for checksum",
            "this is sample string for checksumthis is sample string for checksumthis is sample string for checksumthis is sample string for checksum",
            "this is sample string for checksumthis is sample string for checksumthis is sample string for checksumthis is sample string for checksum"};

            StringBuilder fieldValuesJoined = new StringBuilder();
            //foreach (string field in fields)
            //{
            //    fieldValuesJoined.Append(field);
            //}
            string str = string.Join("\x06", fields);

            using (var sha1 = new SHA1Managed())
            {
                string checksum = string.Join(string.Empty, sha1.ComputeHash(Encoding.UTF8.GetBytes(str)).Select(_ => _.ToString("X2")).ToArray());
                Console.WriteLine(checksum);
            }
            //MD5.Create().ComputeHash()
            Console.ReadKey();
        }
    }
}
