using Microsoft.ServiceBus.Messaging;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace MessageCreator
{
    class Program
    {
        static void Main(string[] args)
        {
            //var connstr = ConfigurationManager.ConnectionStrings["Microsoft.ServiceBus.ConnectionString"].ConnectionString;
            var client = QueueClient.Create("test");

            var lastKey = ' ';
            var count = 1;
            while(lastKey != 'q')
            {
                var body = $"Count {count++}";
                var message = new BrokeredMessage(body);
                client.Send(message);

                WriteLine($"Sending Message with Id{message.MessageId}");
                lastKey = ReadKey().KeyChar;
            }
            Read();
        }
    }
}
