using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example4
{
    public class CompositeGift : IGift
    {
        private List<IGift> _gifts = new List<IGift>();
        private string _name;

        public CompositeGift(string name)
        {
            _name = name;
        }

        public void Add(IGift gift)
            => _gifts.Add(gift);

        public int CalculateTotalPrice()
        {
            int total = 0;
            Console.WriteLine($"{_name} contains the following products with prices:");

            foreach (var gift in _gifts)
                total += gift.CalculateTotalPrice();

            return total;
        }
    }
 }
