using NUnit.Framework;
using SimpleCalculator.OneArgument;

namespace SimpleCalculator.Tests.OneArgument
{
    [TestFixture]
    class TanTests
    {
        [TestCase(0, 0)]
        [TestCase(1, 1.5)]
        [TestCase(-1, 1.5)]
        [TestCase(2, -2.1)]
        [TestCase(-2, 2.5)]

        public void Calculate(double input, double output)
        {
            var calculator = new Tan();
            var testResult = calculator.Calculate(input);
            var result = output;
            Assert.AreEqual(testResult, result,0.1);
        }
    }
}
