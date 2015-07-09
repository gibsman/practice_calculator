using System;
using NUnit.Framework;
using SimpleCalculator.OneArgument;

namespace SimpleCalculator.Tests
{ 
    /// <summary>
    /// Tests factory with one argument
    /// </summary>
    [TestFixture]
    public class OneArgumentsFactoryTests
    {
        /// <summary>
        /// Method that tests factory with one argument
        /// </summary>
        /// <param name="type"></param>
        /// <param name="name"></param>
        [TestCase(typeof(Sin), "Sin")]
        [TestCase(typeof(Cos), "Cos")]
        [TestCase(typeof(Tan), "Tan")]
        [TestCase(typeof(Module), "Module")]
        [TestCase(typeof(Sqrt), "Sqrt")]
        [TestCase(typeof(Squared), "Squared")]
        [TestCase(typeof(Lg), "Lg")]
        [TestCase(typeof(Ln), "Ln")]
        [TestCase(typeof(InverseValue), "InverseValue")]
        [TestCase(typeof(Expanenta), "Expanenta")]
        [TestCase(typeof(Asin), "Asin")]
        [TestCase(typeof(Acos), "Acos")]

        public void FactoryTest(Type type, string name)
        {
            Type resultType = FactoryWithOneArgument.GetCalculator(name).GetType();
            Assert.AreEqual(type, resultType);
        }
    }
}