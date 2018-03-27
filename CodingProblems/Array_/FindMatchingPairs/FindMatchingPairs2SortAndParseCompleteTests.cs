using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodingProblems.Array_.FindMatchingPairs
{
    /// <summary>
    /// Tests FindMatchingPairs
    /// </summary>
    [TestClass]
    public class FindMatchingPairs2SortAndParseCompleteTests
    {
        /// <summary>
        /// Tests FindMatchingPairs in the simple case.
        /// </summary>
        [TestMethod]
        public void FindMatchingPairs2SortAndParseCompleteTestsTest1Simple()
        {
            // Initialize lists.
            var list1 = new List<int> { 1, 2, 4, 7, 8, 3 };
            var list2 = new List<int> { 3, 4, 6, 4, 3 };

            // Initialize expected.
            var expected = new List<int> { 4, 3 };

            // Call method.
            var actual = FindMatchingPairs2SortAndParseComplete.FindMatchingPairs(list1, list2);

            // Since order is not necessarily consistent.
            expected.Sort();
            actual.Sort();

            // Do tests.
            CollectionAssert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Tests FindMatchingPairs in the case where the first list is much longer.
        /// </summary>
        [TestMethod]
        public void FindMatchingPairs1CharCountMapsCompleteTestsTest2LongList1()
        {
            // Initialize lists.
            var list1 = new List<int> { 3, 4, 6, 4, 3, 18, 30, 50, 51, 52, 53 };
            var list2 = new List<int> { 1, 2, 4, 7, 8, 3 };

            // Initialize expected.
            var expected = new List<int> { 4, 3 };

            // Call method.
            var actual = FindMatchingPairs2SortAndParseComplete.FindMatchingPairs(list1, list2);

            // Since order is not necessarily consistent.
            expected.Sort();
            actual.Sort();

            // Do tests.
            CollectionAssert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Tests FindMatchingPairs in the case where the second list is much longer.
        /// </summary>
        [TestMethod]
        public void FindMatchingPairs1CharCountMapsCompleteTestsTest3LongList2()
        {
            // Initialize lists.
            var list1 = new List<int> { 1, 2, 4, 7, 8, 3 };
            var list2 = new List<int> { 3, 4, 6, 4, 3, 18, 30, 50, 51, 52, 53 };

            // Initialize expected.
            var expected = new List<int> { 4, 3 };

            // Call method.
            var actual = FindMatchingPairs2SortAndParseComplete.FindMatchingPairs(list1, list2);

            // Since order is not necessarily consistent.
            expected.Sort();
            actual.Sort();

            // Do tests.
            CollectionAssert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Tests FindMatchingPairs with no matches.
        /// </summary>
        [TestMethod]
        public void FindMatchingPairs2SortAndParseCompleteTestsTest4NoMatches()
        {
            // Initialize lists.
            var list1 = new List<int> { 1, 2, 8, 7, 5, 3 };
            var list2 = new List<int> { 6, 4, 9, 4, 10 };

            // Initialize expected.
            var expected = new List<int>();

            // Call method.
            var actual = FindMatchingPairs2SortAndParseComplete.FindMatchingPairs(list1, list2);

            // Since order is not necessarily consistent.
            expected.Sort();
            actual.Sort();

            // Do tests.
            CollectionAssert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Tests FindMatchingPairs with all elements matching.
        /// </summary>
        [TestMethod]
        public void FindMatchingPairs2SortAndParseCompleteTestsTest5AllMatches()
        {
            // Initialize lists.
            var list1 = new List<int> { 1, 2, 8, 7, 5, 3 };
            var list2 = new List<int> { 1, 2, 8, 7, 5, 3 };

            // Initialize expected.
            var expected = new List<int> { 1, 2, 8, 7, 5, 3 };

            // Call method.
            var actual = FindMatchingPairs2SortAndParseComplete.FindMatchingPairs(list1, list2);

            // Since order is not necessarily consistent.
            expected.Sort();
            actual.Sort();

            // Do tests.
            CollectionAssert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Tests FindMatchingPairs with empty lists.
        /// </summary>
        [TestMethod]
        public void FindMatchingPairs2SortAndParseCompleteTestsTest6EmptyLists()
        {
            // Initialize lists.
            var list1 = new List<int>();
            var list2 = new List<int>();

            // Initialize expected.
            var expected = new List<int>();

            // Call method.
            var actual = FindMatchingPairs2SortAndParseComplete.FindMatchingPairs(list1, list2);

            // Since order is not necessarily consistent.
            expected.Sort();
            actual.Sort();

            // Do tests.
            CollectionAssert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Tests FindMatchingPairs with empty 1st list.
        /// </summary>
        [TestMethod]
        public void FindMatchingPairs2SortAndParseCompleteTestsTest7EmptyList1()
        {
            // Initialize lists.
            var list1 = new List<int>();
            var list2 = new List<int> { 3, 4, 6, 4, 3 };

            // Initialize expected.
            var expected = new List<int>();

            // Call method.
            var actual = FindMatchingPairs2SortAndParseComplete.FindMatchingPairs(list1, list2);

            // Since order is not necessarily consistent.
            expected.Sort();
            actual.Sort();

            // Do tests.
            CollectionAssert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Tests FindMatchingPairs with empty 2nd list.
        /// </summary>
        [TestMethod]
        public void FindMatchingPair2SortAndParseCompleteTestsTest8EmptyList2()
        {
            // Initialize lists.
            var list1 = new List<int> { 3, 4, 6, 4, 3 };
            var list2 = new List<int>();

            // Initialize expected.
            var expected = new List<int>();

            // Call method.
            var actual = FindMatchingPairs2SortAndParseComplete.FindMatchingPairs(list1, list2);

            // Since order is not necessarily consistent.
            expected.Sort();
            actual.Sort();

            // Do tests.
            CollectionAssert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Tests FindMatchingPairs with a null list for list 1.
        /// </summary>
        [TestMethod]
        public void FindMatchingPairs2SortAndParseCompleteTestsTest9NullList1()
        {
            try
            {
                FindMatchingPairs2SortAndParseComplete.FindMatchingPairs(null, new List<int> { 1, 2, 4, 7, 8, 3 });
            }
            catch (ArgumentException)
            {
                Assert.IsTrue(true);
                return;
            }
            Assert.Fail();
        }

        /// <summary>
        /// Tests FindMatchingPairs with a null list for list 2.
        /// </summary>
        [TestMethod]
        public void FindMatchingPairs2SortAndParseCompleteTestsTest10NullList2()
        {
            try
            {
                FindMatchingPairs2SortAndParseComplete.FindMatchingPairs(new List<int> { 1, 2, 4, 7, 8, 3 }, null);
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
