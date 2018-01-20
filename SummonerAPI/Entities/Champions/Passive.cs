using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SummonerAPI.Entities.Champions
{
    public class Passive
    {
        public Image Image { get; set; }
        public string SanitizedDescription { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}