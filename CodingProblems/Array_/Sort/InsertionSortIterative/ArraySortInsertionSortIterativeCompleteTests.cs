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
    public class ArraySortInsertionSortIterativeCompleteTests
    {
        /// <summary>
        /// Tests an array with an even number of elements.
        /// </summary>
        [TestMethod]
        public void ArraySortInsertionSortIterativeCompleteTestSimpleEven()
        {
            var nums = new List<int> { 56, 3, 7, 23, 5, 7, 8, 38 };
            ArraySortInsertionSortIterativeComplete.Sort(nums);

            var numsResult = new List<int> { 3, 5, 7, 7, 8, 23, 38, 56 };
            CollectionAssert.AreEqual(nums, numsResult);
        }

        /// <summary>
        /// Tests an array with an odd number of elements.
        /// </summary>
        [TestMethod]
        public void ArraySortInsertionSortIterativeCompleteTestSimpleOdd()
        {
            var nums = new List<int> { 56, 3, 7, 23, 5, 8, 38 };
            ArraySortInsertionSortIterativeComplete.Sort(nums);

            var numsResult = new List<int> { 3, 5, 7, 8, 23, 38, 56 };
            CollectionAssert.AreEqual(nums, numsResult);
        }

        /// <summary>
        /// Tests an already sorted array.
        /// </summary>
        [TestMethod]
        public void ArraySortInsertionSortIterativeCompleteTestAlreadySorted()
        {
            var nums = new List<int> { 3, 5, 7, 7, 8, 23, 38, 56 };
            ArraySortInsertionSortIterativeComplete.Sort(nums);

            var numsResult = new List<int> { 3, 5, 7, 7, 8, 23, 38, 56 };
            CollectionAssert.AreEqual(nums, numsResult);
        }

        /// <summary>
        /// Tests an almost already sorted array.
        /// </summary>
        [TestMethod]
        public void ArraySortInsertionSortIterativeCompleteTestAlmostAlreadySorted()
        {
            var nums = new List<int> { 3, 5, 7, 7, 8, 38, 23, 56 };
            ArraySortInsertionSortIterativeComplete.Sort(nums);

            var numsResult = new List<int> { 3, 5, 7, 7, 8, 23, 38, 56 };
            CollectionAssert.AreEqual(nums, numsResult);
        }

        /// <summary>
        /// Tests an empty list.
        /// </summary>
        [TestMethod]
        public void ArraySortInsertionSortIterativeCompleteTestEmptyList()
        {
            var nums = new List<int>();
            ArraySortInsertionSortIterativeComplete.Sort(nums);

            var numsResult = new List<int>();
            CollectionAssert.AreEqual(nums, numsResult);
        }

        /// <summary>
        /// Tests an array with one element.
        /// </summary>
        [TestMethod]
        public void ArraySortInsertionSortIterativeCompleteTestSingleElement()
        {
            var nums = new List<int> { 3 };
            ArraySortInsertionSortIterativeComplete.Sort(nums);

            var numsResult = new List<int> { 3 };
            CollectionAssert.AreEqual(nums, numsResult);
        }

        /// <summary>
        /// Tests an array with two elements.
        /// </summary>
        [TestMethod]
        public void ArraySortInsertionSortIterativeCompleteTestTwoElements()
        {
            var nums = new List<int> { 5, 3 };
            ArraySortInsertionSortIterativeComplete.Sort(nums);

            var numsResult = new List<int> { 3, 5 };
            CollectionAssert.AreEqual(nums, numsResult);
        }

        /// <summary>
        /// Tests a null array.
        /// </summary>
        [TestMethod]
        public void ArraySortInsertionSortIterativeCompleteTestNullList()
        {
            try
            {
                ArraySortInsertionSortIterativeComplete.Sort(null);
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
