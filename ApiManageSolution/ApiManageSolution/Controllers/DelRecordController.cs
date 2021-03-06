﻿using ApiManageSolution.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ApiManageSolution.Controllers
{
    public class DelRecordController : ApiController
    {
        // GET api/delrecord
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/delrecord/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/delrecord
        public Data.DelRecord Post([FromBody]Data.DelRecord data)
        {
            try
            {
                return Data.DelRecord.Del(data);
            }
            catch(Exception ex)
            { return null; }
        }

        // PUT api/delrecord/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/delrecord/5
        public void Delete(int id)
        {
        }
    }
}
