using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantOrderSystem
{
    public enum OrderStatus
    {
        New,
        InProgress,
        Ready,
        Paid
    }
    public class Order
    {
        private static int orderCount = 0;
        public int Id { get; private set; }
        public int Table { get; set; }
        public List<OrderItem> Items;
        public OrderStatus Status { get; private set; } = OrderStatus.New;
        public Order(int table)
        {
            orderCount++;
            Id = orderCount;
            Table = table;
            Items = new List<OrderItem>();
        }
        public void AddItem(MenuItem item, int amount)
        {
            Items.Add(new OrderItem(item, amount));
            Console.WriteLine($"Додано позицію '{item.Name}'.");
        }
        public void RemoveItem(string name)
        {
            OrderItem foundItem = null;
            foreach (var item in Items)
            {
                if (item.Item.Name == name)
                {
                    foundItem = item; break;
                }
            }
            if (foundItem != null)
            {
                Items.Remove(foundItem);
                Console.WriteLine($"Прибрано позицію '{foundItem.Item.Name}'.");
            }
        }
        public decimal GetTotal()
        {
            decimal sum = 0;
            foreach (OrderItem item in Items)
            {
                sum += item.ItemPrice();
            }
            return sum;
        }
        public void SetStatus(OrderStatus newStatus)
        {
            Status = newStatus;
        }
    }
}
