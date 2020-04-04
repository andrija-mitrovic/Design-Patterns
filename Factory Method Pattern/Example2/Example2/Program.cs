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
            ShapeFactory shapeFactory = new ShapeFactory();
            IShape shape = shapeFactory.GetShape(ShapeType.Rectangle);
            shape.Draw();

            Console.ReadLine();
        }
    }
}
