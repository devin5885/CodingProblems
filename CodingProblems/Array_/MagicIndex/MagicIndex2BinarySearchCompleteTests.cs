using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodingProblems.Array_.MagicIndex
{
    /// <summary>
    /// Tests MagicIndex2BinarySearchComplete.FindMagicIndex
    /// </summary>
    [TestClass]
    public class MagicIndex2BinarySearchCompleteTests
    {
        /// <summary>
        /// General test.
        /// </summary>
        [TestMethod]
        public void MagicIndex2BinarySearchCompleteTests1General()
        {
            Assert.AreEqual(7, MagicIndex2BinarySearchComplete.FindMagicIndex(new[] { -40, -20, -1, 1, 2, 3, 5, 7, 9, 12, 13 }));
        }

        /// <summary>
        /// NoMatch test.
        /// </summary>
        [TestMethod]
        public void MagicIndex2BinarySearchCompleteTests2NoMatch()
        {
            Assert.AreEqual(-1, MagicIndex2BinarySearchComplete.FindMagicIndex(new[] { -40, -20, -1, 1, 2, 3, 5, 8, 9, 12, 13 }));
        }

        /// <summary>
        /// Empty array test.
        /// </summary>
        [TestMethod]
        public void MagicIndex2BinarySearchCompleteTests3EmptyArray()
        {
            Assert.AreEqual(-1, MagicIndex2BinarySearchComplete.FindMagicIndex(Array.Empty<int>()));
        }

        /// <summary>
        /// Array with non-distinct items.
        /// </summary>
        [TestMethod]
        public void MagicIndex2BinarySearchCompleteTests4NonDistinct()
        {
            try
            {
                MagicIndex2BinarySearchComplete.FindMagicIndex(new[] { -10, -5, 2, 2, 2, 3, 4, 8, 9, 12, 13 });
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