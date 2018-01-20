﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SummonerAPI.Entities.Champions
{
    public class Champion
    {
        public Info Info { get; set; }
        public List<string> Enemytips { get; set; }
        public Stats Stats { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public Image Image { get; set; }
        public List<string> Tags { get; set; }
        public string Partype { get; set; }
        public List<Skin> Skins { get; set; }
        public Passive Passive { get; set; }
        public List<Recommended> Recommended { get; set; }
        public List<string> Allytips { get; set; }
        public string Key { get; set; }
        public string Lore { get; set; }
        public int Id { get; set; }
        public string Blurb { get; set; }
        public List<ChampionSpell> Spells { get; set; }
    }
}