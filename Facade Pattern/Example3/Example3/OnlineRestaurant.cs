using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example3
{
    public class OnlineRestaurant
    {
        private readonly List<Order> _orders;

        public OnlineRestaurant()
        {
            _orders = new List<Order>();
        }

        public void AddOrderToCart(Order order)
            => _orders.Add(order);

        public void CompleteOrders() 
            => Console.WriteLine("Orders completed. Dispatch in progress...");
    }
}
