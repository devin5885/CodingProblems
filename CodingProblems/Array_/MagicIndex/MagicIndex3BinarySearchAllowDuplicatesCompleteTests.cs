using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodingProblems.Array_.MagicIndex
{
    /// <summary>
    /// Tests MagicIndex3BinarySearchAllowDuplicatesComplete.FindMagicIndex
    /// </summary>
    [TestClass]
    public class MagicIndex3BinarySearchAllowDuplicatesCompleteTests
    {
        /// <summary>
        /// General test.
        /// </summary>
        [TestMethod]
        public void MagicIndex3BinarySearchAllowDuplicatesCompleteTest1General()
        {
            Assert.AreEqual(7, MagicIndex3BinarySearchAllowDuplicatesComplete.FindMagicIndex(new[] { -40, -20, -1, 1, 2, 3, 5, 7, 9, 12, 13 }));
        }

        /// <summary>
        /// NoMatch test.
        /// </summary>
        [TestMethod]
        public void MagicIndex3BinarySearchAllowDuplicatesCompleteTest2NoMatch()
        {
            Assert.AreEqual(-1, MagicIndex3BinarySearchAllowDuplicatesComplete.FindMagicIndex(new[] { -40, -20, -1, 1, 2, 3, 5, 8, 9, 12, 13 }));
        }

        /// <summary>
        /// Empty array test.
        /// </summary>
        [TestMethod]
        public void MagicIndex3BinarySearchAllowDuplicatesCompleteTest3EmptyArray()
        {
            Assert.AreEqual(-1, MagicIndex3BinarySearchAllowDuplicatesComplete.FindMagicIndex(new int[0]));
        }

        /// <summary>
        /// Array with non-distinct items.
        /// </summary>
        [TestMethod]
        public void MagicIndex3BinarySearchAllowDuplicatesCompleteTest4NonDistinct()
        {
            Assert.AreEqual(2, MagicIndex3BinarySearchAllowDuplicatesComplete.FindMagicIndex(new[] { -10, -5, 2, 2, 2, 3, 4, 8, 9, 12, 13 }));
        }
    }
}