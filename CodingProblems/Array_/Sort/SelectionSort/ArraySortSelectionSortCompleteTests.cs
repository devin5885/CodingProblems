using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

// ReSharper disable once CheckNamespace
namespace CodingProblems.Array_.Sort
{
    /// <summary>
    /// Tests Sort.
    /// </summary>
    [TestClass]
    public class ArraySortSelectionSortCompleteTests
    {
        /// <summary>
        /// Tests an array with an even number of elements.
        /// </summary>
        [TestMethod]
        public void ArraySortSelectionSortCompleteTestSimpleEven()
        {
            var nums = new List<int> { 56, 3, 7, 23, 5, 7, 8, 38 };
            ArraySortSelectionSortComplete.Sort(nums);

            var numsResult = new List<int> { 3, 5, 7, 7, 8, 23, 38, 56 };
            CollectionAssert.AreEqual(nums, numsResult);
        }

        /// <summary>
        /// Tests an array with an odd number of elements.
        /// </summary>
        [TestMethod]
        public void ArraySortSelectionSortCompleteTestSimpleOdd()
        {
            var nums = new List<int> { 56, 3, 7, 23, 5, 8, 38 };
            ArraySortSelectionSortComplete.Sort(nums);

            var numsResult = new List<int> { 3, 5, 7, 8, 23, 38, 56 };
            CollectionAssert.AreEqual(nums, numsResult);
        }

        /// <summary>
        /// Tests an already sorted array.
        /// </summary>
        [TestMethod]
        public void ArraySortSelectionSortCompleteTestAlreadySorted()
        {
            var nums = new List<int> { 3, 5, 7, 7, 8, 23, 38, 56 };
            ArraySortSelectionSortComplete.Sort(nums);

            var numsResult = new List<int> { 3, 5, 7, 7, 8, 23, 38, 56 };
            CollectionAssert.AreEqual(nums, numsResult);
        }

        /// <summary>
        /// Tests an almost already sorted array.
        /// </summary>
        [TestMethod]
        public void ArraySortSelectionSortCompleteTestAlmostAlreadySorted()
        {
            var nums = new List<int> { 3, 5, 7, 7, 8, 38, 23, 56 };
            ArraySortSelectionSortComplete.Sort(nums);

            var numsResult = new List<int> { 3, 5, 7, 7, 8, 23, 38, 56 };
            CollectionAssert.AreEqual(nums, numsResult);
        }

        /// <summary>
        /// Tests an empty list.
        /// </summary>
        [TestMethod]
        public void ArraySortSelectionSortCompleteTestEmptyList()
        {
            var nums = new List<int>();
            ArraySortSelectionSortComplete.Sort(nums);

            var numsResult = new List<int>();
            CollectionAssert.AreEqual(nums, numsResult);
        }

        /// <summary>
        /// Tests an array with one element.
        /// </summary>
        [TestMethod]
        public void ArraySortSelectionSortCompleteTestSingleElement()
        {
            var nums = new List<int> { 3 };
            ArraySortSelectionSortComplete.Sort(nums);

            var numsResult = new List<int> { 3 };
            CollectionAssert.AreEqual(nums, numsResult);
        }

        /// <summary>
        /// Tests an array with two elements.
        /// </summary>
        [TestMethod]
        public void ArraySortSelectionSortCompleteTestTwoElements()
        {
            var nums = new List<int> { 5, 3 };
            ArraySortSelectionSortComplete.Sort(nums);

            var numsResult = new List<int> { 3, 5 };
            CollectionAssert.AreEqual(nums, numsResult);
        }

        /// <summary>
        /// Tests a null array.
        /// </summary>
        [TestMethod]
        public void ArraySortSelectionSortCompleteTestNullList()
        {
            try
            {
                ArraySortSelectionSortComplete.Sort(null);
            }
            catch
            {
                Assert.IsTrue(true);
                return;
            }
            Assert.Fail();
        }
    }
}
