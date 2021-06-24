using Calculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SalaryCalculatorTestProject
{
    /* 
       To get hourly, divide annual salary by 2000
       $100,006.40 / 2080 = $48.08 hr
        
       To get annual, multiply hourly by 2080
       $48.08 * 2080 = $100,006.40
     
    */
    [TestClass]
    public class CalculatorTests
    {
        [TestMethod]
        public void GivenTheGetAnnualSalaryMethod_WhenIEnterTheHourlyWage_ThenIGetTheAnnualSalary()
        {
            //ARRANGE
            SalaryCalculator sc = new SalaryCalculator();

            //ACT
            decimal annualSalary = sc.GetAnnualSalary(50);

            //ASSERT
            //50 x 2080 =104,000
            Assert.AreEqual(104000, annualSalary);
        }
    }
}
