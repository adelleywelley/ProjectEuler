using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjectEulerResults;

namespace ProjectEuler
{
    [TestClass]
    public class PE_Test
    {
        [TestMethod]
        public void Task1()
        {
            int value = 1000;
            int result = 233168;

            PE_Task1 T1 = new PE_Task1(value, 3, 5);
            T1.GenerateSumOfMultiples();

            // assert
            double actual = T1.SumOfMultiples;
            Assert.AreEqual(result, actual, "Incorrect sum of multiples!");
        }
    }
}
