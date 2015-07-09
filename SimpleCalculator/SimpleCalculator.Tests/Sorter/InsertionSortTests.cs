using NUnit.Framework;
using SimpleCalculator.Sorters;

namespace SimpleCalculator.Tests.Sorter
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