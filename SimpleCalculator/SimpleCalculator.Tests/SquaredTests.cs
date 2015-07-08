using NUnit.Framework;

namespace SimpleCalculator.Tests
{
    [TestFixture]
    class SquaredTests
    {
        [TestCase(10, 100)]
        [TestCase(-2, 4)]
        [TestCase(0, 0)]
        [TestCase(6, -36)]
        [TestCase(8, 64)]

        public void Calculate(double input, double output)
        {
            var calculator = new SimpleCalculator.Squared();
            var testResult = calculator.Calculate(input);
            var result = output;
            Assert.AreEqual(testResult, result);
        }
    }
}
