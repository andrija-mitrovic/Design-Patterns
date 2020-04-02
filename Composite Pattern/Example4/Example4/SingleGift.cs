using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example4
{
    public class SingleGift : IGift
    {
        private string _name;
        private int _price;

        public SingleGift(string name, int price)
        {
            _name = name;
            _price = price;
        }

        public int CalculateTotalPrice()
        {
            Console.WriteLine($"{_name} with the price {_price}");

            return _price;
        }
    }
}
