﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example3
{
    public class CompositeGift : GiftBase, IGiftOperations
    {
        private List<GiftBase> _gifts;

        public CompositeGift(string name, int price):base(name,price)
        {
            _gifts = new List<GiftBase>();
        }

        public void Add(GiftBase gift)
        {
            _gifts.Add(gift);
        }

        public void Remove(GiftBase gift)
        {
            _gifts.Remove(gift);
        }

        public override int CalculateTotalPrice()
        {
            int total = 0;

            Console.WriteLine($"{name} contains the following products with prices:");

            foreach (var gift in _gifts)
            {
                total += gift.CalculateTotalPrice();
            }

            return total;
        }
    }
}
