using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantOrderSystem
{
    public abstract class MenuItem
    {
        public string Name { get; private set; }
        public decimal Price { get; private set; }
        public MenuItem(string name, decimal price)
        {
            Name = name;
            Price = price;
        }
    }
}
