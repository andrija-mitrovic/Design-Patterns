using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example2
{
    public class HighTax
    {
        private readonly ITaxCalculator _tax;
        public HighTax(ITaxCalculator tax)
        {
            _tax = tax;
        }
        public decimal CalculateTax(decimal salary)
        {
            decimal tax = 0;

            if (salary > 2000)
            {
                salary = salary - 2000;
                tax += salary * 0.3m;
            }

            tax += _tax.CalculateTax(2000);

            return tax;
        }
    }
}
