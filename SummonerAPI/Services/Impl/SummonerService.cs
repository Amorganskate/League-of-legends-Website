using SummonerAPI.Entities;
using SummonerAPI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using Newtonsoft.Json;
using System.Text;
using SummonerAPI.Entities.Matches;

namespace SummonerAPI.Services.Impl
{
    public class SummonerService : ISummonerService
    {

        #region Class Variables

        private const string APITOKEN = "RGAPI-f3c7a62f-61de-4cf1-afb3-8898d1cff0c9";
        private const string SUMMONER_NAME_PATH = "https://na1.api.riotgames.com/lol/summoner/v3/summoners/by-name/";

        private IErrorService _errorService;

        #endregion

        public SummonerService(IErrorService errorService)
        {
            _errorService = errorService;
        }

        public async Task<SummonerName> getSummonerName(string summonerName)
        {
            HttpResponseMessage response = null;
            SummonerName _summonerName = new SummonerName();
            HttpClient client = new HttpClient();
            string uri = SUMMONER_NAME_PATH + summonerName + "?api_key=" + APITOKEN;

            try
            {
                response = await client.GetAsync(new Uri(uri)).ConfigureAwait(false);

                if (response.IsSuccessStatusCode)
                {
                    var jsonRespnse = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    _summonerName = JsonConvert.DeserializeObject<SummonerName>(jsonRespnse);
                }

            }
            catch (Exception e)
            {
                _errorService.log(e);
            }

            return _summonerName;
        }

        public async Task<MatchList> getMatchList(string accountID)
        {
            HttpResponseMessage response = null;
            MatchList _matchList = new MatchList();
            HttpClient client = new HttpClient();
            string URI = "https://na1.api.riotgames.com/lol/match/v3/matchlists/by-account/" + accountID + "?api_key=" + "RGAPI-409ed417-101c-40c2-910d-4fea663e10a9";

            try
            {
                response = await client.GetAsync(new Uri(URI)).ConfigureAwait(false);

                if (response.IsSuccessStatusCode)
                {
                    var jsonresponse = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    _matchList = JsonConvert.DeserializeObject<MatchList>(jsonresponse);
                }
            }
            catch(Exception e)
            {
                _errorService.log(e);
            }

            return _matchList;
        }
    }
}