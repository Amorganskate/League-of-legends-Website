using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SummonerAPI.Entities.Matches
{
    public class MatchReference
    {
        public string Lane { get; set; }
        public long GameId { get; set; }
        public int Champion { get; set; }
        public string PlatformId { get; set; }
        public int Season { get; set; }
        public int Queue { get; set; }
        public string Role { get; set; }
        public long TimeStamp { get; set; }
    }
}