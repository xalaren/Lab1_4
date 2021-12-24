using NUnit.Framework;

namespace Lab1_4.Tests
{
    public class ArrayTask_Test
    {
        [Test]
        public void NormalTest()
        {
            int[] arrange = new int[] { 1, 2, 3, 4, 5, 5, 5 };
            (int, int) expected = (5, 3);
            (int, int) actual = ArrayTasks.FindMax(arrange);
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void NegativeTest()
        {
            int[] arrange = new int[] { -1, -2, -3, -3 };
            (int, int) expected = (-1, 1);
            (int, int) actual = ArrayTasks.FindMax(arrange);
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void NegativeAndPositiveTest()
        {
            int[] arrange = new int[] { -1, -2, -3, -3, 1, 2, 2, 4, 4, 4, -1 };
            (int, int) expected = (4, 3);
            (int, int) actual = ArrayTasks.FindMax(arrange);
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void AllCombinedTest()
        {
            int[] arrange = new int[] { -1, -2, -3, -3, 0, 0, 0, 1 };
            (int, int) expected = (1, 1);
            (int, int) actual = ArrayTasks.FindMax(arrange);
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void ZeroIsMaxTest()
        {
            int[] arrange = new int[] { -2, -1, 0, 0, 0 };
            (int, int) expected = (0, 3);
            (int, int) actual = ArrayTasks.FindMax(arrange);
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void OneItemNormalTest()
        {
            int[] arrange = new int[] { 2 };
            (int, int) expected = (2, 1);
            (int, int) actual = ArrayTasks.FindMax(arrange);
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void ZeroTest()
        {
            int[] arrange = new int[] { 0 };
            (int, int) expected = (0, 1);
            (int, int) actual = ArrayTasks.FindMax(arrange);
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void EmptyTest()
        {
            int[] arrange = new int[] { };
            (int, int) expected = (0, 0);
            (int, int) actual = ArrayTasks.FindMax(arrange);
            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}