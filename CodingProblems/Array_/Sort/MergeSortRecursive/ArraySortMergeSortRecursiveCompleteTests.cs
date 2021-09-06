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
    public class ArraySortMergeSortRecursiveCompleteTests
    {
        /// <summary>
        /// Tests an array with an even number of elements.
        /// </summary>
        [TestMethod]
        public void ArraySortMergeSortSimpleCompleteTestSimpleEven()
        {
            var nums = new List<int> { 56, 3, 7, 23, 5, 7, 8, 38 };
            ArraySortMergeSortRecursiveComplete.Sort(nums);

            var numsResult = new List<int> { 3, 5, 7, 7, 8, 23, 38, 56 };
            CollectionAssert.AreEqual(nums, numsResult);
        }

        /// <summary>
        /// Tests an array with an odd number of elements.
        /// </summary>
        [TestMethod]
        public void ArraySortMergeSortSimpleCompleteTestSimpleOdd()
        {
            var nums = new List<int> { 56, 3, 7, 23, 5, 8, 38 };
            ArraySortMergeSortRecursiveComplete.Sort(nums);

            var numsResult = new List<int> { 3, 5, 7, 8, 23, 38, 56 };
            CollectionAssert.AreEqual(nums, numsResult);
        }

        /// <summary>
        /// Tests an already sorted array.
        /// </summary>
        [TestMethod]
        public void ArraySortMergeSortSimpleCompleteTestAlreadySorted()
        {
            var nums = new List<int> { 3, 5, 7, 7, 8, 23, 38, 56 };
            ArraySortMergeSortRecursiveComplete.Sort(nums);

            var numsResult = new List<int> { 3, 5, 7, 7, 8, 23, 38, 56 };
            CollectionAssert.AreEqual(nums, numsResult);
        }

        /// <summary>
        /// Tests an almost already sorted array.
        /// </summary>
        [TestMethod]
        public void ArraySorMergeSortSimpleCompleteTestAlmostAlreadySorted()
        {
            var nums = new List<int> { 3, 5, 7, 7, 8, 38, 23, 56 };
            ArraySortMergeSortRecursiveComplete.Sort(nums);

            var numsResult = new List<int> { 3, 5, 7, 7, 8, 23, 38, 56 };
            CollectionAssert.AreEqual(nums, numsResult);
        }

        /// <summary>
        /// Tests an empty list.
        /// </summary>
        [TestMethod]
        public void ArraySortMergeSortSimpleCompleteTestEmptyList()
        {
            var nums = new List<int>();
            ArraySortMergeSortRecursiveComplete.Sort(nums);

            var numsResult = new List<int>();
            CollectionAssert.AreEqual(nums, numsResult);
        }

        /// <summary>
        /// Tests an array with one element.
        /// </summary>
        [TestMethod]
        public void ArraySortMergeSortSimpleCompleteTestSingleElement()
        {
            var nums = new List<int> { 3 };
            ArraySortMergeSortRecursiveComplete.Sort(nums);

            var numsResult = new List<int> { 3 };
            CollectionAssert.AreEqual(nums, numsResult);
        }

        /// <summary>
        /// Tests an array with two elements.
        /// </summary>
        [TestMethod]
        public void ArraySortMergeSortSimpleCompleteTestTwoElements()
        {
            var nums = new List<int> { 5, 3 };
            ArraySortMergeSortRecursiveComplete.Sort(nums);

            var numsResult = new List<int> { 3, 5 };
            CollectionAssert.AreEqual(nums, numsResult);
        }

        /// <summary>
        /// Tests a null array.
        /// </summary>
        [TestMethod]
        public void ArraySortMergeSortSimpleCompleteTestNullList()
        {
            try
            {
                ArraySortMergeSortRecursiveComplete.Sort(null);
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
