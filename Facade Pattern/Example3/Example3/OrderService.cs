using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example3
{
    public class OrderService
    {
        private readonly OnlineRestaurant _restaurant;
        private readonly ShippingService _service;

        public OrderService(OnlineRestaurant resturant, ShippingService service)
        {
            _restaurant = resturant;
            _service = service;
        }

        public void OrderFood(IEnumerable<Order> orders)
        {
            foreach(var order in orders)
            {
                _restaurant.AddOrderToCart(order);
            }

            _restaurant.CompleteOrders();

            foreach(var order in orders)
            {
                _service.AcceptOrder(order);
                _service.CalculateShippingExpenses();
                _service.ShipOrder();
            }       
        }
    }
}
