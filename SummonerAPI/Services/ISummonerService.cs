using SummonerAPI.Entities;
using SummonerAPI.Entities.Matches;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace SummonerAPI.Services
{
    public interface ISummonerService
    {
        Task<SummonerName> getSummonerName(string summonerName);
        Task<MatchList> getMatchList(string accountID);
    }
}
