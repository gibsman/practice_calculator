using NUnit.Framework;

namespace SimpleCalculator.Tests
{
    class SelectionSortTests : AbstractSortTests
    {
        [SetUp]

        public void Initialize()
        {
            Sorter = new Selection();
        }
    }
}
