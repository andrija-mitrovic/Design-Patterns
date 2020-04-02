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
            Group group1 = new Group();
            group1.Add(new Shape());
            group1.Add(new Shape());

            Group group2 = new Group();
            group2.Add(new Shape());
            group2.Add(new Shape());

            Group group = new Group();
            group.Add(group1);
            group.Add(group2);
            group.Render();
            group.Move();

            Console.ReadLine();
        }
    }
}
