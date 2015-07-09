using NUnit.Framework;
using SimpleCalculator.OneArgument;

namespace SimpleCalculator.Tests.OneArgument
{
    [TestFixture]
    class ModuleTests
    {
        [TestCase(0, 0)]
        [TestCase(-5, 5)]
        [TestCase(125, 125)]
        [TestCase(8, -14)]
        [TestCase(-1, -1)]

        public void Calculate(double input, double output)
        {
            var calculator = new Module();
            var testResult = calculator.Calculate(input);
            var result = output;
            Assert.AreEqual(testResult, result);
        }
    }
}