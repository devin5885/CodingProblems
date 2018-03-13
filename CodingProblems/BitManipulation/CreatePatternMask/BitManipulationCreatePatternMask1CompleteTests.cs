using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodingProblems.BitManipulation.CreatePatternMask
{
    /// <summary>
    /// Tests BitManipulationCreateSimpleMaskComplete in various scenarios.
    /// </summary>
    [TestClass]
    public class BitManipulationCreatePatternMask1CompleteTests
    {
        /// <summary>
        /// Tests creating an "01" mask.
        /// </summary>
        [TestMethod]
        public void BitManipulationCreatePatternMask1CompleteTest1Simple()
        {
            var pattern = 1;
            var patternbitcount = 2;
            Assert.AreEqual(Convert.ToInt32("01010101010101010101010101010101", 2), BitManipulationCreatePatternMask1Complete.CreatePatternMask(pattern, patternbitcount));
        }

        /// <summary>
        /// Tests creating an "10" mask.
        /// </summary>
        [TestMethod]
        public void BitManipulationCreatePatternMask1CompleteTest2Simple()
        {
            var pattern = Convert.ToInt32("10", 2);
            var patternbitcount = 2;
            Assert.AreEqual(Convert.ToInt32("10101010101010101010101010101010", 2), BitManipulationCreatePatternMask1Complete.CreatePatternMask(pattern, patternbitcount));
        }

        /// <summary>
        /// Tests creating an uneven bit count mask (5) "01110" mask.
        /// </summary>
        [TestMethod]
        public void BitManipulationCreatePatternMask1CompleteTest3UnevenBitCount()
        {
            var pattern = Convert.ToInt32("01110", 2);
            var patternbitcount = 5;
            var expected = Convert.ToInt32("10011100111001110011100111001110", 2);
            Assert.AreEqual(expected, BitManipulationCreatePatternMask1Complete.CreatePatternMask(pattern, patternbitcount));
        }

        /// <summary>
        /// Tests creating a 32 bit mask.
        /// </summary>
        [TestMethod]
        public void BitManipulationCreatePatternMask1CompleteTest332bit()
        {
            var pattern = Convert.ToInt32("11111111111111111111111111111111", 2);
            var patternbitcount = 32;
            var expected = Convert.ToInt32("11111111111111111111111111111111", 2);
            Assert.AreEqual(expected, BitManipulationCreatePatternMask1Complete.CreatePatternMask(pattern, patternbitcount));
        }

        /// <summary>
        /// Tests bit count less than 0
        /// </summary>
        [TestMethod]
        public void BitManipulationCreatePatternMask1CompleteTest2ErrorPatternBitCountNegative()
        {
            try
            {
                BitManipulationCreatePatternMask1Complete.CreatePatternMask(1, -1);
            }
            catch (ArgumentException)
            {
                Assert.IsTrue(true);
                return;
            }
            Assert.Fail();
        }

        /// <summary>
        /// Tests bit count equal to 0
        /// </summary>
        [TestMethod]
        public void BitManipulationCreatePatternMask1CompleteTest2ErrorPatternBitCountZero()
        {
            try
            {
                BitManipulationCreatePatternMask1Complete.CreatePatternMask(1, 0);
            }
            catch (ArgumentException)
            {
                Assert.IsTrue(true);
                return;
            }
            Assert.Fail();
        }

        /// <summary>
        /// Test bit count greater than 32.
        /// </summary>
        [TestMethod]
        public void BitManipulationCreatePatternMask1CompleteTest2ErrorPatternBitCountToLarge()
        {
            try
            {
                BitManipulationCreatePatternMask1Complete.CreatePatternMask(1, 33);
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
