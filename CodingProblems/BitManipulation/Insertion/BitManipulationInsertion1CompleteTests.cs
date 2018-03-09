using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodingProblems.BitManipulation.Insertion
{
    /// <summary>
    /// Tests BitManipulationGetBitCount1ConvertToStringComplete.GetBitCount
    /// </summary>
    [TestClass]
    public class BitManipulationInsertion1CompleteTests
    {
        /// <summary>
        /// Tests BitManipulationInsertion1Complete.UpdateBits simple test.
        /// </summary>
        [TestMethod]
        public void BitManipulationInsertion1CompleteTest1()
        {
            Assert.AreEqual(0b100_0100_1100, BitManipulationInsertion1Complete.UpdateBits(0b100_0000_0000, 0b1_0011, 2, 6));
        }

        /// <summary>
        /// Tests BitManipulationInsertion1Complete.UpdateBits with replacing 1 bits in M.
        /// </summary>
        [TestMethod]
        public void BitManipulationInsertion1CompleteTest2()
        {
            Assert.AreEqual(0b1111_1010, BitManipulationInsertion1Complete.UpdateBits(0b1111_1110, 0b101, 1, 3));
        }

        /// <summary>
        /// Tests BitManipulationInsertion1Complete.UpdateBits in the case that j-i > n.msb-n.lsb.
        /// </summary>
        [TestMethod]
        public void BitManipulationInsertion1CompleteTest3()
        {
            Assert.AreEqual(0b1110_1010, BitManipulationInsertion1Complete.UpdateBits(0b1111_1110, 0b101, 1, 4));
        }

        /// <summary>
        /// Tests UpdateBits with an invalid i.
        /// </summary>
        [TestMethod]
        public void BitManipulationInsertion1CompleteTest4ErroriParameterInvalid()
        {
            try
            {
                BitManipulationInsertion1Complete.UpdateBits(0b100_0000_0000, 0b1_0011, 35, 40);
            }
            catch (ArgumentException)
            {
                Assert.IsTrue(true);
                return;
            }
            Assert.Fail();
        }

        /// <summary>
        /// Tests UpdateBits with an invalid j.
        /// </summary>
        [TestMethod]
        public void BitManipulationInsertion1CompleteTest5ErrorjParameterInvalid()
        {
            try
            {
                BitManipulationInsertion1Complete.UpdateBits(0b100_0000_0000, 0b1_0011, 25, 40);
            }
            catch (ArgumentException)
            {
                Assert.IsTrue(true);
                return;
            }
            Assert.Fail();
        }

        /// <summary>
        /// Tests UpdateBits with an invalid j.
        /// </summary>
        [TestMethod]
        public void BitManipulationInsertion1CompleteTest6ErroriParameterGreaterThanjInvalid()
        {
            try
            {
                BitManipulationInsertion1Complete.UpdateBits(0b100_0000_0000, 0b1_0011, 20, 15);
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
