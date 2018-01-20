using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SummonerAPI.Entities.Champions
{
    public class ChampionsList
    {
        public Dictionary<string, string> Keys { get; set; }
        public Dictionary<string, string> Data { get; set; }
        public string Version { get; set; }
        public string Type { get; set; }
        public string Format { get; set; }
    }
}