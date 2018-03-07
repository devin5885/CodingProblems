using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodingProblems.BitManipulation.GetMostSignificantBit
{
    /// <summary>
    /// Tests BitManipulationGetMostSignificantBit3MaskShiftComplete.GetMostSignificantBit
    /// </summary>
    [TestClass]
    public class BitManipulationGetMostSignificantBit3MaskShiftCompleteTests
    {
        /// <summary>
        /// Tests BitManipulationGetMostSignificantBit3MaskShiftComplete.GetMostSignificantBit
        /// </summary>
        [TestMethod]
        public void BitwiseGetMostSignificantBit3MaskShiftCompleteTest1()
        {
            Assert.AreEqual(0, BitManipulationGetMostSignificantBit3MaskShiftComplete.GetMostSignificantBit(0));
            Assert.AreEqual(1, BitManipulationGetMostSignificantBit3MaskShiftComplete.GetMostSignificantBit(1));
            Assert.AreEqual(2, BitManipulationGetMostSignificantBit3MaskShiftComplete.GetMostSignificantBit(2));
            Assert.AreEqual(2, BitManipulationGetMostSignificantBit3MaskShiftComplete.GetMostSignificantBit(3));
            Assert.AreEqual(8, BitManipulationGetMostSignificantBit3MaskShiftComplete.GetMostSignificantBit(128));
            Assert.AreEqual(16, BitManipulationGetMostSignificantBit3MaskShiftComplete.GetMostSignificantBit(32768));
            Assert.AreEqual(17, BitManipulationGetMostSignificantBit3MaskShiftComplete.GetMostSignificantBit(65536));
            Assert.AreEqual(24, BitManipulationGetMostSignificantBit3MaskShiftComplete.GetMostSignificantBit(8388608));
            Assert.AreEqual(31, BitManipulationGetMostSignificantBit3MaskShiftComplete.GetMostSignificantBit(int.MaxValue));
        }
    }
}
