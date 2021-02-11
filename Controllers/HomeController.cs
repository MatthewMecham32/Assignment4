using Assignment4.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment4.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            List<string> restaurantList = new List<string>();

            foreach(Restaurant r in Restaurant.GetRestaurants())
            {
                //This will give fav dish a value if it is null
                if (r.FavoriteDish == null)
                {
                    r.FavoriteDish = "It's all tasty!";
                }
                //create the restaurant list
                restaurantList.Add(string.Format("#Rank {0}: Name:{1} FavDish:({2})  Address:{3}  Phone:{4}  Website:<a href=\"{5}\">{5}</a>", r.Rank, r.RestaurantName, r.FavoriteDish, r.Address, r.Phone, r.rLink));
            }
            //send list to the view
            return View(restaurantList);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Suggestions()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Suggestions(RestaurantSuggestions restaurantSuggestions)
        {
            //check to see if the data is entered correctly, if so bring up the list page and store the info temporarily
            if(ModelState.IsValid)
            {
                TempStorage.AddEntry(restaurantSuggestions);
                return View("SuggestionList", TempStorage.Entry);
            }
            else
            {
                return View();
            }
        }

        public IActionResult SuggestionList()
        {
            //use temp storage in the view
            return View(TempStorage.Entry);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
