using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example2
{
    public class HumanResource: IResource
    {
        public void Deploy()
            => Console.WriteLine("Deploying a human resource");
    }
}
