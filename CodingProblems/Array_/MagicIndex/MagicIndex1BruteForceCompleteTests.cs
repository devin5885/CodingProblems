using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodingProblems.Array_.MagicIndex
{
    /// <summary>
    /// Tests MagicIndex1BruteForceComplete.FindMagicIndex
    /// </summary>
    [TestClass]
    public class MagicIndex1BruteForceCompleteTests
    {
        /// <summary>
        /// General test.
        /// </summary>
        [TestMethod]
        public void MagicIndex1BruteForceCompleteTests1General()
        {
            Assert.AreEqual(7, MagicIndex1BruteForceComplete.FindMagicIndex(new[] { -40, -20, -1, 1, 2, 3, 5, 7, 9, 12, 13 }));
        }

        /// <summary>
        /// NoMatch test.
        /// </summary>
        [TestMethod]
        public void MagicIndex1BruteForceCompleteTests2NoMatch()
        {
            Assert.AreEqual(-1, MagicIndex1BruteForceComplete.FindMagicIndex(new[] { -40, -20, -1, 1, 2, 3, 5, 8, 9, 12, 13 }));
        }

        /// <summary>
        /// Empty array test.
        /// </summary>
        [TestMethod]
        public void MagicIndex1BruteForceCompleteTests3EmptyArray()
        {
            Assert.AreEqual(-1, MagicIndex1BruteForceComplete.FindMagicIndex(new int[0]));
        }

        /// <summary>
        /// Array with non-distinct items.
        /// </summary>
        [TestMethod]
        public void MagicIndex1BruteForceCompleteTests4NonDistinct()
        {
            Assert.AreEqual(2, MagicIndex1BruteForceComplete.FindMagicIndex(new[] { -10, -5, 2, 2, 2, 3, 4, 8, 9, 12, 13 }));
        }
    }
}