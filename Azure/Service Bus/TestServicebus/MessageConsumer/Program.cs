using Microsoft.ServiceBus.Messaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace MessageConsumer
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = QueueClient.Create("test");
            client.OnMessage((mess) => {

                WriteLine($"Processing message Id: {mess.MessageId}, Body: {mess.GetBody<string>()}");
            });

            Read();
        }
    }
}
