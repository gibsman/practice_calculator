using System;
using NUnit.Framework;
using SimpleCalculator.OneArgument;

namespace SimpleCalculator.Tests
{
    [TestFixture]
    public class OneArgumentsFactoryTests
    {
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