using NUnit.Framework;
using SimpleCalculator.Sorters;

namespace SimpleCalculator.Tests.Sorter
{
    class BucketSortTests : AbstractSortTests
    {
        [SetUp]

        public void Initialize()
        {
            Sorter = new Bucket();
        }
    }
}
