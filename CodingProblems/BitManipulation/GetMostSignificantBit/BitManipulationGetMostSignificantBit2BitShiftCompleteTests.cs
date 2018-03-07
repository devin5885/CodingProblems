using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodingProblems.BitManipulation.GetMostSignificantBit
{
    /// <summary>
    /// Tests BitManipulationGetMostSignificantBit2BitShiftComplete.GetMostSignificantBit
    /// </summary>
    [TestClass]
    public class BitManipulationGetMostSignificantBit2BitShiftCompleteTests
    {
        /// <summary>
        /// Tests BitManipulationGetMostSignificantBit2BitShiftComplete.GetMostSignificantBit
        /// </summary>
        [TestMethod]
        public void BitwiseGetMostSignificantBit2BitShiftCompleteTest1()
        {
            Assert.AreEqual(0, BitManipulationGetMostSignificantBit2BitShiftComplete.GetMostSignificantBit(0));
            Assert.AreEqual(1, BitManipulationGetMostSignificantBit2BitShiftComplete.GetMostSignificantBit(1));
            Assert.AreEqual(2, BitManipulationGetMostSignificantBit2BitShiftComplete.GetMostSignificantBit(2));
            Assert.AreEqual(2, BitManipulationGetMostSignificantBit2BitShiftComplete.GetMostSignificantBit(3));
            Assert.AreEqual(8, BitManipulationGetMostSignificantBit2BitShiftComplete.GetMostSignificantBit(128));
            Assert.AreEqual(16, BitManipulationGetMostSignificantBit2BitShiftComplete.GetMostSignificantBit(32768));
            Assert.AreEqual(17, BitManipulationGetMostSignificantBit2BitShiftComplete.GetMostSignificantBit(65536));
            Assert.AreEqual(24, BitManipulationGetMostSignificantBit2BitShiftComplete.GetMostSignificantBit(8388608));
            Assert.AreEqual(31, BitManipulationGetMostSignificantBit2BitShiftComplete.GetMostSignificantBit(int.MaxValue));
        }
    }
}
