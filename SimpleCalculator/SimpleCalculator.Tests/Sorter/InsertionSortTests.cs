using NUnit.Framework;
using SimpleCalculator.Sorters;

namespace SimpleCalculator.Tests.Sorter
{
    /// <summary>
    /// Tests insertion sorting
    /// </summary>
    class InsertionSortTests : AbstractSortTests
    {  
        /// <summary>
        /// Method that tests insertion sorting
        /// </summary>
        [SetUp]

        public void Initialize()
        {
            Sorter = new Insertion();
        }
    }
}