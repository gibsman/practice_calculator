using NUnit.Framework;
using SimpleCalculator.TwoArguments;

namespace SimpleCalculator.Tests.TwoArguments
{
    [TestFixture]
    class AddTests
    {
        [TestCase(10, 10, 20)]
        [TestCase(-10, 10, 0)]
        [TestCase(-5, -45, -50)]
        [TestCase(25, -10, 15)]
        [TestCase(0, 10, 20)]

        public void Calculate(double firstInput,double secondInput, double output)
        {
            var calculator = new Add();
            var testResult = calculator.Calculate(firstInput,secondInput);
            var result = output;
            Assert.AreEqual(testResult, result);
        }
    }
}
