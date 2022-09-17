using System;
using Restaurants.Models;

namespace Restaurants
{
    public class Data
    {

        public static List<Drink> GetDrinks()
        {
            return new List<Drink>{

                new Drink(1, "Ayran", 1.5f, false, "https://www.atena.az/files/cache/images/194/789b25fa850fa24ea2a2bffc39e202c9.png"),
                new Drink(2, "Portağal şirəsi", 2.3f, false, "https://mcdonalds.az/images/5bca708900fb24aed0548b3d01274835.png"),
                new Drink(3, "Coca-Cola", 2f, false, "https://mcdonalds.az/images/741b302ffda5791904f94c1d00975da1.jpg"),
                new Drink(4, "Sprite", 2f, false, "https://mcdonalds.az/images/e0dd73fecc7af4e11d55e188e410c6cf.jpg"),
                new Drink(5, "Fanta", 2f, false, "https://mcdonalds.az/images/54abe395562f594f1619a2ebe6806086.jpg"),
                new Drink(6, "Cay", 1f, true, "https://img.freepik.com/premium-photo/cup-tea-isolated-white-background_219958-23.jpg?w=2000"),
                new Drink(7, "Kofe", 3.5f, true, "https://media.istockphoto.com/photos/cup-of-coffee-latte-isolated-on-white-background-with-clipping-path-picture-id1211524213?k=20&m=1211524213&s=170667a&w=0&h=X8kG9hlyZHlgrulBQkHgZxKYX6FWxLmLw8X6nb9PQXk=")
            };
            
        }

        public static List<FastFood> GetFastFoods()
        {
            return new List<FastFood>
            {
                new FastFood(1, "Big Mac", 3.7f, "https://mcdonalds.az/images/f5c13f50671b10174eb688c9e3403c09.jpg", "Küncütlü bulkanın arasında iki ədəd 100% mal ətindən döyülmüş bifşteks, soğan, iki dilim duzlu xiyar, Çedder pendirinin 1 dilimi, Aysberq salatı və xüsusi Big Mac™ sousu."),
                new FastFood(2, "Dabl Çizburger", 2.9f, "https://mcdonalds.az/images/330ec81e923dae859dc5f77017cd3386.jpg", "Karamelləşdirilmiş bulkanın arasında iki ədəd 100% mal ətindən döyülmüş bifşteks, 2 Çedder pendirinin dilimi, xardal, ketçup, soğan və duzlu xiyar dilimləri."),
                new FastFood(3, "Frenç Frayz", 3f, "https://mcdonalds.az/images/31323ee526b0ca6b84abb356218c69ca.png", "Fritürda qızılı rəngədək qızardılmış və bir balaca duzlanmış xırçıldayan kartof çubuqları"),
                new FastFood(4, "Çiken McNuggets", 4.5f, "https://mcdonalds.az/images/3fc7ffafe2014a470c7c048ed9bf89af.png", "Fritürda, unda qızardılmış xırçıldayan toyuq filesinin dilimləri."),
                new FastFood(5, "Toyuq qanadları", 3.7f, "https://mcdonalds.az/images/eec170dd5bc3cab3f86f9fabf4531f29.png", "Ədviyyəli və qədərində xırçıltılı toyuq qanadları.")
            };
        }

        public static List<HotMeal> GetHotMeals()
        {
            return new List<HotMeal>
            {
                new HotMeal(1, "KAHRAMAN MARAŞ YOĞURTLU KABAB", 9.5f, true, "https://mado.az/pics/580/580/product/86/yoqurtlu-kebap_1577038263.jpg", "İzqara barmaq köftə, qatıq, kərə yağı, pomidor sousu, xüsusi çörək."),
                new HotMeal(2, "QUZU ƏTLİ NAR QOVURMA", 15.5f, false, "https://mado.az/pics/580/580/product/89/et-nar-qovurma_1577038290.jpg", "Quzu əti, şabalıd, nar, nar sousu, soğan, kərə yağı, göyərti."),
                new HotMeal(3, "TOYUQ RULETİ", 10.5f, false, "https://mado.az/pics/580/580/product/94/TOYUQ_RULET_1633959101.jpg", "Toyuq file, qoz, qırmızı soğan, nar əzməsi, nar, sumaq, pul bibər, kərə yağı, düyü plov."),
                new HotMeal(4, "TOYUQ ÇÖP ŞİŞ", 11.5f, true, "https://mado.az/pics/580/580/product/97/toyuq-chop-shish_1577091600.jpg", "Marinə edilmiş toyuq filesi, bibər, çeri pomidor, kartof fri."),
                new HotMeal(5, "MİNİ ŞAH PLOV", 6, false, "https://mado.az/pics/580/580/product/412/24._Mini_ah_Plov_1579344929.jpg", "Düyü, quzu əti, şabalıd, qaysı qurusu, albuxara turşusu, sarı kişmiş, kərə yağı."),
            };
        }
    }
}

