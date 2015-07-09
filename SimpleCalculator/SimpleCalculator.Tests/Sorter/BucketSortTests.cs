using NUnit.Framework;
using SimpleCalculator.Sorters;

namespace SimpleCalculator.Tests.Sorter
{
    /// <summary>
    /// Tests bucket sorting
    /// </summary>
    class BucketSortTests : AbstractSortTests
    {
        /// <summary>
        /// Method that tests bucket sorting
        /// </summary>
        [SetUp]

        public void Initialize()
        {
            Sorter = new Bucket();
        }
    }
}
