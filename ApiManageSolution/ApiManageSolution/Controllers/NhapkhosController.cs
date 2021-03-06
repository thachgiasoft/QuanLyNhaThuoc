﻿using ApiManageSolution.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ApiManageSolution.Controllers
{
    public class NhapkhosController : ApiController
    {
        // GET api/nhapkhos
        public IEnumerable<Data.Nhapkhos> Get()
        {
            return Data.Nhapkhos.Get("");
        }

        // GET api/nhapkhos/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/nhapkhos
        public IEnumerable<Data.Nhapkhos> Post([FromBody]Data.NhapAlls data)
        {
            try
            {
                return Data.NhapAlls.Upd(data);
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        // PUT api/nhapkhos/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/nhapkhos/5
        public void Delete(int id)
        {
        }
    }
}
