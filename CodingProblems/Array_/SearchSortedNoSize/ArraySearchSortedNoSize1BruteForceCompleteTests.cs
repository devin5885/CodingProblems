using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodingProblems.Array_.SearchSortedNoSize
{
    /// <summary>
    /// This class tests Search
    /// </summary>
    [TestClass]
    public class ArraySearchSortedNoSize1BruteForceCompleteTests
    {
        /// <summary>
        /// Tests the value to find is within the array.
        /// </summary>
        [TestMethod]
        public void ArraySearchSortedNoSize1BruteForceCompleteTestValueFound1()
        {
            var listy = new Listy(new[] { 3, 5, 7, 7, 8, 23, 38, 56 });
            Assert.AreEqual(4, ArraySearchSortedNoSize1BruteForceComplete.Search(listy, 8));
        }

        /// <summary>
        /// Tests the value to find is within the array.
        /// </summary>
        [TestMethod]
        public void ArraySearchSortedNoSize1BruteForceCompleteTestValueFound2()
        {
            var listy = new Listy(new[] { 3, 5, 7, 7, 8, 23, 38, 56 });
            Assert.AreEqual(5, ArraySearchSortedNoSize1BruteForceComplete.Search(listy, 23));
        }

        /// <summary>
        /// Tests the value to find is not in the array.
        /// </summary>
        [TestMethod]
        public void ArraySearchSortedNoSize1BruteForceCompleteTestValueNotFound()
        {
            var listy = new Listy(new[] { 3, 5, 7, 7, 8, 23, 38, 56 });
            Assert.AreEqual(-1, ArraySearchSortedNoSize1BruteForceComplete.Search(listy, 100));
        }

        /// <summary>
        /// Tests an array with one element found.
        /// </summary>
        [TestMethod]
        public void ArraySearchSortedNoSize1BruteForceCompleteTestOneElementFound()
        {
            var listy = new Listy(new[] { 3 });
            Assert.AreEqual(0, ArraySearchSortedNoSize1BruteForceComplete.Search(listy, 3));
        }

        /// <summary>
        /// Tests an array with one element not found.
        /// </summary>
        [TestMethod]
        public void ArraySearchSortedNoSize1BruteForceCompleteTestOneElementNotFound()
        {
            var listy = new Listy(new[] { 3 });
            Assert.AreEqual(-1, ArraySearchSortedNoSize1BruteForceComplete.Search(listy, 23));
        }

        /// <summary>
        /// Tests an empty list.
        /// </summary>
        [TestMethod]
        public void ArraySearchSortedNoSize1BruteForceCompleteTestEmptyLists()
        {
            var listy = new Listy(Array.Empty<int>());
            Assert.AreEqual(-1, ArraySearchSortedNoSize1BruteForceComplete.Search(listy, 23));
        }

        /// <summary>
        /// Tests a null array.
        /// </summary>
        [TestMethod]
        public void ArraySearchSortedNoSize1BruteForceCompleteTestNullArray()
        {
            try
            {
                ArraySearchSortedNoSize1BruteForceComplete.Search(null, 23);
            }
            catch (ArgumentException)
            {
                Assert.IsTrue(true);
                return;
            }
            Assert.Fail();
        }

        /// <summary>
        /// Tests a negative index.
        /// </summary>
        [TestMethod]
        public void ArraySearchSortedNoSize1BruteForceCompleteTestNegativeIndex()
        {
            try
            {
                var listy = new Listy(new[] { 3, 5, 7, 7, 8, 23, 38, 56 });
                ArraySearchSortedNoSize1BruteForceComplete.Search(listy, -2);
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
