using System;
namespace Restaurants.Models
{
    public class FastFood: Entity
    {
        public string Name { get; set; }

        public float Price { get; set; }

        public string Url { get; set; }

        public string Desc { get; set; }

        public FastFood(int id, string name, float price, string url, string desc = "")
        {
            Id = id;
            Name = name;
            Price = price;
            Url = url;
            Desc = desc;
        }

        public string SubDesc(int take)
        {
            return new String(Desc.Take(take).ToArray()) + "...";
        }
    }
}
