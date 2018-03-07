using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodingProblems.BitManipulation.GetBitCount
{
    /// <summary>
    /// Tests BitManipulationGetBitCount1ConvertToStringComplete.GetBitCount
    /// </summary>
    [TestClass]
    public class BitManipulationGetBitCount1ConvertToStringCompleteTests
    {
        /// <summary>
        /// Tests BitManipulationGetBitCount1ConvertToStringComplete.GetBitCount
        /// </summary>
        [TestMethod]
        public void BitManipulationGetBitCount1ConvertToStringCompleteTest1()
        {
            // 0.
            Assert.AreEqual(0, BitManipulationGetBitCount1ConvertToStringComplete.GetBitCount(0));

            // Positive.
            Assert.AreEqual(1, BitManipulationGetBitCount1ConvertToStringComplete.GetBitCount(1));
            Assert.AreEqual(1, BitManipulationGetBitCount1ConvertToStringComplete.GetBitCount(2));
            Assert.AreEqual(2, BitManipulationGetBitCount1ConvertToStringComplete.GetBitCount(3));
            Assert.AreEqual(31, BitManipulationGetBitCount1ConvertToStringComplete.GetBitCount(int.MaxValue));

            // Negative.
            Assert.AreEqual(32, BitManipulationGetBitCount1ConvertToStringComplete.GetBitCount(-1));
            Assert.AreEqual(31, BitManipulationGetBitCount1ConvertToStringComplete.GetBitCount(-2));
            Assert.AreEqual(31, BitManipulationGetBitCount1ConvertToStringComplete.GetBitCount(-3));
            Assert.AreEqual(1, BitManipulationGetBitCount1ConvertToStringComplete.GetBitCount(int.MinValue));
        }
    }
}
