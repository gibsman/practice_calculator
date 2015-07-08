using System;
using NUnit.Framework;

namespace SimpleCalculator.Tests
{
    [TestFixture]
    class DivisionTests
    {
        [TestCase(100,10, 10)]
        [TestCase(-5,10, 0.5)]
        [TestCase(256,16, 15)]
        [TestCase(-15,-5,3)]
        [TestCase(1, 2, 0.5)]

        public void Calculate(double firstInput, double secondInput, double output)
        {
            var calculator = new SimpleCalculator.Divide();
            var testResult = calculator.Calculate(firstInput, secondInput);
            var result = output;
            Assert.AreEqual(testResult, result);
        }
         [Test]
        [ExpectedException(typeof(Exception))]
        public void DivisionByZeroTests()
        {
            var calculator = new Divide();
            var result = calculator.Calculate(4, 0);
        }
    }
}
