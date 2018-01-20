namespace League.Migrations
{
    using Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<LeaguetoFoodDb>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(LeaguetoFoodDb context)
        {
            context.Restaurants.AddOrUpdate(r => r.Name,
                new Restaurant { Name = "Alfred", City = "Camden", Country = "USA" },
                new Restaurant { Name = "Ben", City = "Liverpool", Country = "USA" },
                new Restaurant
                {
                    Name = "Franklin",
                    City = "Syracuse",
                    Country = "USA",
                    Reviews = new List<RestaurantReview> {
                            new RestaurantReview {Rating = 9, Body="Great Food!", ReviewerName="Scott" }
                    }
                });
        }
    }
}
