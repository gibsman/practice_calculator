using NUnit.Framework;

namespace SimpleCalculator.Tests
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
