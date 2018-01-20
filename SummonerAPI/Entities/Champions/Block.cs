using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SummonerAPI.Entities.Champions
{
    public class Block
    {
        public List<BlockItem> Items { get; set; }
        public bool Recmath { get; set; }
        public string Type { get; set; }
    }
}