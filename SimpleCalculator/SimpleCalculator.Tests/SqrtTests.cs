using NUnit.Framework;

namespace SimpleCalculator.Tests
{
    [TestFixture]
    class SqrtTests
    {
        [Test]
        public void Calculate()
        {
            var calculator = new SimpleCalculator.Add();
            var testResult = calculator.Calculate(5,5);
            var result = 10;
            Assert.AreEqual(testResult,result);
        }
    }
}
