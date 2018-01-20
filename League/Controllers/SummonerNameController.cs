using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using League.Models;
using League.Entities;
using System.Net;
using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;

namespace League.Controllers
{
    public class SummonerNameController : Controller
    {
        // GET: SummonerName
        public ActionResult Index()
        {
            SummonerName summonerName = new SummonerName();
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> getSummonerName(SummonerNameModel name)
        {
            SummonerName _summonerName = new SummonerName();
            if (ModelState.IsValid)
            {
                
                HttpClient client = new HttpClient();
                string url = "http://localhost:58922/api/summonerName/getSummoner";

                try
                {
                    client.BaseAddress = new Uri(url);
                    HttpResponseMessage Res = await client.GetAsync("?name=" + name.SummonerName);
                    if (Res.IsSuccessStatusCode)
                    {
                        _summonerName = JsonConvert.DeserializeObject<SummonerName>(Res.Content.ReadAsStringAsync().Result);
                    }
                }
                catch (Exception e)
                {
                    
                }

            }

            return View(_summonerName);
        }

    }
}
