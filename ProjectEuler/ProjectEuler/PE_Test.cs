using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjectEulerResults;

namespace ProjectEuler
{
    [TestClass]
    public class PE_Test
    {
        [TestMethod]
        public void RemovedSumFromInitialAmount()
        {
            int value = 10;
            int divisor = 3;
            int result = 18;

            PE_Task1 T1 = new PE_Task1(value, divisor);
            T1.GenerateSumOfMultiples();

            // assert
            double actual = T1.SumOfMultiples;
            Assert.AreEqual(result, actual, "Incorrect number of multiples!");
        }
    }
}
