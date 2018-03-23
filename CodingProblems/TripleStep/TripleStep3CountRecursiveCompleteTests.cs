using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodingProblems.TripleStep
{
    /// <summary>
    /// Tests TripleStep3CountRecursiveComplete.CountWays
    /// </summary>
    [TestClass]
    public class TripleStep3CountRecursiveCompleteTests
    {
        /// <summary>
        /// General tests.
        /// </summary>
        [TestMethod]
        public void TripleStep3CountRecursiveCompleteTests1()
        {
            Assert.AreEqual(1, TripleStep3CountRecursiveComplete.CountWays(1));
            Assert.AreEqual(2, TripleStep3CountRecursiveComplete.CountWays(2));
            Assert.AreEqual(4, TripleStep3CountRecursiveComplete.CountWays(3));
            Assert.AreEqual(7, TripleStep3CountRecursiveComplete.CountWays(4));
            Assert.AreEqual(13, TripleStep3CountRecursiveComplete.CountWays(5));
            Assert.AreEqual(24, TripleStep3CountRecursiveComplete.CountWays(6));
            Assert.AreEqual(274, TripleStep3CountRecursiveComplete.CountWays(10));
            Assert.AreEqual(121415, TripleStep3CountRecursiveComplete.CountWays(20));
        }

        /// <summary>
        /// steps = 0 test.
        /// </summary>
        [TestMethod]
        public void TripleStep3CountRecursiveCompleteTestsInvalidZero()
        {
            try
            {
                TripleStep3CountRecursiveComplete.CountWays(0);
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
        public void TripleStep3CountRecursiveCompleteTestsInvalidNegative()
        {
            try
            {
                TripleStep3CountRecursiveComplete.CountWays(-1);
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
