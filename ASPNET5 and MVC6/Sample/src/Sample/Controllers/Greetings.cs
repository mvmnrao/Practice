﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using Sample.Services;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace Sample.Controllers
{
    [Route("api/[controller]")]
    public class Greetings : Controller
    {
        IGreetingService _srvc;

        public Greetings(IGreetingService srvc)
        {
            _srvc = srvc;
        }

        // GET: api/values
        [HttpGet]
        public GreetingMessage Get()
        {
            return _srvc.GetGreetingMessage();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
