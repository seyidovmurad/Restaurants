using System;
namespace Restaurants.Models
{
    public class HotMeal: Entity
    {
        public string Name { get; set; }

        public float Price { get; set; }

        public string Url { get; set; }

        public string Desc { get; set; }

        public bool IsSpicy { get; set; }

        public HotMeal(int id, string name, float price,bool isSpicy, string url, string desc = "")
        {
            Id = id;
            Name = name;
            Price = price;
            IsSpicy = isSpicy;
            Url = url;
            Desc = desc;
        }

        public string SubDesc(int take)
        {
            return new String(Desc.Take(take).ToArray()) + "...";
        }
    }
}

