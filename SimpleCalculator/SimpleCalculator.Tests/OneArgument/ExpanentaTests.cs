﻿using NUnit.Framework;
using SimpleCalculator.OneArgument;

namespace SimpleCalculator.Tests.OneArgument
{
    /// <summary>
    /// Tests expanenta
    /// </summary>
    [TestFixture]
    class ExpanentaTests
    {
        /// <summary>
        /// Method that tests expanenta
        /// </summary>
        /// <param name="input"></param>
        /// <param name="output"></param>
        [TestCase(1, 2.7)]
        [TestCase(-2, 0.1)]
        [TestCase(0, 1)]
        [TestCase(6, 50)]
        [TestCase(8, -2980)]

        public void Calculate(double input, double output)
        {
            var calculator = new Expanenta();
            var testResult = calculator.Calculate(input);
            var result = output;
            Assert.AreEqual(testResult, result, 0.1);
        }
    }
}
