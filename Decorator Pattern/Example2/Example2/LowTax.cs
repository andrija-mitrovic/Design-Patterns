using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example2
{
    public class LowTax : ITaxCalculator
    {
        public decimal CalculateTax(decimal salary)
        {
            return salary * 0.1m;
        }

    }
}
