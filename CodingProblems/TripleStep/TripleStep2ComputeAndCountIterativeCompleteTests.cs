using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodingProblems.TripleStep
{
    /// <summary>
    /// Tests TripleStep1SimpleIterativeComplete.CountWays
    /// </summary>
    [TestClass]
    public class TripleStep2ComputeAndCountIterativeCompleteTests
    {
        /// <summary>
        /// General tests.
        /// </summary>
        [TestMethod]
        public void TripleStep2ComputeAndCountIterativeCompleteTests1()
        {
            Assert.AreEqual(1, TripleStep2ComputeAndCountIterativeComplete.CountWays(1));
            Assert.AreEqual(2, TripleStep1ComputeAndCountRecursiveComplete.CountWays(2));
            Assert.AreEqual(4, TripleStep1ComputeAndCountRecursiveComplete.CountWays(3));
            Assert.AreEqual(7, TripleStep1ComputeAndCountRecursiveComplete.CountWays(4));
            Assert.AreEqual(13, TripleStep1ComputeAndCountRecursiveComplete.CountWays(5));
            Assert.AreEqual(24, TripleStep1ComputeAndCountRecursiveComplete.CountWays(6));
            Assert.AreEqual(274, TripleStep1ComputeAndCountRecursiveComplete.CountWays(10));
            Assert.AreEqual(121415, TripleStep1ComputeAndCountRecursiveComplete.CountWays(20));
        }

        /// <summary>
        /// steps = 0 test.
        /// </summary>
        [TestMethod]
        public void TripleStep2ComputeAndCountIterativeCompleteTestsInvalidZero()
        {
            try
            {
                TripleStep2ComputeAndCountIterativeComplete.CountWays(0);
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
        public void TripleStep2ComputeAndCountIterativeCompleteTestsInvalidNegative()
        {
            try
            {
                TripleStep2ComputeAndCountIterativeComplete.CountWays(-1);
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
