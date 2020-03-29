using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example3
{
    class Program
    {
        static void Main(string[] args)
        {
            var employees = new List<Employee>()
            {
                new Employee() { Id=1,Name="Marko Markovic", Level=EmployeeLevel.Senior, HourlyRate=15, WorkingHours=20 },
                new Employee() { Id=2,Name="Petar Petrovic", Level=EmployeeLevel.Lead, HourlyRate=12, WorkingHours=10 },
                new Employee() { Id=3,Name="Janko Jankovic", Level=EmployeeLevel.Junior, HourlyRate=10, WorkingHours=25 },
                new Employee() { Id=3,Name="Ivan Perovic", Level=EmployeeLevel.Junior, HourlyRate=10, WorkingHours=35 }
            };

            SalaryCalculator calculator = new SalaryCalculator(new JuniorSalaryCalculator());
            double juniorTotal = calculator.Calculate(employees);
            Console.WriteLine($"Total amount for junior salaries is: {juniorTotal}");

            calculator.SetCalculator(new LeadSalaryCalculator());
            double leadTotal = calculator.Calculate(employees);
            Console.WriteLine($"Total amount for lead salaries is: {leadTotal}");

            calculator.SetCalculator(new SeniorSalaryCalculator());
            double seniorTotal = calculator.Calculate(employees);
            Console.WriteLine($"Total amount for senior salaries is: {seniorTotal}");

            Console.WriteLine($"Total cost for all salaries is: { juniorTotal+leadTotal+seniorTotal }");

            Console.ReadLine();
        }
    }
}
