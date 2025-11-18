namespace RestaurantOrderSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RestaurantSystem restaurant = new RestaurantSystem();
            Drink drink1 = new Drink("Вода", 20.99m, 500, false);
            Drink drink2 = new Drink("Вино", 70.99m, 300, true);
            Drink drink3 = new Drink("Сік у асортименті", 50.35m, 500, false);
            Drink drink4 = new Drink("Пиво", 55.65m, 450, true);
            Dish dish1 = new Dish("Борщ", 120m, 400, DishType.First);
            Dish dish2 = new Dish("Салат 'Цезар'", 80.50m, 300, DishType.Second);
            Dish dish3 = new Dish("Вишневий чизкейк", 73.10m, 150, DishType.Dessert);
            Dish dish4 = new Dish("Солянка", 112.50m, 300, DishType.First);
            Dish dish5 = new Dish("Шніцель", 187.35m, 230, DishType.Second);
            Dish dish6 = new Dish("Вафлі з вишнями", 57.99m, 200, DishType.Dessert);

            restaurant.AddItem(drink1);
            restaurant.AddItem(drink2);
            restaurant.AddItem(drink3);
            restaurant.AddItem(drink4);
            restaurant.AddItem(dish1);
            restaurant.AddItem(dish2);
            restaurant.AddItem(dish3);
            restaurant.AddItem(dish4);
            restaurant.AddItem(dish5);
            restaurant.AddItem(dish6);

            restaurant.ShowMenu();

            Order order1 = new Order(2);
            restaurant.AddOrder(order1);
            order1.AddItem(drink1, 2);
            order1.AddItem(dish1, 2);
            order1.AddItem(dish3, 1);
            order1.SetStatus(OrderStatus.Ready);

            Order order2 = new Order(14);
            restaurant.AddOrder(order2);
            order2.AddItem(drink3, 2);
            order2.AddItem(dish2, 1);
            order2.AddItem(dish5, 2);
            order2.AddItem(dish6, 1);

            Order order3 = new Order(5);
            restaurant.AddOrder(order3);
            order3.AddItem(drink1, 1);
            order3.AddItem(dish4, 1);
            order3.SetStatus(OrderStatus.Paid);

            restaurant.ShowOrders();

            restaurant.SearchOrder(2);
            order2.RemoveItem("Салат 'Цезар'");
            restaurant.SearchOrder(2);

            restaurant.SearchOrder(3);

            restaurant.SearchMenu("вафлі");
        }
    }
}
