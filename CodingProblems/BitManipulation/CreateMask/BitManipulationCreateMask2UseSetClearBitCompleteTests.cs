﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodingProblems.BitManipulation.CreateMask
{
    /// <summary>
    /// Tests BitManipulationCreateMaskComplete
    /// </summary>
    [TestClass]
    public class BitManipulationCreateMask2UseSetClearBitCompleteTests
    {
        /// <summary>
        /// Tests BitManipulationCreateMask
        /// </summary>
        [TestMethod]
        public void BitManipulationCreateMask2UseSetClearBitCompleteTest1()
        {
            // Various masks.
            Assert.AreEqual(Convert.ToInt32("11111111111111111111111111111111", 2), BitManipulationCreateMask2UseSetClearBitComplete.CreateMask(31, 0));
            Assert.AreEqual(Convert.ToInt32("11111111111111111111111111111110", 2), BitManipulationCreateMask2UseSetClearBitComplete.CreateMask(31, 1));
            Assert.AreEqual(Convert.ToInt32("00000000000000000000000000000001", 2), BitManipulationCreateMask2UseSetClearBitComplete.CreateMask(0, 0));
            Assert.AreEqual(Convert.ToInt32("00000000000000000000000000000011", 2), BitManipulationCreateMask2UseSetClearBitComplete.CreateMask(1, 0));
            Assert.AreEqual(Convert.ToInt32("00000000000000000000000000000010", 2), BitManipulationCreateMask2UseSetClearBitComplete.CreateMask(1, 1));
            Assert.AreEqual(Convert.ToInt32("00000000000011111111000000000000", 2), BitManipulationCreateMask2UseSetClearBitComplete.CreateMask(19, 12));
            Assert.AreEqual(Convert.ToInt32("11100000000000000000000000000000", 2), BitManipulationCreateMask2UseSetClearBitComplete.CreateMask(31, 29));
            Assert.AreEqual(Convert.ToInt32("00000111100000000000000000000000", 2), BitManipulationCreateMask2UseSetClearBitComplete.CreateMask(26, 23));

            // Special case, 0 mask.
            Assert.AreEqual(Convert.ToInt32("00000000000000000000000000000000", 2), ~BitManipulationCreateMask2UseSetClearBitComplete.CreateMask(31, 0));
        }

        /// <summary>
        /// Tests BitManipulationCreateMask with an invalid first parameter.
        /// </summary>
        [TestMethod]
        public void BitManipulationCreateMask2UseSetClearBitCompleteTest2ErrorFirstParameterInvalid()
        {
            try
            {
                BitManipulationCreateMask2UseSetClearBitComplete.CreateMask(32, 0);
            }
            catch (ArgumentException)
            {
                Assert.IsTrue(true);
                return;
            }
            Assert.Fail();
        }

        /// <summary>
        /// Tests BitManipulationCreateMask with an invalid second parameter.
        /// </summary>
        [TestMethod]
        public void BitManipulationCreateMask2UseSetClearBitCompleteTest3ErrorSecondParameterInvalid()
        {
            try
            {
                BitManipulationCreateMask2UseSetClearBitComplete.CreateMask(31, -1);
            }
            catch (ArgumentException)
            {
                Assert.IsTrue(true);
                return;
            }
            Assert.Fail();
        }

        /// <summary>
        /// Tests BitManipulationCreateMask with the second parameter larger than the first.
        /// </summary>
        [TestMethod]
        public void BitManipulationCreateMask2UseSetClearBitCompleteTest4ErrorSecondParameterLarger()
        {
            try
            {
                BitManipulationCreateMask2UseSetClearBitComplete.CreateMask(10, 12);
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