using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SummonerAPI.Controllers
{
    [RoutePrefix("api/home")]
    public class HomeController : Controller
    {
       [HttpGet]
       public string get()
        {
            return "SUMMONER RIFT WEB-API";
        }
    }
}
