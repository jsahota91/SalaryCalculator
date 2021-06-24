using System;

namespace Calculator
{
    public class SalaryCalculator
    {
        const int hoursInYear = 2080;

        public decimal GetAnnualSalary(decimal hourlyWage) => hourlyWage * hoursInYear;

        public decimal GetHourlyWage(int annualSalary) => annualSalary / hoursInYear;
        
    }
}
