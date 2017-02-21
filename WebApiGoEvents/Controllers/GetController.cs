﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using GoREPO.Factories;
using GoREPO.Models;
using Newtonsoft.Json.Linq;

namespace WebApiGoEvents.Controllers
{
    public class GetController : ApiController
    {
        KategoriFac kf = new KategoriFac();

        [Route("api/Get/GetMenu")]
        [HttpGet]
        public IEnumerable<Kategori> GetMenu()
        {
            return kf.GetAll();
        }
    }
}
