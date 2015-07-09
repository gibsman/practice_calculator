using System;
using NUnit.Framework;
using SimpleCalculator.TwoArguments;

namespace SimpleCalculator.Tests
{
    /// <summary>
    /// Tests factory with two argument
    /// </summary>
    [TestFixture]
    public class TwoArgumentsFactoryTests
    {
        /// <summary>
        /// Method that tests factory with two argument
        /// </summary>
        /// <param name="type"></param>
        /// <param name="name"></param>
        [TestCase(typeof(Add), "Addition")]
        [TestCase(typeof(Divide), "Division")]
        [TestCase(typeof(Substract), "Substraction")]
        [TestCase(typeof(Multiply), "Multiplication")]
        [TestCase(typeof(Power), "Power")]

        public void FactoryTest(Type type, string name)
        {
            Type resultType = FactoryWithTwoArguments.GetCalculator(name).GetType();
            Assert.AreEqual(type, resultType);
        }

    }
}
