﻿using APIDev.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace APIDev.Controllers
{
    public class InsertController : ApiController
    {
        // GET api/insert
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/insert/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/insert
        public bool Post([FromBody]Data.Insert insert)
        {
            return Data.Insert.Insertdata(insert);
        }

        // PUT api/insert/5
        public void Put(int id, [FromBody]string value)
        {

        }

        // DELETE api/insert/5
        public void Delete(int id)
        {
        }
    }
}