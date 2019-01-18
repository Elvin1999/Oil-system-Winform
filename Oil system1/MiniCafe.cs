using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oil_system1
{
    class Food
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int Count { get; set; }
    }
    class Gasoline
    {
        public string Name { get; set; }
        public double Price { get; set; }
    }
    class OilSystem
    {
        public double GetAllPrice()
        {
            double price = _Cafe.GetPrice();
            price += _PetrolStation.GetAllPrice();
            return price;
        }
        public MiniCafe _Cafe { get; set; }
        public PetrolStation _PetrolStation { get; set; }
    }
    class MiniCafe
    {
        public double Price { get; set; }
        public double GetPrice()
        {
            Price = 0;
            foreach (var item in foods)
            {
                Price += item.Price * item.Count;
            }
            return Price;
        }
        public List<Food> foods = new List<Food>()
        {
            new Food()
            {
                Name="Hotdog",
                Price=4.00,
                Count=0
            },
            new Food()
            {
                Name="Qamburger",
                Price=5.40,
                Count=0
            },
            new Food()
            {
                Name="Fries",
                Price=7.20,
                Count=0
            },
            new Food()
            {
                Name="Coca-cola",
                Price=4.40,
                Count=0
            },
        };
    }

    class PetrolStation
    {
        public double Liter { get; set; }
        public double Price { get; set; }
        public double AllPrice { get; set; }
        public double GetAllPrice()
        {
            return Liter * Price;
        }
        public List<Gasoline> gasolines = new List<Gasoline>()
        {
            new Gasoline(){
                Name="AI92",
                Price=0.95
            },
            new Gasoline(){
                Name="AI95",
                Price=1.15
            },
            new Gasoline(){
                Name="Dizel",
                Price=0.6
            },
        };
    }

}
