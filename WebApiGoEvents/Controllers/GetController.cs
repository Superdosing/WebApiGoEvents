using System;
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
        FNyhedFac fnf = new FNyhedFac();

        [Route("api/Get/GetMenu")]
        [HttpGet]
        public IEnumerable<Kategori> GetMenu()
        {
            return kf.GetAll();
        }

        [Route("api/Get/GetForum")]
        [HttpGet]
        public IEnumerable<FNyhed> GetForum()
        {
            return fnf.GetAll();
        }
    }
}
