using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example1
{
    public class Shape : IComponent
    {
        public void Move()
            => Console.WriteLine("Render Shape");

        public void Render()
            => Console.WriteLine("Move Shape");
    }
}
