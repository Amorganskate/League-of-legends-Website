using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SummonerAPI.Entities
{
    public class SummonerName
    {

        public int profileIconId { get; set; }
        public string name { get; set; }
        public long summonerLevel { get; set; }
        public long revisionDate { get; set; }
        public long id { get; set; }
        public long accountId { get; set; }
    }
}
