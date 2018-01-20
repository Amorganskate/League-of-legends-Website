using League.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace League.Controllers
{
    public class ReviewsController : Controller
    {
        LeaguetoFoodDb _db = new LeaguetoFoodDb();

        // GET: Reviews
        public ActionResult Index([Bind(Prefix = "id")]int restaurantId)
        {
            var restaurant = _db.Restaurants.Find(restaurantId);
            if (restaurant != null)
            {
                return View(restaurant);
            }
            return HttpNotFound();

        }

        [HttpGet]
        public ActionResult Create(int restaurantId)
        {
            return View();
        }

        protected override void Dispose(bool disposing)
        {
            _db.Dispose();
            base.Dispose(disposing);
        }

    }
}