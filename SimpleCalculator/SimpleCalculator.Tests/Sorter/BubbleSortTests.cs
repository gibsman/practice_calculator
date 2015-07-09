using NUnit.Framework;
using SimpleCalculator.Sorters;

namespace SimpleCalculator.Tests.Sorter
{
    class BubbleSortTests : AbstractSortTests
    {
        [SetUp]

        public void Initialize()
        {
            Sorter=new Bubble();
        }
    }
}
