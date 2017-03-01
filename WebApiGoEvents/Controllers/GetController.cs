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
        FDiskussionFac fdf = new FDiskussionFac();
        NyhederFac nf = new NyhederFac();
        ForumlisteFac fl = new ForumlisteFac();

        [Route("api/Get/GetMenu")]
        [HttpGet]
        public IEnumerable<Kategori> GetMenu()
        {
            return kf.GetAll();
        }

        [Route("api/Get/GetForumN")]
        [HttpGet]
        public IEnumerable<FNyhed> GetForumN()
        {
            return fnf.GetAll();
        }

        [Route("api/Get/GetForumD")]
        [HttpGet]
        public IEnumerable<FDiskussion> GetForumD()
        {
            return fdf.GetAll();
        }
        [Route("api/Get/GetNyheder")]
        [HttpGet]
        public IEnumerable<Nyheder> GetNyheder()
        {
            return nf.GetAll();
        }
        [Route("api/Get/GetForuml")]
        [HttpGet]
        public IEnumerable<Forumliste> GetForuml()
        {
            return fl.GetAll();
        }
    }
}
