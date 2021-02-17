using NUnit.Framework;
using TwoSums;

namespace Tests
{
    public class Tests
    {
        Pairs pairs;

        [SetUp]
        public void Setup()
        {
            pairs = new Pairs();
        }
        //Test case provided by Evans
        [Test]
        public void Test1()
        {
            int[] arr = { 1, 2, 3, 4, 5 };
            int target = 6;
            string expected = "0, 4";
            Assert.AreEqual(expected: expected, pairs.GetTwoSums(arr, target));
        }
        //Check when there are no pairs matching the target
        [Test]
        public void Test2()
        {
            int[] arr = { 2, 3, 4, 5 };
            int target = 4;
            string expected = "0, 0";
            Assert.AreEqual(expected: expected, pairs.GetTwoSums(arr, target));
        }
        //Check the match with another left position index <> 0
        [Test]
        public void Test3()
        {
            int[] arr = { 2, 3, 4, 6 };
            int target = 7;
            string expected = "1, 2";
            Assert.AreEqual(expected: expected, pairs.GetTwoSums(arr, target));
        }
        //Check if the same index can be summed
        [Test]
        public void Test4()
        {
            int[] arr = { 2, 3, 5, 4, 5 };
            int target = 10;
            string expected = "2, 4";
            Assert.AreEqual(expected: expected, pairs.GetTwoSums(arr, target));
        }
    }
}