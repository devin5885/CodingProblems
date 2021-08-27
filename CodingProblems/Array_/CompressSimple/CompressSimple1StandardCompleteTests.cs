using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodingProblems.Array_.CompressSimple
{
    /// <summary>
    /// Tests CompressSimple
    /// </summary>
    [TestClass]
    public class CompressSimple1StandardCompleteTests
    {
        /// <summary>
        /// Tests list with single element.
        /// </summary>
        [TestMethod]
        public void CompressSimple1StandardCompleteTest1Single()
        {
            var input = new List<int> { 10 };
            var expected = new List<int> { 1, 10 };
            var actual = CompressSimple1StandardComplete.CompressSimple(input);
            CollectionAssert.AreEqual(actual, expected);
        }

        /// <summary>
        /// Tests list with single element at end.
        /// </summary>
        [TestMethod]
        public void CompressSimple1StandardCompleteTest2SingleAtEnd()
        {
            var input = new List<int> { 10, 10, 15, 20 };
            var expected = new List<int> { 2, 10, 1, 15, 1, 20 };
            var actual = CompressSimple1StandardComplete.CompressSimple(input);
            CollectionAssert.AreEqual(actual, expected);
        }

        /// <summary>
        /// Tests list with multiple elements.
        /// </summary>
        [TestMethod]
        public void CompressSimple1StandardCompleteTest3Multiple()
        {
            var input = new List<int> { 10, 10, 10, 10, 20, 20, 30, 15, 15, 15 };
            var expected = new List<int> { 4, 10, 2, 20, 1, 30, 3, 15 };
            var actual = CompressSimple1StandardComplete.CompressSimple(input);
            CollectionAssert.AreEqual(actual, expected);
        }

        /// <summary>
        /// Tests empty list.
        /// </summary>
        [TestMethod]
        public void CompressSimple1StandardCompleteTest4Empty()
        {
            var input = new List<int>();
            var expected = new List<int>();
            var actual = CompressSimple1StandardComplete.CompressSimple(input);
            CollectionAssert.AreEqual(actual, expected);
        }

        /// <summary>
        /// Tests a null list.
        /// </summary>
        [TestMethod]
        public void CompressSimple1StandardCompleteTest5ErrorNull()
        {
            try
            {
                CompressSimple1StandardComplete.CompressSimple(null);
            }
            catch (ArgumentException)
            {
                Assert.IsTrue(true);
                return;
            }
            Assert.Fail();
        }
    }
}
