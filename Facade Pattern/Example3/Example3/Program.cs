using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example3
{
    class Program
    {
        static void Main(string[] args)
        {
            var restaurant = new OnlineRestaurant();
            var shippingService = new ShippingService();

            OrderService orderService = new OrderService(restaurant, shippingService);
            orderService.OrderFood(new List<Order>()
            {
                new Order() { DishName="Chicken with rice", DishPrice=20, User="Petar Petrovic", ShippingAddress="Random street 123" },
                new Order() { DishName = "Burger", DishPrice = 30, User = "Janko Jankovic", ShippingAddress = "Random street 456" }
            });

            Console.ReadLine();
        }
    }
}
