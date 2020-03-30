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
            DirectionService service = new DirectionService(new Bicycling());
            service.GetEta();
            service.GetDirection();

            Console.ReadLine();
        }
    }
}
