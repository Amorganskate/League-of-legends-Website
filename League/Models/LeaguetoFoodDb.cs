using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace League.Models
{
    public class LeaguetoFoodDb : DbContext
    {
        public LeaguetoFoodDb() : base("name=DefaultConnection")
        {

        }

        public DbSet<Restaurant> Restaurants { get; set; }
        public DbSet<RestaurantReview> Reviews { get; set; }

        public System.Data.Entity.DbSet<League.Entities.SummonerName> SummonerNames { get; set; }
    }
}