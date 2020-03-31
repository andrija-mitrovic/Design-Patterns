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
            ImageView view = new ImageView(new Image());
            view.Apply(new VintageAdapter(new VintageFilter()));

            Console.ReadLine();
        }
    }
}
