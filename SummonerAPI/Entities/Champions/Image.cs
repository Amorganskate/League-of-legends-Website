using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SummonerAPI.Entities.Champions
{
    public class Image
    {
        public string Full { get; set; }
        public string Group { get; set; }
        public string Sprite { get; set; }
        public int h { get; set; }
        public int w { get; set; }
        public int y { get; set; }
        public int x { get; set; }
    }
}