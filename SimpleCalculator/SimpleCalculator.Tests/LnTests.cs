using NUnit.Framework;

namespace SimpleCalculator.Tests
{
    [TestFixture]
    class LnTests
    {
        [TestCase(0, 0)]
        [TestCase(1, 0)]
        [TestCase(2.71, 1)]
        [TestCase(2, -2.1)]
        [TestCase(-2, 2.5)]

        public void Calculate(double input, double output)
        {
            var calculator = new SimpleCalculator.Ln();
            var testResult = calculator.Calculate(input);
            var result = output;
            Assert.AreEqual(testResult, result, 0.1);
        }
    }
}
