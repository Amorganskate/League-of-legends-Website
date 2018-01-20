using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SummonerAPI.Entities.Champions
{
    public class Recommended
    {
        public string Map { get; set; }
        public List<Block> Blocks { get; set; }
        public string Champion { get; set; }
        public string Title { get; set; }
        public bool Priority { get; set; }
        public string Mode { get; set; }
        public string Type { get; set; }
    }
}