using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example2
{
    class Program
    {
        static void Main(string[] args)
        {
            var tax = new HighTax(new BaseTax(new LowTax()));
            Console.WriteLine(tax.CalculateTax(5000));

            Console.ReadLine();
        }
    }
}
