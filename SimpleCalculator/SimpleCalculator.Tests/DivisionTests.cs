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
        [TestCase(25,0,10)]

        public void Calculate(double firstInput, double secondInput, double output)
        {
            var calculator = new SimpleCalculator.Divide();
            var testResult = calculator.Calculate(firstInput, secondInput);
            var result = output;
            Assert.AreEqual(testResult, result);
        }
    }
}
