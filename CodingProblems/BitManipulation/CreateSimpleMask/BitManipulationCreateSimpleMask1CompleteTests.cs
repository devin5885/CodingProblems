using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodingProblems.BitManipulation.CreateSimpleMask
{
    /// <summary>
    /// Tests BitManipulationCreateSimpleMaskComplete in various scenarios.
    /// </summary>
    [TestClass]
    public class BitManipulationCreateSimpleMask1CompleteTests
    {
        /// <summary>
        /// Standard tests.
        /// </summary>
        [TestMethod]
        public void BitManipulationCreateMask1CompleteTest1()
        {
            // Various masks.
            Assert.AreEqual(Convert.ToInt32("11111111111111111111111111111111", 2), BitManipulationCreateSimpleMask1Complete.CreateSimpleMask(31, 0));
            Assert.AreEqual(Convert.ToInt32("11111111111111111111111111111110", 2), BitManipulationCreateSimpleMask1Complete.CreateSimpleMask(31, 1));
            Assert.AreEqual(Convert.ToInt32("00000000000000000000000000000001", 2), BitManipulationCreateSimpleMask1Complete.CreateSimpleMask(0, 0));
            Assert.AreEqual(Convert.ToInt32("00000000000000000000000000000011", 2), BitManipulationCreateSimpleMask1Complete.CreateSimpleMask(1, 0));
            Assert.AreEqual(Convert.ToInt32("00000000000000000000000000000010", 2), BitManipulationCreateSimpleMask1Complete.CreateSimpleMask(1, 1));
            Assert.AreEqual(Convert.ToInt32("00000000000011111111000000000000", 2), BitManipulationCreateSimpleMask1Complete.CreateSimpleMask(19, 12));
            Assert.AreEqual(Convert.ToInt32("11100000000000000000000000000000", 2), BitManipulationCreateSimpleMask1Complete.CreateSimpleMask(31, 29));
            Assert.AreEqual(Convert.ToInt32("00000111100000000000000000000000", 2), BitManipulationCreateSimpleMask1Complete.CreateSimpleMask(26, 23));

            // Special case, 0 mask.
            Assert.AreEqual(Convert.ToInt32("00000000000000000000000000000000", 2), ~BitManipulationCreateSimpleMask1Complete.CreateSimpleMask(31, 0));
        }

        /// <summary>
        /// Test an invalid first parameter.
        /// </summary>
        [TestMethod]
        public void BitManipulationCreateMask1CompleteTest2ErrorFirstParameterInvalid()
        {
            try
            {
                BitManipulationCreateSimpleMask1Complete.CreateSimpleMask(32, 0);
            }
            catch (ArgumentException)
            {
                Assert.IsTrue(true);
                return;
            }
            Assert.Fail();
        }

        /// <summary>
        /// Tests an invalid second parameter.
        /// </summary>
        [TestMethod]
        public void BitManipulationCreateMask1CompleteTest3ErrorSecondParameterInvalid()
        {
            try
            {
                BitManipulationCreateSimpleMask1Complete.CreateSimpleMask(31, -1);
            }
            catch (ArgumentException)
            {
                Assert.IsTrue(true);
                return;
            }
            Assert.Fail();
        }

        /// <summary>
        /// Tests the second parameter larger than the first.
        /// </summary>
        [TestMethod]
        public void BitManipulationCreateMask1CompleteTest4ErrorSecondParameterLarger()
        {
            try
            {
                BitManipulationCreateSimpleMask1Complete.CreateSimpleMask(10, 12);
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
