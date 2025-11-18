using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantOrderSystem
{
    public class OrderItem
    {
        public MenuItem Item { get; private set; }
        public double Amount { get; private set; }
        public decimal ItemPrice()
        {
            return Item.Price * Convert.ToDecimal(Amount);
        }
        public OrderItem(MenuItem item, double amount)
        {
            Item = item;
            Amount = amount;
        }
    }
}
