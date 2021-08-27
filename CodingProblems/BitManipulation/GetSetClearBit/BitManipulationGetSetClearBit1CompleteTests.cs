using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodingProblems.BitManipulation.GetSetClearBit
{
    /// <summary>
    /// Tests BitManipulationGetSetClearBit1Complete
    /// </summary>
    [TestClass]
    public class BitManipulationGetSetClearBit1CompleteTests
    {
        /// <summary>
        /// Tests BitManipulationGetBit
        /// </summary>
        [TestMethod]
        public void BitManipulationGetBit1CompleteTest1()
        {
            // 0 (0000_0000_0000_0000_0000_0000_0000_0000)
            for (var index = 0; index < sizeof(int) * 8; index++)
                Assert.AreEqual(false, BitManipulationGetSetClearBit1Complete.GetBit(0, index));

            // Positive

            // 1 (0000_0000_0000_0000_0000_0000_0000_0001)
            for (var index = 0; index < sizeof(int) * 8; index++)
                Assert.AreEqual(index == 0, BitManipulationGetSetClearBit1Complete.GetBit(1, index));

            // 2 (0000_0000_0000_0000_0000_0000_0000_0010)
            for (var index = 0; index < sizeof(int) * 8; index++)
                Assert.AreEqual(index == 1, BitManipulationGetSetClearBit1Complete.GetBit(2, index));

            // 5340 (Random #) (0000_0000_0000_0000_‭0001_0100_1101_1100‬)
            for (var index = 0; index < sizeof(int) * 8; index++)
            {
                var expected = index == 2 || index == 3 || index == 4 || index == 6 || index == 7 || index == 10 || index == 12;
                Assert.AreEqual(expected, BitManipulationGetSetClearBit1Complete.GetBit(5340, index));
            }

            // MaxValue - 1 (0111_1111_1111_1111_1111_1111_1111_1110)
            for (var index = 0; index < sizeof(int) * 8; index++)
                Assert.AreEqual(index != 31 && index != 0, BitManipulationGetSetClearBit1Complete.GetBit(int.MaxValue - 1, index));

            // MaxValue (0111_1111_1111_1111_1111_1111_1111_1111)
            for (var index = 0; index < sizeof(int) * 8; index++)
                Assert.AreEqual(index != 31, BitManipulationGetSetClearBit1Complete.GetBit(int.MaxValue, index));

            // Negative

            // -1 (1111_1111_1111_1111_1111_1111_1111_1111)
            for (var index = 0; index < sizeof(int) * 8; index++)
                Assert.AreEqual(true, BitManipulationGetSetClearBit1Complete.GetBit(-1, index));

            // -2 (1111_1111_1111_1111_1111_1111_1111_1110)
            for (var index = 0; index < sizeof(int) * 8; index++)
                Assert.AreEqual(index != 0, BitManipulationGetSetClearBit1Complete.GetBit(-2, index));

            // MinValue (-2147483648) (1000_0000_0000_0000_0000_0000_0000_0000)
            for (var index = 0; index < sizeof(int) * 8; index++)
                Assert.AreEqual(index == 31, BitManipulationGetSetClearBit1Complete.GetBit(int.MinValue, index));

            // MinValue + 1 (1000_0000_0000_0000_0000_0000_0000_0001)
            for (var index = 0; index < sizeof(int) * 8; index++)
                Assert.AreEqual(index == 31 || index == 0, BitManipulationGetSetClearBit1Complete.GetBit(int.MinValue + 1, index));

            // -2147360217 (Random #) (1000_0000_0000_0001_1110_0010_0010_0111)
            for (var index = 0; index < sizeof(int) * 8; index++)
            {
                var expected = index == 0 || index == 1 || index == 2 || index == 5 || index == 9 || index == 13 || index == 14 || index == 15 || index == 16 || index == 31;
                Assert.AreEqual(expected, BitManipulationGetSetClearBit1Complete.GetBit(-2147360217, index));
            }
        }

        /// <summary>
        /// Tests BitManipulationSetClearBit
        /// </summary>
        [TestMethod]
        public void BitManipulationSetClearBit1CompleteTest1()
        {
            // Start with 0.
            var value = 0;

            // Set some bits.
            value = BitManipulationGetSetClearBit1Complete.SetClearBit(value, 2);
            value = BitManipulationGetSetClearBit1Complete.SetClearBit(value, 3);
            value = BitManipulationGetSetClearBit1Complete.SetClearBit(value, 4);
            value = BitManipulationGetSetClearBit1Complete.SetClearBit(value, 6);
            value = BitManipulationGetSetClearBit1Complete.SetClearBit(value, 7);
            value = BitManipulationGetSetClearBit1Complete.SetClearBit(value, 10);
            value = BitManipulationGetSetClearBit1Complete.SetClearBit(value, 12);

            // Check value.
            Assert.AreEqual(5340, value);

            // 5340 (Random #) (0000_0000_0000_0000_‭0001_0100_1101_1100‬)
            for (var index = 0; index < sizeof(int) * 8; index++)
            {
                var expected = index == 2 || index == 3 || index == 4 || index == 6 || index == 7 || index == 10 || index == 12;
                Assert.AreEqual(expected, BitManipulationGetSetClearBit1Complete.GetBit(value, index));
            }

            // Reset the bits.
            value = BitManipulationGetSetClearBit1Complete.SetClearBit(value, 2, false);
            value = BitManipulationGetSetClearBit1Complete.SetClearBit(value, 3, false);
            value = BitManipulationGetSetClearBit1Complete.SetClearBit(value, 4, false);
            value = BitManipulationGetSetClearBit1Complete.SetClearBit(value, 6, false);
            value = BitManipulationGetSetClearBit1Complete.SetClearBit(value, 7, false);
            value = BitManipulationGetSetClearBit1Complete.SetClearBit(value, 10, false);
            value = BitManipulationGetSetClearBit1Complete.SetClearBit(value, 12, false);

            // Check value.
            Assert.AreEqual(0, value);
        }

        /// <summary>
        /// Tests BitManipulationSetClearBit
        /// </summary>
        [TestMethod]
        public void BitManipulationSetClearBit1CompleteTest2()
        {
            // Start with -1 (1111_1111_1111_1111_1111_1111_1111_1111)
            var value = -1;

            // Clear some bits.
            value = BitManipulationGetSetClearBit1Complete.SetClearBit(value, 3, false);
            value = BitManipulationGetSetClearBit1Complete.SetClearBit(value, 4, false);
            value = BitManipulationGetSetClearBit1Complete.SetClearBit(value, 6, false);
            value = BitManipulationGetSetClearBit1Complete.SetClearBit(value, 8, false);
            value = BitManipulationGetSetClearBit1Complete.SetClearBit(value, 11, false);
            value = BitManipulationGetSetClearBit1Complete.SetClearBit(value, 17, false);
            value = BitManipulationGetSetClearBit1Complete.SetClearBit(value, 18, false);
            value = BitManipulationGetSetClearBit1Complete.SetClearBit(value, 28, false);
            value = BitManipulationGetSetClearBit1Complete.SetClearBit(value, 29, false);

            // Check value.
            Assert.AreEqual(-805701977, value);

            // -805701977 (Random #) (1100_1111_1111_1001_1111_0110_1010_0111)
            for (var index = 0; index < sizeof(int) * 8; index++)
            {
                var expected = index != 3 && index != 4 && index != 6 && index != 8 && index != 11 && index != 17 && index != 18 && index != 28 && index != 29;
                Assert.AreEqual(expected, BitManipulationGetSetClearBit1Complete.GetBit(value, index));
            }

            // Set same bits.
            value = BitManipulationGetSetClearBit1Complete.SetClearBit(value, 3);
            value = BitManipulationGetSetClearBit1Complete.SetClearBit(value, 4);
            value = BitManipulationGetSetClearBit1Complete.SetClearBit(value, 6);
            value = BitManipulationGetSetClearBit1Complete.SetClearBit(value, 8);
            value = BitManipulationGetSetClearBit1Complete.SetClearBit(value, 11);
            value = BitManipulationGetSetClearBit1Complete.SetClearBit(value, 17);
            value = BitManipulationGetSetClearBit1Complete.SetClearBit(value, 18);
            value = BitManipulationGetSetClearBit1Complete.SetClearBit(value, 28);
            value = BitManipulationGetSetClearBit1Complete.SetClearBit(value, 29);
            value = BitManipulationGetSetClearBit1Complete.SetClearBit(value, 31);

            // Check value.
            Assert.AreEqual(-1, value);
        }
    }
}
