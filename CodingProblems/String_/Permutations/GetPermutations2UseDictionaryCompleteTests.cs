using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodingProblems.String_.Permutations
{
    /// <summary>
    /// Tests GetPermutations.
    /// </summary>
    [TestClass]
    public class GetPermutations2UseDictionaryCompleteTests
    {
        /// <summary>
        /// Test null string.
        /// </summary>
        [TestMethod]
        public void GetPermutations2UseDictionaryCompleteTestsTestNullString()
        {
            var expected = new List<string>();
            var actual = GetPermutations1NoDuplicatesByCharComplete.GetPermutations(null);
            CollectionAssert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Test empty string.
        /// </summary>
        [TestMethod]
        public void GetPermutations2UseDictionaryCompleteTestsTestEmptyString()
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
        public void GetPermutations2UseDictionaryCompleteTestsTest1Char()
        {
            var expected = new List<string> { "a" };
            const string str = "a";
            var actual = GetPermutations1NoDuplicatesByCharComplete.GetPermutations(str);
            CollectionAssert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Test 2 char string.
        /// </summary>
        [TestMethod]
        public void GetPermutations2UseDictionaryCompleteTestsTest2Char()
        {
            var expected = new List<string> { "ab", "ba" };
            const string str = "ab";
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
        public void GetPermutations2UseDictionaryCompleteTestsTest3Char()
        {
            var expected = new List<string> { "abc", "acb", "bac", "bca", "cab", "cba" };
            const string str = "abc";
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
        public void GetPermutations2UseDictionaryCompleteTestsTest4Char()
        {
            var expected = new List<string> { @"abcd", @"abdc", @"acbd", @"acdb", @"adbc", @"adcb", @"bacd", @"badc", @"bcad", @"bcda", @"bdac", @"bdca", @"cabd", @"cadb", @"cbad", @"cbda", @"cdab", @"cdba", @"dabc", @"dacb", @"dbac", @"dbca", @"dcab", @"dcba" };
            const string str = @"abcd";
            var actual = GetPermutations1NoDuplicatesByCharComplete.GetPermutations(str);

            // Sort the list so it will always match expected.
            // The algorithm itself doesn't guarantee any particular order.
            actual.Sort();
            CollectionAssert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Test 4 char with 2 duplicates in string.
        /// Result: 12 perms 4!/2!
        /// </summary>
        [TestMethod]
        public void GetPermutations2UseDictionaryCompleteTestsTest4Char2Dups()
        {
            var expected = new List<string> { @"abbc", @"abcb", @"acbb", @"babc", @"bacb", @"bbac", @"bbca", @"bcab", @"bcba", @"cabb", @"cbab", @"cbba" };
            const string str = @"abbc";
            var actual = GetPermutations2UseDictionaryComplete.GetPermutations(str);
            CollectionAssert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Test 4 char with 3 duplicates in string.
        /// Result: 4 perms 4!/3!
        /// </summary>
        [TestMethod]
        public void GetPermutations2UseDictionaryCompleteTestsTest5Char3Dups()
        {
            var expected = new List<string> { @"abbb", @"babb", @"bbab", @"bbba" };
            const string str = @"abbb";
            var actual = GetPermutations2UseDictionaryComplete.GetPermutations(str);
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}
