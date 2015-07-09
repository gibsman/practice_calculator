using NUnit.Framework;

namespace SimpleCalculator.Tests
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
