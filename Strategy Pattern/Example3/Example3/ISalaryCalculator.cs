﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example3
{
    public interface ISalaryCalculator
    {
        double CalculateTotalSalary(IEnumerable<Employee> employees);
    }
}
