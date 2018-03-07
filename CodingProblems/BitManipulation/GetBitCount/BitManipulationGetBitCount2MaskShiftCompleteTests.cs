using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodingProblems.BitManipulation.GetBitCount
{
    /// <summary>
    /// Tests BitManipulationGetBitCount2MaskShiftComplete.GetBitCount
    /// </summary>
    [TestClass]
    public class BitManipulationGetBitCount2MaskShiftCompleteTests
    {
        /// <summary>
        /// Tests BitManipulationGetBitCount2MaskShiftComplete.GetBitCount
        /// </summary>
        [TestMethod]
        public void BitManipulationGetBitCount2MaskShiftCompleteTest1()
        {
            // 0.
            Assert.AreEqual(0, BitManipulationGetBitCount2MaskShiftComplete.GetBitCount(0));

            // Positive.
            Assert.AreEqual(1, BitManipulationGetBitCount2MaskShiftComplete.GetBitCount(1));
            Assert.AreEqual(1, BitManipulationGetBitCount2MaskShiftComplete.GetBitCount(2));
            Assert.AreEqual(2, BitManipulationGetBitCount2MaskShiftComplete.GetBitCount(3));
            Assert.AreEqual(31, BitManipulationGetBitCount2MaskShiftComplete.GetBitCount(int.MaxValue));

            // Negative.
            Assert.AreEqual(32, BitManipulationGetBitCount2MaskShiftComplete.GetBitCount(-1));
            Assert.AreEqual(31, BitManipulationGetBitCount2MaskShiftComplete.GetBitCount(-2));
            Assert.AreEqual(31, BitManipulationGetBitCount2MaskShiftComplete.GetBitCount(-3));
            Assert.AreEqual(1, BitManipulationGetBitCount2MaskShiftComplete.GetBitCount(int.MinValue));
        }
    }
}
