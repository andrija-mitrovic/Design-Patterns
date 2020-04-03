using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example1
{
    public class SonyTV : IDevice
    {
        public void TurnOn()
            => Console.WriteLine("Sony: Turn on");

        public void TurnOff()
            => Console.WriteLine("Sony: Turn off");

        public void SetChannel(int number)
            => Console.WriteLine("Sony: Set channel");
    }
}
