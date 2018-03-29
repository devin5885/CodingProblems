using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodingProblems.String_.Palindrome.FindPalindromePermutations
{
    /// <summary>
    /// Implements FindPalidromePermutations
    /// </summary>
    [TestClass]
    public class FindPalindromePermutations1StandardCompleteTests
    {
        /// <summary>
        /// Test single char string.
        /// </summary>
        [TestMethod]
        public void FindPalindromePermutations1StandardCompleteTest1Char()
        {
            var expected = new List<string>() { "a" };
            var actual = FindPalindromePermutations1StandardComplete.FindPalindromePermutations("a");
            CollectionAssert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Test 2 char string.
        /// </summary>
        [TestMethod]
        public void FindPalindromePermutations1StandardCompleteTest2Char()
        {
            var expected = new List<string>() { "aa" };
            var actual = FindPalindromePermutations1StandardComplete.FindPalindromePermutations("aa");
            CollectionAssert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Test 3 char string.
        /// </summary>
        [TestMethod]
        public void FindPalindromePermutations1StandardCompleteTest3Char()
        {
            var expected = new List<string>() { "aba" };
            var actual = FindPalindromePermutations1StandardComplete.FindPalindromePermutations("aba");
            CollectionAssert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Test 4 char string.
        /// </summary>
        [TestMethod]
        public void FindPalindromePermutations1StandardCompleteTest4Char()
        {
            var expected = new List<string>() { "abba", "baab" };
            var actual = FindPalindromePermutations1StandardComplete.FindPalindromePermutations("abba");
            CollectionAssert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Test 4 char string with duplicates (in the first half of the string).
        /// </summary>
        [TestMethod]
        public void FindPalindromePermutations1StandardCompleteTest4CharWithDups()
        {
            var expected = new List<string>() { "aaaa" };
            var actual = FindPalindromePermutations1StandardComplete.FindPalindromePermutations("aaaa");
            CollectionAssert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Test 5 char string with duplicates.
        /// </summary>
        [TestMethod]
        public void FindPalindromePermutations1StandardCompleteTest5Char()
        {
            var expected = new List<string>() { "abcba", "bacab" };
            var actual = FindPalindromePermutations1StandardComplete.FindPalindromePermutations("abcba");
            CollectionAssert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Test 6 char string with duplicates.
        /// </summary>
        [TestMethod]
        public void FindPalindromePermutations1StandardCompleteTest6Char()
        {
            var expected = new List<string>() { "abccba", "acbbca", "baccab", "bcaacb", "cabbac", "cbaabc" };
            var actual = FindPalindromePermutations1StandardComplete.FindPalindromePermutations("abccba");
            CollectionAssert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Tests null string.
        /// </summary>
        [TestMethod]
        public void FindPalindromePermutations1StandardCompleteTestNullString()
        {
            try
            {
                FindPalindromePermutations1StandardComplete.FindPalindromePermutations(null);
            }
            catch (ArgumentException)
            {
                Assert.IsTrue(true);
                return;
            }
            Assert.Fail();
        }

        /// <summary>
        /// Tests non-palindrome string.
        /// </summary>
        [TestMethod]
        public void FindPalindromePermutations1StandardCompleteTestNonPalindrome()
        {
            try
            {
                FindPalindromePermutations1StandardComplete.FindPalindromePermutations("abcd");
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
