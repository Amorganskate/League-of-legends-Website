using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace League.Entities
{
    public class MatchList
    {
        public List<MatchReference> Matches { get; set; }
        public int TotalGames { get; set; }
        public int StartIndex { get; set; }
        public int EndIndex { get; set; }
    }
}