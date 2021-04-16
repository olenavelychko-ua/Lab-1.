using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        Bubble_Sort obj = new Bubble_Sort();
        [TestMethod]
        public void TestEmpty()
        {
            var array = new int[] { };
            var result = obj.Sort(array);
            var expected = new int[] {};
            Assert.AreEqual(result.Length==0, expected.Length==0); ;
        }
        [TestMethod]
        public void TestOneElement()
        {
            var array = new int[] {5};
            var result = obj.Sort(array);
            var expected = new int[] {5};
            Assert.AreEqual(result[0], expected[0]);
        }
        [TestMethod]
        public void TestSortedArray()
        {
            var array = new int[] { 1, 2, 3, 4, 5 };
            var result = obj.Sort(array);
            var expected = new int[] { 1, 2, 3, 4, 5 };
            Assert.AreEqual(result[0], expected[0]);
            Assert.AreEqual(result[1], expected[1]);
            Assert.AreEqual(result[2], expected[2]);
            Assert.AreEqual(result[3], expected[3]);
            Assert.AreEqual(result[4], expected[4]);
        }
        [TestMethod]
        public void TestResult()
        {
            var array = new int[] {5, 2, 1, 4, 3};
            var result = obj.Sort(array);
            var expected = new int[] {1, 2, 3, 4, 5};
            Assert.AreEqual(result[0], expected[0]);
            Assert.AreEqual(result[1], expected[1]);
            Assert.AreEqual(result[2], expected[2]);
            Assert.AreEqual(result[3], expected[3]);
            Assert.AreEqual(result[4], expected[4]);
        }
    }
}
