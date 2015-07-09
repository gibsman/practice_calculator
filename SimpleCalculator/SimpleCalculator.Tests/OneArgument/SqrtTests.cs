using System;
using NUnit.Framework;
using SimpleCalculator.OneArgument;

namespace SimpleCalculator.Tests.OneArgument
{
    [TestFixture]
    class SqrtTests
    {
        [TestCase(100,10)]
        [TestCase(144, 10)]
        [TestCase(100,-10)]

        public void Calculate(int input,int output)
        {
            var calculator = new Sqrt();
            var testResult = calculator.Calculate(input);
            var result = output;
            Assert.AreEqual(testResult,result);
        }

        [Test]
        [ExpectedException(typeof(Exception))]
        public void NegativeSqrtTests()
        {
            var calculator = new Sqrt();
            var result = calculator.Calculate(-4);
        }
    }
}   
