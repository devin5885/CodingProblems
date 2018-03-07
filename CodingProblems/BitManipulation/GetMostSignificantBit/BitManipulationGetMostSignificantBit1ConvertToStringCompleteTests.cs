using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodingProblems.BitManipulation.GetMostSignificantBit
{
    /// <summary>
    /// Tests BitManipulationGetMostSignificantBit1ConvertToStringComplete.GetMostSignificantBit
    /// </summary>
    [TestClass]
    public class BitManipulationGetMostSignificantBit1ConvertToStringCompleteTests
    {
        /// <summary>
        /// Tests BitManipulationGetMostSignificantBit1ConvertToStringComplete.GetMostSignificantBit
        /// </summary>
        [TestMethod]
        public void BitwiseGetMostSignificantBit1ConvertToStringCompleteTest1()
        {
            Assert.AreEqual(0, BitManipulationGetMostSignificantBit1ConvertToStringComplete.GetMostSignificantBit(0));
            Assert.AreEqual(1, BitManipulationGetMostSignificantBit1ConvertToStringComplete.GetMostSignificantBit(1));
            Assert.AreEqual(2, BitManipulationGetMostSignificantBit1ConvertToStringComplete.GetMostSignificantBit(2));
            Assert.AreEqual(2, BitManipulationGetMostSignificantBit1ConvertToStringComplete.GetMostSignificantBit(3));
            Assert.AreEqual(8, BitManipulationGetMostSignificantBit1ConvertToStringComplete.GetMostSignificantBit(128));
            Assert.AreEqual(16, BitManipulationGetMostSignificantBit1ConvertToStringComplete.GetMostSignificantBit(32768));
            Assert.AreEqual(17, BitManipulationGetMostSignificantBit1ConvertToStringComplete.GetMostSignificantBit(65536));
            Assert.AreEqual(24, BitManipulationGetMostSignificantBit1ConvertToStringComplete.GetMostSignificantBit(8388608));
            Assert.AreEqual(31, BitManipulationGetMostSignificantBit1ConvertToStringComplete.GetMostSignificantBit(int.MaxValue));
        }
    }
}
