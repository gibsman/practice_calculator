using NUnit.Framework;

namespace SimpleCalculator.Tests
{
    [TestFixture]
    class ExpanentaTests
    {
        [TestCase(1, 2.7)]
        [TestCase(-2, 0.1)]
        [TestCase(0, 1)]
        [TestCase(6, 50)]
        [TestCase(8, -2980)]

        public void Calculate(double input, double output)
        {
            var calculator = new SimpleCalculator.Expanenta();
            var testResult = calculator.Calculate(input);
            var result = output;
            Assert.AreEqual(testResult, result, 0.1);
        }
    }
}
