using NUnit.Framework;
using SimpleCalculator.Sorters;

namespace SimpleCalculator.Tests.Sorter
{
    /// <summary>
    /// Tests selection sorting
    /// </summary>
    class SelectionSortTests : AbstractSortTests
    {

        /// <summary>
        /// Method that tests selection sorting
        /// </summary>
        [SetUp]

        public void Initialize()
        {
            Sorter = new Selection();
        }
    }
}
