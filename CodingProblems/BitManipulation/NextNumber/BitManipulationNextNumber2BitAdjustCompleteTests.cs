using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodingProblems.BitManipulation.NextNumber
{
    /// <summary>
    /// Tests BitManipulationNextNumber2BitAdjustComplete.GetNext/GetPrev.
    /// </summary>
    [TestClass]
    public class BitManipulationNextNumber2BitAdjustCompleteTests
    {
        /// <summary>
        /// Tests BitManipulationNextNumber2BitAdjustComplete.GetNext simple test.
        /// </summary>
        [TestMethod]
        public void BitManipulationNextNumber2BitAdjustCompleteTestGetNext1Simple1()
        {
            var original = 1;
            var expected = Convert.ToInt32("10", 2);
            var actual = BitManipulationNextNumber2BitAdjustComplete.GetNext(original);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Tests BitManipulationNextNumber2BitAdjustComplete.GetNext simple test2 (with random #).
        /// </summary>
        [TestMethod]
        public void BitManipulationNextNumber2BitAdjustCompleteTestGetNext2Simple2()
        {
            var original = Convert.ToInt32("101010011101100", 2);
            var expected = Convert.ToInt32("101010011110001", 2);
            var actual = BitManipulationNextNumber2BitAdjustComplete.GetNext(original);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Tests BitManipulationNextNumber2BitAdjustComplete.GetNext with all bits set (except sign bit).
        /// </summary>
        [TestMethod]
        public void BitManipulationNextNumber2BitAdjustCompleteTestGetNext3AllSet()
        {
            var original = Convert.ToInt32("01111111111111111111111111111111", 2);
            var actual = BitManipulationNextNumber2BitAdjustComplete.GetNext(original);
            Assert.AreEqual(-1, actual);
        }

        /// <summary>
        /// Tests BitManipulationNextNumber2BitAdjustComplete.GetNext with negative #.
        /// </summary>
        [TestMethod]
        public void BitManipulationNextNumber2BitAdjustCompleteTestGetNext4NegativeNumber()
        {
            try
            {
                BitManipulationNextNumber2BitAdjustComplete.GetNext(-1);
            }
            catch (ArgumentException)
            {
                Assert.IsTrue(true);
                return;
            }
            Assert.Fail();
        }

        /// <summary>
        /// Tests BitManipulationNextNumber2BitAdjustComplete.GetNext with all bits clear.
        /// </summary>
        [TestMethod]
        public void BitManipulationNextNumber2BitAdjustCompleteTestGetNext5AllClear()
        {
            var actual = BitManipulationNextNumber2BitAdjustComplete.GetNext(0);
            Assert.AreEqual(-1, actual);
        }

        /// <summary>
        /// Tests BitManipulationNextNumber2BitAdjustComplete.GetNext with no solution.
        /// </summary>
        [TestMethod]
        public void BitManipulationNextNumber2BitAdjustCompleteTestGetNext6NoSolution()
        {
            var original = Convert.ToInt32("01111111111111110000000000000000", 2);
            var actual = BitManipulationNextNumber2BitAdjustComplete.GetNext(original);
            Assert.AreEqual(-1, actual);
        }

        /// <summary>
        /// Tests BitManipulationNextNumber2BitAdjustComplete.GetPrev simple test.
        /// </summary>
        [TestMethod]
        public void BitManipulationNextNumber2BitAdjustCompleteTestGetPrev1Simple()
        {
            var original = Convert.ToInt32("10", 2);
            var expected = Convert.ToInt32("1", 2);
            var actual = BitManipulationNextNumber2BitAdjustComplete.GetPrev(original);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Tests BitManipulationNextNumber2BitAdjustComplete.GetPrev simple test2 (with random #).
        /// </summary>
        [TestMethod]
        public void BitManipulationNextNumber2BitAdjustCompleteTestGetPrev2Simple2()
        {
            var original = Convert.ToInt32("101010011101100", 2);
            var expected = Convert.ToInt32("101010011101010", 2);
            var actual = BitManipulationNextNumber2BitAdjustComplete.GetPrev(original);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Tests BitManipulationNextNumber2BitAdjustComplete.GetNext with all bits set (except sign bit).
        /// </summary>
        [TestMethod]
        public void BitManipulationNextNumber2BitAdjustCompleteTestGetPrev3AllSet()
        {
            var original = Convert.ToInt32("01111111111111111111111111111111", 2);
            var actual = BitManipulationNextNumber2BitAdjustComplete.GetPrev(original);
            Assert.AreEqual(-1, actual);
        }

        /// <summary>
        /// Tests BitManipulationNextNumber2BitAdjustComplete.GetPrev with negative #.
        /// </summary>
        [TestMethod]
        public void BitManipulationNextNumber2BitAdjustCompleteTestGetPrev4NegativeNumber()
        {
            try
            {
                BitManipulationNextNumber2BitAdjustComplete.GetPrev(-1);
            }
            catch (ArgumentException)
            {
                Assert.IsTrue(true);
                return;
            }
            Assert.Fail();
        }

        /// <summary>
        /// Tests BitManipulationNextNumber2BitAdjustComplete.GetNext with all bits clear.
        /// </summary>
        [TestMethod]
        public void BitManipulationNextNumber2BitAdjustCompleteTestGetPrev5AllClear()
        {
            var original = 0;
            var actual = BitManipulationNextNumber2BitAdjustComplete.GetPrev(original);
            Assert.AreEqual(-1, actual);
        }

        /// <summary>
        /// Tests BitManipulationNextNumber2BitAdjustComplete.GetPrev underflow.
        /// </summary>
        [TestMethod]
        public void BitManipulationNextNumber2BitAdjustCompleteTestGetPrev6NoSolution()
        {
            var actual = BitManipulationNextNumber2BitAdjustComplete.GetPrev(Convert.ToInt32("1111", 2));
            Assert.AreEqual(-1, actual);
        }
    }
}
