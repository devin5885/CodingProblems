using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodingProblems.Array_.Merge
{
    /// <summary>
    /// This class tests Merge.
    /// </summary>
    [TestClass]
    public class ArrayMergeSorted1SimpleCompleteTests
    {
        /// <summary>
        /// Tests Merge with an array with an even number of elements.
        /// </summary>
        [TestMethod]
        public void ArrayMergeSorted1SimpleCompleteTestEven()
        {
            var nums1 = new List<int> { 3, 7, 23, 56 };
            var nums2 = new List<int> { 5, 7, 8, 38 };
            var nums = ArrayMergeSorted1SimpleComplete.Merge(nums1, nums2);

            var numsResult = new List<int> { 3, 5, 7, 7, 8, 23, 38, 56 };
            CollectionAssert.AreEqual(nums, numsResult);
        }

        /// <summary>
        /// Tests Merge with an array with an odd number of elements.
        /// </summary>
        [TestMethod]
        public void ArrayMergeSorted1SimpleCompleteTestOdd()
        {
            var nums1 = new List<int> { 3, 7, 23, 56 };
            var nums2 = new List<int> { 5, 7, 8 };
            var nums = ArrayMergeSorted1SimpleComplete.Merge(nums1, nums2);

            var numsResult = new List<int> { 3, 5, 7, 7, 8, 23, 56 };
            CollectionAssert.AreEqual(nums, numsResult);
        }

        /// <summary>
        /// Tests Merge with an array with two elements where the element in nums2 is less than nums2.
        /// </summary>
        [TestMethod]
        public void ArrayMergeSorted1SimpleCompleteTestTwoElements()
        {
            var nums1 = new List<int> { 3 };
            var nums2 = new List<int> { 7 };
            var nums = ArrayMergeSorted1SimpleComplete.Merge(nums1, nums2);

            var numsResult = new List<int> { 3, 7 };
            CollectionAssert.AreEqual(nums, numsResult);
        }

        /// <summary>
        /// Tests Merge with an array with two elements where the element in nums2 is less than nums1.
        /// </summary>
        [TestMethod]
        public void ArrayMergeSorted1SimpleCompleteTestTwoElementsReversed()
        {
            var nums1 = new List<int> { 7 };
            var nums2 = new List<int> { 3 };
            var nums = ArrayMergeSorted1SimpleComplete.Merge(nums1, nums2);

            var numsResult = new List<int> { 3, 7 };
            CollectionAssert.AreEqual(nums, numsResult);
        }

        /// <summary>
        /// Tests Merge with arrays with no elements.
        /// </summary>
        [TestMethod]
        public void ArrayMergeSorted1SimpleCompleteTestEmptyLists()
        {
            var nums1 = new List<int>();
            var nums2 = new List<int>();
            var nums = ArrayMergeSorted1SimpleComplete.Merge(nums1, nums2);

            var numsResult = new List<int>();
            CollectionAssert.AreEqual(nums, numsResult);
        }

        /// <summary>
        /// Tests Merge with an empty list 1.
        /// </summary>
        [TestMethod]
        public void ArrayMergeSorted1SimpleCompleteTestEmptyListList1()
        {
            var nums1 = new List<int>();
            var nums2 = new List<int> { 3 };
            var nums = ArrayMergeSorted1SimpleComplete.Merge(nums1, nums2);

            var numsResult = new List<int> { 3 };
            CollectionAssert.AreEqual(nums, numsResult);
        }

        /// <summary>
        /// Tests Merge with an empty list 2.
        /// </summary>
        [TestMethod]
        public void ArrayMergeSorted1SimpleCompleteTestEmptyListList2()
        {
            var nums1 = new List<int> { 3 };
            var nums2 = new List<int>();
            var nums = ArrayMergeSorted1SimpleComplete.Merge(nums1, nums2);

            var numsResult = new List<int> { 3 };
            CollectionAssert.AreEqual(nums, numsResult);
        }

        /// <summary>
        /// Tests two null arrays.
        /// </summary>
        [TestMethod]
        public void ArrayMergeSorted1SimpleCompleteTestNullLists()
        {
            try
            {
                ArrayMergeSorted1SimpleComplete.Merge(null, null);
            }
            catch (ArgumentException)
            {
                Assert.IsTrue(true);
                return;
            }
            Assert.Fail();
        }

        /// <summary>
        /// Tests a null array.
        /// </summary>
        [TestMethod]
        public void ArrayMergeSorted1SimpleCompleteTestNullListList1()
        {
            try
            {
                var nums2 = new List<int>();
                ArrayMergeSorted1SimpleComplete.Merge(null, nums2);
            }
            catch (ArgumentException)
            {
                Assert.IsTrue(true);
                return;
            }
            Assert.Fail();
        }

        /// <summary>
        /// Tests a null array.
        /// </summary>
        [TestMethod]
        public void ArrayMergeSorted1SimpleCompleteTestNullListList2()
        {
            try
            {
                var nums1 = new List<int>();
                ArrayMergeSorted1SimpleComplete.Merge(nums1, null);
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
