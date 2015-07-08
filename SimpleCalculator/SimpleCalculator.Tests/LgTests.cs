using NUnit.Framework;

namespace SimpleCalculator.Tests
{
    [TestFixture]
    class LgTests
    {
        [TestCase(100, 2)]
        [TestCase(-1000, 25)]
        [TestCase(1, 0)]

        public void Calculate(double input, double output)
        {
            var calculator = new SimpleCalculator.Lg();
            var testResult = calculator.Calculate(input);
            var result = output;
            Assert.AreEqual(testResult, result);
        }
    }
}
