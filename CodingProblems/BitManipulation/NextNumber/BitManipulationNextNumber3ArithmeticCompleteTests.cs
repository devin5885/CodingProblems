using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodingProblems.BitManipulation.NextNumber
{
    /// <summary>
    /// Tests BitManipulationNextNumber3ArithmeticComplete.GetNext/GetPrev.
    /// </summary>
    [TestClass]
    public class BitManipulationNextNumber3ArithmeticCompleteTests
    {
        /// <summary>
        /// Tests BitManipulationNextNumber3ArithmeticComplete.GetNext simple test.
        /// </summary>
        [TestMethod]
        public void BitManipulationNextNumber3ArithmeticCompleteTestGetNext1Simple1()
        {
            var original = 1;
            var expected = Convert.ToInt32("10", 2);
            var actual = BitManipulationNextNumber3ArithmeticComplete.GetNext(original);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Tests BitManipulationNextNumber3ArithmeticComplete.GetNext simple test2 (with random #).
        /// </summary>
        [TestMethod]
        public void BitManipulationNextNumber3ArithmeticCompleteTestGetNext2Simple2()
        {
            var original = Convert.ToInt32("101010011101100", 2);
            var expected = Convert.ToInt32("101010011110001", 2);
            var actual = BitManipulationNextNumber3ArithmeticComplete.GetNext(original);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Tests BitManipulationNextNumber3ArithmeticComplete.GetNext with all bits set (except sign bit).
        /// </summary>
        [TestMethod]
        public void BitManipulationNextNumber3ArithmeticCompleteTestGetNext3AllSet()
        {
            var original = Convert.ToInt32("01111111111111111111111111111111", 2);
            var actual = BitManipulationNextNumber3ArithmeticComplete.GetNext(original);
            Assert.AreEqual(-1, actual);
        }

        /// <summary>
        /// Tests BitManipulationNextNumber3ArithmeticComplete.GetNext with negative #.
        /// </summary>
        [TestMethod]
        public void BitManipulationNextNumber3ArithmeticCompleteTestGetNext4NegativeNumber()
        {
            try
            {
                BitManipulationNextNumber3ArithmeticComplete.GetNext(-1);
            }
            catch (ArgumentException)
            {
                Assert.IsTrue(true);
                return;
            }
            Assert.Fail();
        }

        /// <summary>
        /// Tests BitManipulationNextNumber3ArithmeticComplete.GetNext with all bits clear.
        /// </summary>
        [TestMethod]
        public void BitManipulationNextNumber3ArithmeticCompleteTestGetNext5AllClear()
        {
            var actual = BitManipulationNextNumber3ArithmeticComplete.GetNext(0);
            Assert.AreEqual(-1, actual);
        }

        /// <summary>
        /// Tests BitManipulationNextNumber3ArithmeticComplete.GetNext with no solution.
        /// </summary>
        [TestMethod]
        public void BitManipulationNextNumber3ArithmeticCompleteTestGetNext6NoSolution()
        {
            var original = Convert.ToInt32("01111111111111110000000000000000", 2);
            var actual = BitManipulationNextNumber3ArithmeticComplete.GetNext(original);
            Assert.AreEqual(-1, actual);
        }

        /// <summary>
        /// Tests BitManipulationNextNumber3ArithmeticComplete.GetPrev simple test.
        /// </summary>
        [TestMethod]
        public void BitManipulationNextNumber3ArithmeticCompleteTestGetPrev1Simple()
        {
            var original = Convert.ToInt32("10", 2);
            var expected = Convert.ToInt32("1", 2);
            var actual = BitManipulationNextNumber3ArithmeticComplete.GetPrev(original);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Tests BitManipulationNextNumber3ArithmeticComplete.GetPrev simple test2 (with random #).
        /// </summary>
        [TestMethod]
        public void BitManipulationNextNumber3ArithmeticCompleteTestGetPrev2Simple2()
        {
            var original = Convert.ToInt32("101010011101100", 2);
            var expected = Convert.ToInt32("101010011101010", 2);
            var actual = BitManipulationNextNumber3ArithmeticComplete.GetPrev(original);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Tests BitManipulationNextNumber3ArithmeticComplete.GetNext with all bits set (except sign bit).
        /// </summary>
        [TestMethod]
        public void BitManipulationNextNumber3ArithmeticCompleteTestGetPrev3AllSet()
        {
            var original = Convert.ToInt32("01111111111111111111111111111111", 2);
            var actual = BitManipulationNextNumber3ArithmeticComplete.GetPrev(original);
            Assert.AreEqual(-1, actual);
        }

        /// <summary>
        /// Tests BitManipulationNextNumber3ArithmeticComplete.GetPrev with negative #.
        /// </summary>
        [TestMethod]
        public void BitManipulationNextNumber3ArithmeticCompleteTestGetPrev4NegativeNumber()
        {
            try
            {
                BitManipulationNextNumber3ArithmeticComplete.GetPrev(-1);
            }
            catch (ArgumentException)
            {
                Assert.IsTrue(true);
                return;
            }
            Assert.Fail();
        }

        /// <summary>
        /// Tests BitManipulationNextNumber3ArithmeticComplete.GetNext with all bits clear.
        /// </summary>
        [TestMethod]
        public void BitManipulationNextNumber3ArithmeticCompleteTestGetPrev5AllClear()
        {
            var original = 0;
            var actual = BitManipulationNextNumber3ArithmeticComplete.GetPrev(original);
            Assert.AreEqual(-1, actual);
        }

        /// <summary>
        /// Tests BitManipulationNextNumber3ArithmeticComplete.GetPrev underflow.
        /// </summary>
        [TestMethod]
        public void BitManipulationNextNumber3ArithmeticCompleteTestGetPrev6NoSolution()
        {
            var actual = BitManipulationNextNumber3ArithmeticComplete.GetPrev(Convert.ToInt32("1111", 2));
            Assert.AreEqual(-1, actual);
        }
    }
}
