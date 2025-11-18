using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantOrderSystem
{
    public enum DishType
    {
        First,
        Second,
        Dessert
    }
    public class Dish : MenuItem
    {
        public int Weight { get; private set; }
        public DishType Type { get; private set; }
        public Dish(string name, decimal price, int weight, DishType type) : base(name, price)
        {
            Type = type;
            Weight = weight;
        }
    }
}
