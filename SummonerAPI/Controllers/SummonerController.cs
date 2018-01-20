using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using SummonerAPI.Entities;
using SummonerAPI.Entities.Matches;
using SummonerAPI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
using System.Web.Http.Results;

namespace SummonerAPI.Controllers
{
    [RoutePrefix("api/SummonerName")]
    public class SummonerController : ApiController
    {
        ISummonerService _summonerService;
        IErrorService _errorService;

        public SummonerController(ISummonerService summonerService, IErrorService errorService)
        {
            _summonerService = summonerService;
            _errorService = errorService;
        }

        [HttpGet]
        [Route("getSummoner")]
        public async Task<SummonerName> getSummoner(string name = null)
        {
            JObject response = new JObject();
            SummonerName jsonresponse = new SummonerName();
            try
            {

                if (!string.IsNullOrEmpty(name))
                {
                    jsonresponse = await _summonerService.getSummonerName(name);
                    response = JObject.FromObject(new { jsonresponse });
                }

               
            }
            catch(Exception e)
            {
                _errorService.log(e);
            }

            return jsonresponse;
        }

        [HttpGet]
        [Route("getMatchList")]
        public async Task<MatchList> getMatchList(string name = null)
        {
            MatchList matchLists = new MatchList();
            JObject response = new JObject();

            try
            {
                if (!string.IsNullOrEmpty(name))
                {
                    SummonerName summonerName = await _summonerService.getSummonerName(name);
                    matchLists = await _summonerService.getMatchList(summonerName.accountId.ToString());
                    response = JObject.FromObject(new { matchLists });
                }
            }
            catch(Exception e)
            {
                _errorService.log(e);
            }

            return matchLists;
        }
    }
}