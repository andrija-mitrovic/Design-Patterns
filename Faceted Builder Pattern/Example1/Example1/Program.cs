using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example1
{
    class Program
    {
        static void Main(string[] args)
        {
            var car = new CarBuilderFacade()
            .Info
              .WithType("BMW")
              .WithColor("Black")
              .WithNumberOfDoors(5)
            .Built
              .InCity("Leipzig ")
              .AtAddress("Some address 254")
            .Build();

            Console.WriteLine(car);

            Console.ReadLine();
        }
    }
}
