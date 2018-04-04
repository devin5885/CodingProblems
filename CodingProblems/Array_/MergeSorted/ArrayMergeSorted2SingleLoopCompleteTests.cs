using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodingProblems.Array_.MergeSorted
{
    /// <summary>
    /// This class tests Merge.
    /// </summary>
    [TestClass]
    public class ArrayMergeSorted2SingleLoopCompleteTests
    {
        /// <summary>
        /// Tests Merge with an array with an even number of elements.
        /// </summary>
        [TestMethod]
        public void ArrayMergeSorted2SingleLoopCompleteTestEven()
        {
            var nums1 = new List<int> { 3, 7, 23, 56 };
            var nums2 = new List<int> { 5, 7, 8, 38 };
            var nums = ArrayMergeSorted2SingleLoopComplete.Merge(nums1, nums2);

            var numsResult = new[] { 3, 5, 7, 7, 8, 23, 38, 56 };
            CollectionAssert.AreEqual(nums, numsResult);
        }

        /// <summary>
        /// Tests Merge with an array with an odd number of elements.
        /// </summary>
        [TestMethod]
        public void ArrayMergeSorted2SingleLoopCompleteTestOdd()
        {
            var nums1 = new List<int> { 3, 7, 23, 56 };
            var nums2 = new List<int> { 5, 7, 8 };
            var nums = ArrayMergeSorted2SingleLoopComplete.Merge(nums1, nums2);

            var numsResult = new[] { 3, 5, 7, 7, 8, 23, 56 };
            CollectionAssert.AreEqual(nums, numsResult);
        }

        /// <summary>
        /// Tests Merge with an array with two elements where the element in nums2 is less than nums2.
        /// </summary>
        [TestMethod]
        public void ArrayMergeSorted2SingleLoopCompleteTestTwoElements()
        {
            var nums1 = new List<int> { 3 };
            var nums2 = new List<int> { 7 };
            var nums = ArrayMergeSorted2SingleLoopComplete.Merge(nums1, nums2);

            var numsResult = new[] { 3, 7 };
            CollectionAssert.AreEqual(nums, numsResult);
        }

        /// <summary>
        /// Tests Merge with an array with two elements where the element in nums2 is less than nums1.
        /// </summary>
        [TestMethod]
        public void ArrayMergeSorted2SingleLoopCompleteTestTwoElementsReversed()
        {
            var nums1 = new List<int> { 7 };
            var nums2 = new List<int> { 3 };
            var nums = ArrayMergeSorted2SingleLoopComplete.Merge(nums1, nums2);

            var numsResult = new[] { 3, 7 };
            CollectionAssert.AreEqual(nums, numsResult);
        }

        /// <summary>
        /// Tests Merge with arrays with no elements.
        /// </summary>
        [TestMethod]
        public void ArrayMergeSorted2SingleLoopCompleteTestEmptyLists()
        {
            var nums1 = new List<int>();
            var nums2 = new List<int>();
            var nums = ArrayMergeSorted2SingleLoopComplete.Merge(nums1, nums2);

            var numsResult = new List<int>();
            CollectionAssert.AreEqual(nums, numsResult);
        }

        /// <summary>
        /// Tests Merge with an empty list 1.
        /// </summary>
        [TestMethod]
        public void ArrayMergeSorted2SingleLoopCompleteTestEmptyListList1()
        {
            var nums1 = new List<int>();
            var nums2 = new List<int> { 3 };
            var nums = ArrayMergeSorted2SingleLoopComplete.Merge(nums1, nums2);

            var numsResult = new List<int> { 3 };
            CollectionAssert.AreEqual(nums, numsResult);
        }

        /// <summary>
        /// Tests Merge with an empty list 2.
        /// </summary>
        [TestMethod]
        public void ArrayMergeSorted2SingleLoopCompleteTestEmptyListList2()
        {
            var nums1 = new List<int> { 3 };
            var nums2 = new List<int>();
            var nums = ArrayMergeSorted2SingleLoopComplete.Merge(nums1, nums2);

            var numsResult = new List<int> { 3 };
            CollectionAssert.AreEqual(nums, numsResult);
        }

        /// <summary>
        /// Tests two null arrays.
        /// </summary>
        [TestMethod]
        public void ArrayMergeSorted2SingleLoopCompleteTestNullLists()
        {
            try
            {
                ArrayMergeSorted2SingleLoopComplete.Merge(null, null);
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
        public void ArrayMergeSorted2SingleLoopCompleteTestNullListList1()
        {
            try
            {
                var nums2 = new List<int>();
                ArrayMergeSorted2SingleLoopComplete.Merge(null, nums2);
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
        public void ArrayMergeSorted2SingleLoopCompleteTestNullListList2()
        {
            try
            {
                var nums1 = new List<int>();
                ArrayMergeSorted2SingleLoopComplete.Merge(nums1, null);
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
