using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodingProblems.BitManipulation.GetMostSignificantBit
{
    /// <summary>
    /// Tests BitManipulationGetMostSignificantBit4BinarySearchComplete.GetMostSignificantBit
    /// </summary>
    [TestClass]
    public class BitManipulationGetMostSignificantBit4BinarySearchCompleteTests
    {
        /// <summary>
        /// Tests BitManipulationGetMostSignificantBit4BinarySearchComplete.GetMostSignificantBit
        /// </summary>
        [TestMethod]
        public void BitwiseGetMostSignificantBit4BinarySearchCompleteTest1()
        {
            Assert.AreEqual(0, BitManipulationGetMostSignificantBit4BinarySearchComplete.GetMostSignificantBit(0));
            Assert.AreEqual(1, BitManipulationGetMostSignificantBit4BinarySearchComplete.GetMostSignificantBit(1));
            Assert.AreEqual(2, BitManipulationGetMostSignificantBit4BinarySearchComplete.GetMostSignificantBit(2));
            Assert.AreEqual(2, BitManipulationGetMostSignificantBit4BinarySearchComplete.GetMostSignificantBit(3));
            Assert.AreEqual(8, BitManipulationGetMostSignificantBit4BinarySearchComplete.GetMostSignificantBit(128));
            Assert.AreEqual(16, BitManipulationGetMostSignificantBit4BinarySearchComplete.GetMostSignificantBit(32768));
            Assert.AreEqual(17, BitManipulationGetMostSignificantBit4BinarySearchComplete.GetMostSignificantBit(65536));
            Assert.AreEqual(24, BitManipulationGetMostSignificantBit4BinarySearchComplete.GetMostSignificantBit(8388608));
            Assert.AreEqual(31, BitManipulationGetMostSignificantBit4BinarySearchComplete.GetMostSignificantBit(int.MaxValue));
        }
    }
}
