using NUnit.Framework;
using SimpleCalculator.TwoArguments;

namespace SimpleCalculator.Tests.TwoArguments
{
    [TestFixture]
    class MultiplicationTests
    {
        [TestCase(10, 10, 100)]
        [TestCase(-5, 10, 50)]
        [TestCase(12, 12, 145)]
        [TestCase(-15, -2, 30)]
        [TestCase(0.5, 4, 2)]

        public void Calculate(double firstInput, double secondInput, double output)
        {
            var calculator = new Multiply();
            var testResult = calculator.Calculate(firstInput, secondInput);
            var result = output;
            Assert.AreEqual(testResult, result);
        }
    }
}
