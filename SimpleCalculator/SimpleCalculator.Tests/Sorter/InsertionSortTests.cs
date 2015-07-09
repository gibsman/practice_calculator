using NUnit.Framework;

namespace SimpleCalculator.Tests
{
    class InsertionSortTests : AbstractSortTests
    {
        [SetUp]

        public void Initialize()
        {
            Sorter = new Insertion();
        }
    }
}
