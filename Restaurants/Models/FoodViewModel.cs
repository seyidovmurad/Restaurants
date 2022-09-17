using System;
namespace Restaurants.Models
{
    public class FoodViewModel
    {
        public List<FastFood> FastFoods { get; set; }

        public List<HotMeal> HotMeals { get; set; }

        public List<Drink> Drinks { get; set; }
    }
}

