using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example2
{
    public class BaseTax : ITaxCalculator
    {
        private readonly ITaxCalculator _tax;
        public BaseTax(ITaxCalculator tax)
        {
            _tax = tax;
        }
        public decimal CalculateTax(decimal salary)
        {
            decimal tax = 0;
            if (salary > 1000 && salary <= 2000)
            {
                salary = salary - 1000;
                tax += salary * 0.2m;
            }

            tax += _tax.CalculateTax(1000);

            return tax;
        }
    }
}
