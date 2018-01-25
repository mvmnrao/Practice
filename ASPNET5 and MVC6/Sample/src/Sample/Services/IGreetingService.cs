using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sample.Services
{
    public class GreetingMessage
    {
        public int ID { get; set; }

        public string Message { get; set; }
    }

    public interface IGreetingService
    {
        GreetingMessage GetGreetingMessage();
    }

    public class GreetingService : IGreetingService
    {
        int count;
        IConfiguration _config;

        public GreetingService(IConfiguration config)
        {
            _config = config;
        }

        public GreetingMessage GetGreetingMessage()
        {
            count += 1;
            return new GreetingMessage
            {
                ID = count,
                Message = _config["message"]
            };
        }
    }
}
