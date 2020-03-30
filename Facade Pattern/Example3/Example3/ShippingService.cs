﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example3
{
    public class ShippingService
    {
        private Order _order;

        public void AcceptOrder(Order order)
            => _order = order;

        public void CalculateShippingExpenses()
            => _order.ShippingPrice = 15.5;

        public void ShipOrder()
        {
            Console.WriteLine(_order.ToString());
            Console.WriteLine("Order is being shipped to {0}...", _order.ShippingAddress);
        }
    }
}
