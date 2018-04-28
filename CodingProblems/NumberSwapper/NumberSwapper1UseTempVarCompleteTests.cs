using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodingProblems.NumberSwapper
{
    /// <summary>
    /// This class tests Swap
    /// </summary>
    [TestClass]
    public class NumberSwapper1UseTempVarCompleteTests
    {
        /// <summary>
        /// Test swapping two positive numbers.
        /// </summary>
        [TestMethod]
        public void TestNumberSwap1UseTempVarCompleteBothPositive()
        {
            var x = 1;
            var y = 2;
            NumberSwapper1UseTempVarComplete.Swap(ref x, ref y);
            Assert.AreEqual(2, x);
            Assert.AreEqual(1, y);
        }

        /// <summary>
        /// Test swapping two negative numbers.
        /// </summary>
        [TestMethod]
        public void TestNumberSwap1UseTempVarCompleteBothNegative()
        {
            var x = -1;
            var y = -2;
            NumberSwapper1UseTempVarComplete.Swap(ref x, ref y);
            Assert.AreEqual(-2, x);
            Assert.AreEqual(-1, y);
        }

        /// <summary>
        /// Test swapping a negative and positive number.
        /// </summary>
        [TestMethod]
        public void TestNumberSwap1UseTempVarCompletehNegativeAndPositive()
        {
            var x = -1;
            var y = 2;
            NumberSwapper1UseTempVarComplete.Swap(ref x, ref y);
            Assert.AreEqual(2, x);
            Assert.AreEqual(-1, y);
        }

        /// <summary>
        /// Test swapping the same number.
        /// </summary>
        [TestMethod]
        public void TestNumberSwap1UseTempVarCompletehSameNumber()
        {
            var x = 2;
            NumberSwapper1UseTempVarComplete.Swap(ref x, ref x);
            Assert.AreEqual(2, x);
            Assert.AreEqual(2, x);
        }
    }
}