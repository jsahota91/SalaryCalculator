using System;

namespace Calculator
{
    public class SalaryCalculator
    {
        const int hoursInYear = 2080;

        public decimal GetAnnualSalary(decimal hourlyWage)
        {
            decimal annualSalary = hourlyWage * hoursInYear;
            return annualSalary;
        }
    }
}
