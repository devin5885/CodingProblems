using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodingProblems.Array_.PowerSet
{
    /// <summary>
    /// Tests PowerSet1RecursiveComplete.GetPowerSet
    /// </summary>
    [TestClass]
    public class PowerSet1RecursiveCompleteTests
    {
        /// <summary>
        /// Empty set.
        /// </summary>
        [TestMethod]
        public void PowerSet1RecursiveCompleteTests1EmptySet()
        {
            var expected = new List<List<int>>
            {
                new List<int>()
            };
            var actual = PowerSet1RecursiveComplete.GetPowerSet(Array.Empty<int>());

            Assert.AreEqual(actual.Count, expected.Count);
            for (var i = 0; i < expected.Count; i++)
                CollectionAssert.AreEqual(expected[i], actual[i]);
        }

        /// <summary>
        /// One item.
        /// </summary>
        [TestMethod]
        public void PowerSet1RecursiveCompleteTests1OneItem()
        {
            var expected = new List<List<int>>
            {
                new List<int>(),
                new List<int>() { 1 }
            };
            var actual = PowerSet1RecursiveComplete.GetPowerSet(new[] { 1 });

            Assert.AreEqual(actual.Count, expected.Count);
            for (var i = 0; i < expected.Count; i++)
                CollectionAssert.AreEqual(expected[i], actual[i]);
        }

        /// <summary>
        /// Two items.
        /// </summary>
        [TestMethod]
        public void PowerSet1RecursiveCompleteTests1TwoItems()
        {
            var expected = new List<List<int>>
            {
                new List<int>(),
                new List<int>() { 1 },
                new List<int>() { 2 },
                new List<int>() { 1, 2 }
            };
            var actual = PowerSet1RecursiveComplete.GetPowerSet(new[] { 1, 2 });

            Assert.AreEqual(actual.Count, expected.Count);
            for (var i = 0; i < expected.Count; i++)
                CollectionAssert.AreEqual(expected[i], actual[i]);
        }

        /// <summary>
        /// Three items.
        /// </summary>
        [TestMethod]
        public void PowerSet1RecursiveCompleteTests1ThreeItems()
        {
            var expected = new List<List<int>>
            {
                new List<int>(),
                new List<int>() { 1 },
                new List<int>() { 2 },
                new List<int>() { 1, 2 },
                new List<int>() { 3 },
                new List<int>() { 1, 3 },
                new List<int>() { 2, 3 },
                new List<int>() { 1, 2, 3 }
            };
            var actual = PowerSet1RecursiveComplete.GetPowerSet(new[] { 1, 2, 3 });

            Assert.AreEqual(actual.Count, expected.Count);
            for (var i = 0; i < expected.Count; i++)
                CollectionAssert.AreEqual(expected[i], actual[i]);
        }
    }
}