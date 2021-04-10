using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestResult()
        {
            var array = new int[] {5, 2, 1, 4, 3};
            var result = Bubble_Sort.BubbleSort(array);
            var expected = new int[] {1, 2, 3, 4, 5};
            Assert.AreEqual(result[0], expected[0]);
            Assert.AreEqual(result[1], expected[1]);
            Assert.AreEqual(result[2], expected[2]);
            Assert.AreEqual(result[3], expected[3]);
            Assert.AreEqual(result[4], expected[4]);
        }
    }
}
