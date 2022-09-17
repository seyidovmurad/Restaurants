using System;
namespace Restaurants.Models
{
    public class Drink: Entity
    {
        public bool IsHot { get; set; }

        public string Name { get; set; }

        public string Url { get; set; }

        public float Price { get; set; }

        public Drink(int id, string name, float price, bool isHot, string url)
        {
            Id = id;
            Name = name;
            Price = price;
            IsHot = isHot;
            Url = url;
        }
    }
}

