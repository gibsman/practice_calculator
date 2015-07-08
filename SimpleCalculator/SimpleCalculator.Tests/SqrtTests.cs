using NUnit.Framework;

namespace SimpleCalculator.Tests
{
    [TestFixture]
    class SqrtTests
    {
        [TestCase(100,10)]
        [TestCase(-5,20)]
        [TestCase(144, 10)]
        [TestCase(100,-10)]

        public void Calculate(int input,int output)
        {
            var calculator = new SimpleCalculator.Sqrt();
            var testResult = calculator.Calculate(input);
            var result = output;
            Assert.AreEqual(testResult,result);
        }
    }
}   
