using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantOrderSystem
{
    public class Drink : MenuItem
    {
        public int Volume { get; private set; }
        public bool IsAlcoholic {  get; private set; }
        public Drink(string name, decimal price, int volume, bool isAlcoholic) : base(name, price)
        {
            IsAlcoholic = isAlcoholic;
            Volume = volume;
        }
    }
}
