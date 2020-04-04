using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example2
{
    public class ShapeFactory
    {
        public IShape GetShape(ShapeType type)
        {
            if (type == ShapeType.Circle)
                return new Circle();
            else if (type == ShapeType.Rectangle)
                return new Rectangle();
            else if (type == ShapeType.Square)
                return new Square();
            else
                return null;
        }
    }
}
