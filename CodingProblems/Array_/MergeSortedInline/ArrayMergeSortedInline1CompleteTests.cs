using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodingProblems.Array_.MergeSortedInline
{
    /// <summary>
    /// This class tests Merge.
    /// </summary>
    [TestClass]
    public class ArrayMergeSortedInline1CompleteTests
    {
        /// <summary>
        /// Tests Merge with an array with an even number of elements.
        /// </summary>
        [TestMethod]
        public void ArrayMergeSortedInline1SimpleCompleteTestEven()
        {
            var a = new[] { 3, 7, 23, 56, 0, 0, 0, 0 };
            var b = new[] { 5, 7, 8, 38 };
            ArrayMergeSortedInline1Complete.Merge(a, 4, b);

            var aExpected = new[] { 3, 5, 7, 7, 8, 23, 38, 56 };
            CollectionAssert.AreEqual(aExpected, a);
        }

        /// <summary>
        /// Tests Merge with an array with an odd number of elements.
        /// </summary>
        [TestMethod]
        public void ArrayMergeSortedInline1CompleteTestOdd()
        {
            var a = new[] { 3, 7, 23, 56, 0, 0, 0 };
            var b = new[] { 5, 7, 8 };
            ArrayMergeSortedInline1Complete.Merge(a, 4, b);

            var aExpected = new[] { 3, 5, 7, 7, 8, 23, 56 };
            CollectionAssert.AreEqual(aExpected, a);
        }

        /// <summary>
        /// Tests Merge with an array with two elements where the element in nums2 is less than nums2.
        /// </summary>
        [TestMethod]
        public void ArrayMergeSortedInline1CompleteTestTwoElements()
        {
            var a = new[] { 3, 0 };
            var b = new[] { 7 };
            ArrayMergeSortedInline1Complete.Merge(a, 1, b);

            var aExpected = new[] { 3, 7 };
            CollectionAssert.AreEqual(aExpected, a);
        }

        /// <summary>
        /// Tests Merge with an array with two elements where the element in nums2 is less than nums1.
        /// </summary>
        [TestMethod]
        public void ArrayMergeSortedInline1CompleteTestTwoElementsReversed()
        {
            var a = new[] { 7, 0 };
            var b = new[] { 3 };
            ArrayMergeSortedInline1Complete.Merge(a, 1, b);

            var aExpected = new[] { 3, 7 };
            CollectionAssert.AreEqual(aExpected, a);
        }

        /// <summary>
        /// Tests Merge with arrays with no elements.
        /// </summary>
        [TestMethod]
        public void ArrayMergeSortedInline1CompleteTestEmptyLists()
        {
            var a = new int[0];
            var b = new int[0];
            ArrayMergeSortedInline1Complete.Merge(a, 0, b);

            var aExpected = new int[0];
            CollectionAssert.AreEqual(aExpected, a);
        }

        /// <summary>
        /// Tests Merge with an empty list 1.
        /// </summary>
        [TestMethod]
        public void ArrayMergeSortedInline1CompleteTestEmptyListList1()
        {
            var a = new int[1];
            var b = new[] { 3 };
            ArrayMergeSortedInline1Complete.Merge(a, 0, b);

            var aExpected = new[] { 3 };
            CollectionAssert.AreEqual(aExpected, a);
        }

        /// <summary>
        /// Tests Merge with an empty list 2.
        /// </summary>
        [TestMethod]
        public void ArrayMergeSortedInline1CompleteTestEmptyListList2()
        {
            var a = new[] { 3 };
            var b = new int[0];
            ArrayMergeSortedInline1Complete.Merge(a, 1, b);

            var aExpected = new[] { 3 };
            CollectionAssert.AreEqual(aExpected, a);
        }

        /// <summary>
        /// Tests two null arrays.
        /// </summary>
        [TestMethod]
        public void ArrayMergeSortedInline1CompleteTestNullArrays()
        {
            try
            {
                ArrayMergeSortedInline1Complete.Merge(null, 0, null);
            }
            catch (ArgumentException)
            {
                Assert.IsTrue(true);
                return;
            }
            Assert.Fail();
        }

        /// <summary>
        /// Tests a null array for a.
        /// </summary>
        [TestMethod]
        public void ArrayMergeSortedInline1CompleteTestNullListList1()
        {
            try
            {
                var b = new int[0];
                ArrayMergeSortedInline1Complete.Merge(null, 0, b);
            }
            catch (ArgumentException)
            {
                Assert.IsTrue(true);
                return;
            }
            Assert.Fail();
        }

        /// <summary>
        /// Tests a null array for b.
        /// </summary>
        [TestMethod]
        public void ArrayMergeSortedInline1CompleteTestNullListList2()
        {
            try
            {
                var a = new int[0];
                ArrayMergeSortedInline1Complete.Merge(a, 0, null);
            }
            catch (ArgumentException)
            {
                Assert.IsTrue(true);
                return;
            }
            Assert.Fail();
        }

        /// <summary>
        /// Tests a negative count for aCount.
        /// </summary>
        [TestMethod]
        public void ArrayMergeSortedInline1CompleteTestNegativeCount()
        {
            try
            {
                var a = new[] { 3, 7, 23, 56, 0, 0, 0, 0 };
                var b = new[] { 5, 7, 8, 38 };
                ArrayMergeSortedInline1Complete.Merge(a, -2, b);
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
