using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodingProblems.TripleStep
{
    /// <summary>
    /// Tests TripleStep4CountMemoizationRecursiveComplete.CountWays
    /// </summary>
    [TestClass]
    public class TripleStep4CountMemoizationRecursiveCompleteTests
    {
        /// <summary>
        /// General tests.
        /// </summary>
        [TestMethod]
        public void TripleStep4CountMemoizationRecursiveCompleteTests1()
        {
            Assert.AreEqual(1, TripleStep4CountMemoizationRecursiveComplete.CountWays(1));
            Assert.AreEqual(2, TripleStep4CountMemoizationRecursiveComplete.CountWays(2));
            Assert.AreEqual(4, TripleStep4CountMemoizationRecursiveComplete.CountWays(3));
            Assert.AreEqual(7, TripleStep4CountMemoizationRecursiveComplete.CountWays(4));
            Assert.AreEqual(13, TripleStep4CountMemoizationRecursiveComplete.CountWays(5));
            Assert.AreEqual(24, TripleStep4CountMemoizationRecursiveComplete.CountWays(6));
            Assert.AreEqual(274, TripleStep4CountMemoizationRecursiveComplete.CountWays(10));
            Assert.AreEqual(121415, TripleStep4CountMemoizationRecursiveComplete.CountWays(20));
        }

        /// <summary>
        /// steps = 0 test.
        /// </summary>
        [TestMethod]
        public void TripleStep4CountMemoizationRecursiveCompleteTestsInvalidZero()
        {
            try
            {
                TripleStep4CountMemoizationRecursiveComplete.CountWays(0);
            }
            catch (ArgumentException)
            {
                Assert.IsTrue(true);
                return;
            }
            Assert.Fail();
        }

        /// <summary>
        /// steps negative test.
        /// </summary>
        [TestMethod]
        public void TripleStep4CountMemoizationRecursiveCompleteTestsInvalidNegative()
        {
            try
            {
                TripleStep4CountMemoizationRecursiveComplete.CountWays(-1);
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
