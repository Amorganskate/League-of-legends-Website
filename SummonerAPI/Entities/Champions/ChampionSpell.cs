using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SummonerAPI.Entities.Champions
{
    public class ChampionSpell
    {
        public string CooldownBurn { get; set; }
        public string Resource { get; set; }
        public LevelTip LevelTip { get; set; }
        public List<SpellVars> Vars { get; set; }
        public string CostType { get; set; }
    }
}