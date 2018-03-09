using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodingProblems.BitManipulation.PairwiseSwap
{
    /// <summary>
    /// Tests BitManipulationPairwiseSwap1BruteForceComplete.PairwiseSwap
    /// </summary>
    [TestClass]
    public class BitManipulationPairwiseSwap1BruteForceCompleteTests
    {
        /// <summary>
        /// Tests BitManipulationPairwiseSwap1BruteForceComplete.SwapOddEvenBits simple test.
        /// </summary>
        [TestMethod]
        public void BitManipulationPairwiseSwap1BruteForceCompleteTest1()
        {
            var expected = Convert.ToInt32("10", 2);
            var actual = BitManipulationPairwiseSwap1BruteForceComplete.SwapOddEvenBits(Convert.ToInt32("1", 2));
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Tests BitManipulationPairwiseSwap2BruteForceComplete.SwapOddEvenBits simple test.
        /// </summary>
        [TestMethod]
        public void BitManipulationPairwiseSwap2BruteForceCompleteTest2()
        {
            var expected = Convert.ToInt32("1101", 2);
            var actual = BitManipulationPairwiseSwap1BruteForceComplete.SwapOddEvenBits(Convert.ToInt32("1110", 2));
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Tests BitManipulationPairwiseSwap1BruteForceComplete.SwapOddEvenBits test with multiple bits to set/clear.
        /// </summary>
        [TestMethod]
        public void BitManipulationPairwiseSwap1BruteForceCompleteTest3()
        {
            var original = Convert.ToInt32("10101010101010101010101010101010", 2);
            var expected = Convert.ToInt32("01010101010101010101010101010101", 2);

            // Swap
            var actual = BitManipulationPairwiseSwap1BruteForceComplete.SwapOddEvenBits(original);
            Assert.AreEqual(expected, actual);

            // Swap back.
            var actual2 = BitManipulationPairwiseSwap1BruteForceComplete.SwapOddEvenBits(actual);
            Assert.AreEqual(actual2, original);
        }
    }
}
