using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example3
{
    public class OrderDecorator : OrderBase
    {
        private readonly OrderBase _order;
        public OrderDecorator(OrderBase order)
        {
            _order = order;
        }
        public override double CalculateTotalOrderPrice()
        {
            Console.WriteLine($"Calculating the total price in a decorator class");
            return _order.CalculateTotalOrderPrice();
        }
    }
}
