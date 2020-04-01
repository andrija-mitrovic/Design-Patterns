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

            ModifyPrice modify = new ModifyPrice();
            var product = new Product("Phone", 500);

            modify.SetCommand(new ProductCommand(product, PriceAction.Increase, 100));
            modify.Invoke();
            modify.SetCommand(new ProductCommand(product, PriceAction.Increase, 50));
            modify.Invoke();
            modify.SetCommand(new ProductCommand(product, PriceAction.Decrease, 25));
            modify.Invoke();
            Console.WriteLine(product.ToString());

            modify.UndoActions();
            Console.WriteLine(product.ToString());
            Console.ReadLine();
        }
    }
}
