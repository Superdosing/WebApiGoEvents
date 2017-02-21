using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using GoREPO.Factories;
using GoREPO.Models;

namespace WebApiGoEvents.Controllers
{
    public class PostController : ApiController
    {

        NyhederFac nf = new NyhederFac();
        EventsFac ef = new EventsFac();
        FDiskussionFac fdf = new FDiskussionFac();
        FNyhedFac fnf = new FNyhedFac();
        

        
    }
}
