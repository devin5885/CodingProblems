using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodingProblems.BitManipulation.CreateSimpleMask
{
    /// <summary>
    /// Tests BitManipulationCreateMaskComplete
    /// </summary>
    [TestClass]
    public class BitManipulationCreateSimpleMask2UseSetClearBitCompleteTests
    {
        /// <summary>
        /// Standard tests.
        /// </summary>
        [TestMethod]
        public void BitManipulationCreateMask2UseSetClearBitCompleteTest1()
        {
            // Various masks.
            Assert.AreEqual(Convert.ToInt32("11111111111111111111111111111111", 2), BitManipulationCreateSimpleMask2UseSetClearBitComplete.CreateSimpleMask(31, 0));
            Assert.AreEqual(Convert.ToInt32("11111111111111111111111111111110", 2), BitManipulationCreateSimpleMask2UseSetClearBitComplete.CreateSimpleMask(31, 1));
            Assert.AreEqual(Convert.ToInt32("00000000000000000000000000000001", 2), BitManipulationCreateSimpleMask2UseSetClearBitComplete.CreateSimpleMask(0, 0));
            Assert.AreEqual(Convert.ToInt32("00000000000000000000000000000011", 2), BitManipulationCreateSimpleMask2UseSetClearBitComplete.CreateSimpleMask(1, 0));
            Assert.AreEqual(Convert.ToInt32("00000000000000000000000000000010", 2), BitManipulationCreateSimpleMask2UseSetClearBitComplete.CreateSimpleMask(1, 1));
            Assert.AreEqual(Convert.ToInt32("00000000000011111111000000000000", 2), BitManipulationCreateSimpleMask2UseSetClearBitComplete.CreateSimpleMask(19, 12));
            Assert.AreEqual(Convert.ToInt32("11100000000000000000000000000000", 2), BitManipulationCreateSimpleMask2UseSetClearBitComplete.CreateSimpleMask(31, 29));
            Assert.AreEqual(Convert.ToInt32("00000111100000000000000000000000", 2), BitManipulationCreateSimpleMask2UseSetClearBitComplete.CreateSimpleMask(26, 23));

            // Special case, 0 mask.
            Assert.AreEqual(Convert.ToInt32("00000000000000000000000000000000", 2), ~BitManipulationCreateSimpleMask2UseSetClearBitComplete.CreateSimpleMask(31, 0));
        }

        /// <summary>
        /// Tests an invalid first parameter.
        /// </summary>
        [TestMethod]
        public void BitManipulationCreateMask2UseSetClearBitCompleteTest2ErrorFirstParameterInvalid()
        {
            try
            {
                BitManipulationCreateSimpleMask2UseSetClearBitComplete.CreateSimpleMask(32, 0);
            }
            catch (ArgumentException)
            {
                Assert.IsTrue(true);
                return;
            }
            Assert.Fail();
        }

        /// <summary>
        /// Tests an invalid second parameter.
        /// </summary>
        [TestMethod]
        public void BitManipulationCreateMask2UseSetClearBitCompleteTest3ErrorSecondParameterInvalid()
        {
            try
            {
                BitManipulationCreateSimpleMask2UseSetClearBitComplete.CreateSimpleMask(31, -1);
            }
            catch (ArgumentException)
            {
                Assert.IsTrue(true);
                return;
            }
            Assert.Fail();
        }

        /// <summary>
        /// Tests the second parameter larger than the first.
        /// </summary>
        [TestMethod]
        public void BitManipulationCreateMask2UseSetClearBitCompleteTest4ErrorSecondParameterLarger()
        {
            try
            {
                BitManipulationCreateSimpleMask2UseSetClearBitComplete.CreateSimpleMask(10, 12);
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