using NUnit.Framework;
using SimpleCalculator.Sorters;

namespace SimpleCalculator.Tests.Sorter
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
