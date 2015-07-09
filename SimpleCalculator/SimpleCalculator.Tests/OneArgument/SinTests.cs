
using NUnit.Framework;

namespace SimpleCalculator.Tests
{
    [TestFixture]
    class SinTests
    {
        [TestCase(0, 0)]
        [TestCase(1.56, 0.9)]
        [TestCase(3.14, 0)]
        [TestCase(4.7, -0.9)]
        [TestCase(6.28, 1)]

        public void Calculate(double input, double output)
        {
            var calculator = new SimpleCalculator.Sin();
            var testResult = calculator.Calculate(input);
            var result = output;
            Assert.AreEqual(testResult, result,0.1);
        }
    }
}
