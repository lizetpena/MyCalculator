using System;
using MyCalculator;
// Unit Testing FrameWork
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Calculator.Test
{
    [TestClass]
    public class CalculatorTests
    {

        [TestMethod] // flags method indicates TEST
        [TestCategory("Simple Math")] // 'Trait' UT organinzation
        [Priority(0)] // Another 'Attribute' for catagorizing
        public void AddSimple()
        {
            //ARRANGE: (set up environment to run test)
            var calculator = new MyCalculator.Calculator();
            //ACT: (run code we are trying to test)
            int sum = calculator.Add(1, 2);
            //ASSERT: (validate expected results)
            Assert.AreEqual(3, sum);
        }


        [TestMethod]
        [TestCategory("Simple Math")]
        [Priority(0)]
        public void SubtractSimple()
        {
            var calculator = new MyCalculator.Calculator();
            int sum = calculator.Subtract(5, 15);
            Assert.AreEqual(-10, sum);
        }


        [TestMethod]
        [TestCategory("Divide")]
        [Priority(1)]
      //[Ignore] // Allows us to skip UT 
        public void DivideSimple()
        {
            var calculator = new MyCalculator.Calculator();
            double quotient = calculator.Divide(10, 2);
            Assert.AreEqual(5, quotient);
        }


        [TestMethod]
        [TestCategory("Divide")]
        [ExpectedException(typeof(DivideByZeroException))]
        [Priority(1)]
        public void DivideByZero()
        {
            var calculator = new MyCalculator.Calculator();
            calculator.Divide(10, 0);
        }

    }
}
