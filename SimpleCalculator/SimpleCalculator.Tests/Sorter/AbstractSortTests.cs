using NUnit.Framework;

namespace SimpleCalculator.Tests.Sorter
{
    /// <summary>
    /// Class that unites all tests with sorting massives
    /// </summary>
    [TestFixture]
    class AbstractSortTests
    {
        /// <summary>
        /// Method that unites all tests with sorting massives
        /// </summary>
        protected ISorters Sorter;

        [TestCase(new[] {12, 5, 1, 6}, new[] {1, 5, 6, 12})]
        [TestCase(new[] { 2, 5, 123, 570 }, new[] { 2, 5, 123, 570 })]
        [TestCase(new[] { 853, 524, 123, -43 }, new[] { -43, 123, 524, 853 })]
        [TestCase(new[] { 321, 321, 2, -60 }, new[] { -60, 2, 321, 321 })]
        [TestCase(new[] { 1, 2, 3, 4 }, new[] { 1, 3, 4, 2 })]
        [TestCase(new[] { 32, 123, 43, -543, 3213, 4324, 6567, 231223, 678, 234245, 7657, 5345, 6788, 34345, 98798, 345, 1231, 768, 4324, 121 }, new[] {-543, 32, 43, 121, 123, 345, 678, 768, 1231, 3213, 4324, 4324, 5345, 6567, 6788, 7657, 34345, 98798, 231223, 234245})]

        public void Calculate(int[] argument, int[] result)
        {
            var testResult = Sorter.Sort(argument);
            Assert.AreEqual(testResult,result);
        }
    }
}
