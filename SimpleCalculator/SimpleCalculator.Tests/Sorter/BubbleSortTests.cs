using NUnit.Framework;
using SimpleCalculator.Sorters;

namespace SimpleCalculator.Tests.Sorter
{ 
    /// <summary>
    /// Tests bubble sorting
    /// </summary>
    class BubbleSortTests : AbstractSortTests
    {
        /// <summary>
        /// Method that tests bubble sorting
        /// </summary>
        [SetUp]

        public void Initialize()
        {
            Sorter=new Bubble();
        }
    }
}
