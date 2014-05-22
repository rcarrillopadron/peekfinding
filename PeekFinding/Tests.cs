using NUnit.Framework;

namespace PeekFinding
{
    [TestFixture]
    internal class Tests
    {
        [Test]
        public void Test_GetPeekIn2DWith5By5()
        {
            var array = DemoArray.Create5By5();
            int peek = PeekFinder.GetPeekIn2D(array);
            Assert.That(peek, Is.EqualTo(8));
        }

        [Test]
        public void Test_Find_row_with_max_value()
        {
            var array = DemoArray.Create5By5();
            Assert.That(PeekFinder.FindRowWithMaxValueByColumn(array, column: 1), Is.EqualTo(4));
            Assert.That(PeekFinder.FindRowWithMaxValueByColumn(array, column: 2), Is.EqualTo(4));
        }

        [Test]
        public void Test_GetPeekIn2DWith7By7()
        {
            var array = DemoArray.Create7By7();
            int peek = PeekFinder.GetPeekIn2D(array);
            Assert.That(peek, Is.EqualTo(9));
        }
    }
}