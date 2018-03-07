using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodingProblems.BitManipulation.GetBitCount
{
    /// <summary>
    /// Tests BitManipulationGetBitCount3BitShiftComplete.GetBitCount
    /// </summary>
    [TestClass]
    public class BitManipulationGetBitCount3BitShiftCompleteTests
    {
        /// <summary>
        /// Tests BitManipulationGetBitCount3BitShiftComplete.GetBitCount
        /// </summary>
        [TestMethod]
        public void BitManipulationGetBitCount3BitShiftCompleteTest1()
        {
            // 0.
            Assert.AreEqual(0, BitManipulationGetBitCount3BitShiftComplete.GetBitCount(0));

            // Positive.
            Assert.AreEqual(1, BitManipulationGetBitCount3BitShiftComplete.GetBitCount(1));
            Assert.AreEqual(1, BitManipulationGetBitCount3BitShiftComplete.GetBitCount(2));
            Assert.AreEqual(2, BitManipulationGetBitCount3BitShiftComplete.GetBitCount(3));
            Assert.AreEqual(31, BitManipulationGetBitCount3BitShiftComplete.GetBitCount(int.MaxValue));

            // Negative.
            Assert.AreEqual(32, BitManipulationGetBitCount3BitShiftComplete.GetBitCount(-1));
            Assert.AreEqual(31, BitManipulationGetBitCount3BitShiftComplete.GetBitCount(-2));
            Assert.AreEqual(31, BitManipulationGetBitCount3BitShiftComplete.GetBitCount(-3));
            Assert.AreEqual(1, BitManipulationGetBitCount3BitShiftComplete.GetBitCount(int.MinValue));
        }
    }
}
