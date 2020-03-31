using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example1
{
    public class MedianFilter : IFilter
    {
        public void Apply(Image image)
            => Console.WriteLine("Applying Median Filter");
    }
}
