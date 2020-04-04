using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example2
{
    public class Circle : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Draw circle");
        }
    }
}
