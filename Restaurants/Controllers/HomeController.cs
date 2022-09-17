using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Restaurants.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Restaurants.Controllers
{
    public class HomeController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            var foodVM = new FoodViewModel
            {
                FastFoods = Data.GetFastFoods(),
                HotMeals = Data.GetHotMeals(),
                Drinks = Data.GetDrinks()
            };

            return View(foodVM);
        }

        public IActionResult FastFood()
        {
            return View(Data.GetFastFoods());
        }

        public IActionResult Drink()
        {
            return View(Data.GetDrinks());
        }

        public IActionResult Meal()
        {
            return View(Data.GetHotMeals());
        }
    }
}

