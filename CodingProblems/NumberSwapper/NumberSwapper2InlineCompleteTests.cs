using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodingProblems.NumberSwapper
{
    /// <summary>
    /// This class tests Swap
    /// </summary>
    [TestClass]
    public class NumberSwapper2InlineCompleteTests
    {
        /// <summary>
        /// Swaps x and y.
        /// </summary>
        [TestMethod]
        public void TestNumberSwap2InlineCompleteSimple()
        {
            var x = 1;
            var y = 2;
            NumberSwapper2InlineComplete.Swap(ref x, ref y);
            Assert.AreEqual(2, x);
            Assert.AreEqual(1, y);
        }

        /// <summary>
        /// Test swapping two negative numbers.
        /// </summary>
        [TestMethod]
        public void TestNumberSwap2InlineCompleteBothNegative()
        {
            var x = -1;
            var y = -2;
            NumberSwapper2InlineComplete.Swap(ref x, ref y);
            Assert.AreEqual(-2, x);
            Assert.AreEqual(-1, y);
        }

        /// <summary>
        /// Test swapping a negative and positive number.
        /// </summary>
        [TestMethod]
        public void TestNumberSwap2InlineCompletehNegativeAndPositive()
        {
            var x = -1;
            var y = 2;
            NumberSwapper2InlineComplete.Swap(ref x, ref y);
            Assert.AreEqual(2, x);
            Assert.AreEqual(-1, y);
        }

        /// <summary>
        /// Test swapping the same number.
        /// </summary>
        [TestMethod]
        public void TestNumberSwap2InlineCompletehSameNumber()
        {
            var x = 2;
            NumberSwapper2InlineComplete.Swap(ref x, ref x);
            Assert.AreEqual(2, x);
            Assert.AreEqual(2, x);
        }
    }
}