using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodingProblems.BitManipulation.NextNumber
{
    /// <summary>
    /// Tests BitManipulationNextNumber1BruteForceComplete.GetNext/GetPrev.
    /// </summary>
    [TestClass]
    public class BitManipulationNextNumber1BruteForceCompleteTests
    {
        /// <summary>
        /// Tests BitManipulationNextNumber1BruteForceComplete.GetNext simple test.
        /// </summary>
        [TestMethod]
        public void BitManipulationNextNumber1BruteForceCompleteTestGetNext1Simple1()
        {
            var original = 1;
            var expected = Convert.ToInt32("10", 2);
            var actual = BitManipulationNextNumber1BruteForceComplete.GetNext(original);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Tests BitManipulationNextNumber1BruteForceComplete.GetNext simple test2 (with random #).
        /// </summary>
        [TestMethod]
        public void BitManipulationNextNumber1BruteForceCompleteTestGetNext2Simple2()
        {
            var original = Convert.ToInt32("101010011101100", 2);
            var expected = Convert.ToInt32("101010011110001", 2);
            var actual = BitManipulationNextNumber1BruteForceComplete.GetNext(original);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Tests BitManipulationNextNumber1BruteForceComplete.GetNext with all bits set (except sign bit).
        /// </summary>
        [TestMethod]
        public void BitManipulationNextNumber1BruteForceCompleteTestGetNext3AllSet()
        {
            var original = Convert.ToInt32("01111111111111111111111111111111", 2);
            var actual = BitManipulationNextNumber1BruteForceComplete.GetNext(original);
            Assert.AreEqual(-1, actual);
        }

        /// <summary>
        /// Tests BitManipulationNextNumber1BruteForceComplete.GetNext with negative #.
        /// </summary>
        [TestMethod]
        public void BitManipulationNextNumber1BruteForceCompleteTestGetNext4NegativeNumber()
        {
            try
            {
                BitManipulationNextNumber1BruteForceComplete.GetNext(-1);
            }
            catch (ArgumentException)
            {
                Assert.IsTrue(true);
                return;
            }
            Assert.Fail();
        }

        /// <summary>
        /// Tests BitManipulationNextNumber1BruteForceComplete.GetNext with all bits clear.
        /// </summary>
        [TestMethod]
        public void BitManipulationNextNumber1BruteForceCompleteTestGetNext5AllClear()
        {
            var actual = BitManipulationNextNumber1BruteForceComplete.GetNext(0);
            Assert.AreEqual(-1, actual);
        }

        /// <summary>
        /// Tests BitManipulationNextNumber1BruteForceComplete.GetNext with no solution.
        /// </summary>
        [TestMethod]
        public void BitManipulationNextNumber1BruteForceCompleteTestGetNext6NoSolution()
        {
            var original = Convert.ToInt32("01111111111111110000000000000000", 2);
            var actual = BitManipulationNextNumber1BruteForceComplete.GetNext(original);
            Assert.AreEqual(-1, actual);
        }

        /// <summary>
        /// Tests BitManipulationNextNumber1BruteForceComplete.GetPrev simple test.
        /// </summary>
        [TestMethod]
        public void BitManipulationNextNumber1BruteForceCompleteTestGetPrev1Simple()
        {
            var original = Convert.ToInt32("10", 2);
            var expected = Convert.ToInt32("1", 2);
            var actual = BitManipulationNextNumber1BruteForceComplete.GetPrev(original);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Tests BitManipulationNextNumber1BruteForceComplete.GetPrev simple test2 (with random #).
        /// </summary>
        [TestMethod]
        public void BitManipulationNextNumber1BruteForceCompleteTestGetPrev2Simple2()
        {
            var original = Convert.ToInt32("101010011101100", 2);
            var expected = Convert.ToInt32("101010011101010", 2);
            var actual = BitManipulationNextNumber1BruteForceComplete.GetPrev(original);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Tests BitManipulationNextNumber1BruteForceComplete.GetNext with all bits set (except sign bit).
        /// </summary>
        [TestMethod]
        public void BitManipulationNextNumber1BruteForceCompleteTestGetPrev3AllSet()
        {
            var original = Convert.ToInt32("01111111111111111111111111111111", 2);
            var actual = BitManipulationNextNumber1BruteForceComplete.GetPrev(original);
            Assert.AreEqual(-1, actual);
        }

        /// <summary>
        /// Tests BitManipulationNextNumber2OptimizedComplete.GetPrev with negative #.
        /// </summary>
        [TestMethod]
        public void BitManipulationNextNumber1BruteForceCompleteTestGetPrev4NegativeNumber()
        {
            try
            {
                BitManipulationNextNumber1BruteForceComplete.GetPrev(-1);
            }
            catch (ArgumentException)
            {
                Assert.IsTrue(true);
                return;
            }
            Assert.Fail();
        }

        /// <summary>
        /// Tests BitManipulationNextNumber1BruteForceComplete.GetNext with all bits clear.
        /// </summary>
        [TestMethod]
        public void BitManipulationNextNumber1BruteForceCompleteTestGetPrev5AllClear()
        {
            var original = 0;
            var actual = BitManipulationNextNumber1BruteForceComplete.GetPrev(original);
            Assert.AreEqual(-1, actual);
        }

        /// <summary>
        /// Tests BitManipulationNextNumber1BruteForceComplete.GetPrev underflow.
        /// </summary>
        [TestMethod]
        public void BitManipulationNextNumber1BruteForceCompleteTestGetPrev6NoSolution()
        {
            var actual = BitManipulationNextNumber1BruteForceComplete.GetPrev(Convert.ToInt32("1111", 2));
            Assert.AreEqual(-1, actual);
        }
    }
}
