using League.Entities;
using League.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace League.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Index(string searchTerm = null)
        {

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

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