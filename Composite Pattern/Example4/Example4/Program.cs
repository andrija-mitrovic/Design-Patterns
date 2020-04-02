using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example4
{
    class Program
    {
        static void Main(string[] args)
        {
            var phone = new SingleGift("Phone", 256);
            phone.CalculateTotalPrice();

            var rootBox = new CompositeGift("RootBox");
            rootBox.Add(new SingleGift("TruckToy", 289));
            rootBox.Add(new SingleGift("PlainToy", 587));

            var childBox = new CompositeGift("ChildBox");
            var soldierToy = new SingleGift("SoldierToy", 200);
            childBox.Add(soldierToy);
            rootBox.Add(childBox);

            Console.WriteLine($"Total price of this composite present is: {rootBox.CalculateTotalPrice()}");

            Console.ReadLine();
        }
    }
}
