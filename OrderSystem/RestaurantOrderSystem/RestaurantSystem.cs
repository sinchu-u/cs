using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace RestaurantOrderSystem
{
    public class RestaurantSystem
    {
        public List<Order> Orders = new List<Order>();
        public List<MenuItem> MenuItems = new List<MenuItem>();
        public void AddItem(MenuItem item)
        {
            MenuItems.Add(item);
        }
        public void ShowMenu()
        {
            Console.WriteLine();
            Console.WriteLine("==================МЕНЮ==================");
            Console.WriteLine();
            Console.WriteLine("--------------Перші страви--------------");
            foreach (MenuItem item in MenuItems)
            {
                if (item is Dish dishItem && dishItem.Type == DishType.First)
                {
                    Console.WriteLine($"{dishItem.Name} ({dishItem.Weight}г) - {dishItem.Price} грн");
                }
            }
            Console.WriteLine();
            Console.WriteLine("--------------Другі страви--------------");
            foreach (MenuItem item in MenuItems)
            {
                if (item is Dish dishItem && dishItem.Type == DishType.Second)
                {
                    Console.WriteLine($"{dishItem.Name} ({dishItem.Weight}г) - {dishItem.Price} грн");
                }
            }
            Console.WriteLine();
            Console.WriteLine("-----------------Десерти----------------");
            foreach (MenuItem item in MenuItems)
            {
                if (item is Dish dishItem && dishItem.Type == DishType.Dessert)
                {
                    Console.WriteLine($"{dishItem.Name} ({dishItem.Weight}г) - {dishItem.Price} грн");
                }
            }
            Console.WriteLine();
            Console.WriteLine("------------Алкогольні напої------------");
            foreach (MenuItem item in MenuItems)
            {
                if (item is Drink drinkItem && drinkItem.IsAlcoholic)
                {
                    Console.WriteLine($"{drinkItem.Name} ({drinkItem.Volume}мл) - {drinkItem.Price} грн");
                }
            }
            Console.WriteLine();
            Console.WriteLine("-----------Безалкогольні напої----------");
            foreach (MenuItem item in MenuItems)
            {
                if (item is Drink drinkItem && !drinkItem.IsAlcoholic)
                {
                    Console.WriteLine($"{drinkItem.Name} ({drinkItem.Volume}мл) - {drinkItem.Price} грн");
                }
            }
            Console.WriteLine();
            Console.WriteLine("========================================");
            Console.WriteLine();
        }
        public void SearchMenu(string name)
        {
            name = name.ToLower();
            Console.WriteLine();
            Console.WriteLine($"> Позиції в меню зі словом '{name}':");
            Console.WriteLine("----------------------------------------");
            foreach (MenuItem item in MenuItems)
            {
                string lowName = item.Name.ToLower();
                if (lowName.Contains(name))
                {
                    if (item is Dish dishItem)
                    {
                        Console.WriteLine($"{dishItem.Name} ({dishItem.Weight}г) - {dishItem.Price} грн");
                    }
                    else if (item is Drink drinkItem)
                    {
                        Console.WriteLine($"{drinkItem.Name} ({drinkItem.Volume}мл) - {drinkItem.Price} грн");
                    }
                }
            }
            Console.WriteLine("----------------------------------------");
            Console.WriteLine();
        }
        public void AddOrder(Order order)
        {
            Orders.Add(order);
            Console.WriteLine();
            Console.WriteLine($"> Створено замовлення для столику з номером {order.Table}");
            Console.WriteLine();
        }
        public void ShowOrders()
        {
            Console.WriteLine();
            Console.WriteLine("---------------ЗАМОВЛЕННЯ---------------");
            foreach (Order order in Orders)
            {
                if (order.Status != OrderStatus.Paid)
                {
                    Console.WriteLine();
                    Console.WriteLine($"Номер: {order.Id}, столик: {order.Table}, статус: {order.Status}, сума: {order.GetTotal()}");
                    Console.WriteLine();
                    Console.WriteLine("----------------------------------------");
                }
            }
            Console.WriteLine();
        }
        public void SearchOrder(int number)
        {
            foreach (Order order in Orders)
            {
                if (number == order.Id)
                {
                    Console.WriteLine();
                    Console.WriteLine($"> Знайдене замовлення з номером {number}:");
                    Console.WriteLine("----------------------------------------");
                    Console.WriteLine($"Статус: {order.Status}");
                    Console.WriteLine("----------------------------------------");
                    foreach (OrderItem item in order.Items)
                    {
                        Console.WriteLine($"{item.Item.Name} (х{item.Amount}) - {item.ItemPrice()} грн");
                    }
                    Console.WriteLine("----------------------------------------");
                    Console.WriteLine($"Сума: {order.GetTotal()}");
                    Console.WriteLine("----------------------------------------");
                    Console.WriteLine();
                }
            }
        }
    }
}
