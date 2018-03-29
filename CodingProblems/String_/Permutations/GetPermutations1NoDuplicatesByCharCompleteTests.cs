using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodingProblems.String_.Permutations
{
    /// <summary>
    /// Tests GetPermutations
    /// </summary>
    [TestClass]
    public class GetPermutations1NoDuplicatesByCharCompleteTests
    {
        /// <summary>
        /// Test null string.
        /// </summary>
        [TestMethod]
        public void GetPermutations1NoDuplicatesByCharCompleteTestsTestNullString()
        {
            var expected = new List<string>();
            var actual = GetPermutations1NoDuplicatesByCharComplete.GetPermutations(null);
            CollectionAssert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Test empty string.
        /// </summary>
        [TestMethod]
        public void GetPermutations1NoDuplicatesByCharCompleteTestsTestEmptyString()
        {
            var expected = new List<string>();
            var str = string.Empty;
            var actual = GetPermutations1NoDuplicatesByCharComplete.GetPermutations(str);
            CollectionAssert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Test single char string.
        /// </summary>
        [TestMethod]
        public void GetPermutations1NoDuplicatesByCharCompleteTestsTest1Char()
        {
            var expected = new List<string>() { "a" };
            var str = "a";
            var actual = GetPermutations1NoDuplicatesByCharComplete.GetPermutations(str);
            CollectionAssert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Test 2 char string.
        /// </summary>
        [TestMethod]
        public void GetPermutations1NoDuplicatesByCharCompleteTestsTest2Char()
        {
            var expected = new List<string>() { "ab", "ba" };
            var str = "ab";
            var actual = GetPermutations1NoDuplicatesByCharComplete.GetPermutations(str);

            // Sort the list so it will always match expected.
            // The algorithm itself doesn't guarantee any particular order.
            actual.Sort();
            CollectionAssert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Test 3 char string.
        /// Result 6 perms 3!
        /// </summary>
        [TestMethod]
        public void GetPermutations1NoDuplicatesByCharCompleteTestsTest3Char()
        {
            var expected = new List<string>() { "abc", "acb", "bac", "bca", "cab", "cba" };
            var str = "abc";
            var actual = GetPermutations1NoDuplicatesByCharComplete.GetPermutations(str);

            // Sort the list so it will always match expected.
            // The algorithm itself doesn't guarantee any particular order.
            actual.Sort();
            CollectionAssert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Test 4 char string no duplicates.
        /// Result 24 perms 4!
        /// </summary>
        [TestMethod]
        public void GetPermutations1NoDuplicatesByCharCompleteTestsTest4Char()
        {
            var expected = new List<string>() { "abcd", "abdc", "acbd", "acdb", "adbc", "adcb", "bacd", "badc", "bcad", "bcda", "bdac", "bdca", "cabd", "cadb", "cbad", "cbda", "cdab", "cdba", "dabc", "dacb", "dbac", "dbca", "dcab", "dcba" };
            var str = "abcd";
            var actual = GetPermutations1NoDuplicatesByCharComplete.GetPermutations(str);

            // Sort the list so it will always match expected.
            // The algorithm itself doesn't guarantee any particular order.
            actual.Sort();
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}