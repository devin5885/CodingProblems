using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodingProblems.String_.Palindrome.FindLongestPalindrome
{
    /// <summary>
    /// Tests FindLongestPalindrome.
    /// </summary>
    [TestClass]
    public class FindLongestPalindrome1BruteForceCompleteTests
    {
        /// <summary>
        /// Test already a Palindrome.
        /// </summary>
        [TestMethod]
        public void FindLongestPalindrome1BruteForceTest1AlreadyPalidrome1()
        {
            var actual = FindLongestPalindrome1BruteForceComplete.FindLongestPalindrome("aba");
            Assert.AreEqual("aba", actual);
        }

        /// <summary>
        /// Test already a Palindrome.
        /// </summary>
        [TestMethod]
        public void FindLongestPalindrome1BruteForceTest2AlreadyPalidrome2()
        {
            var actual = FindLongestPalindrome1BruteForceComplete.FindLongestPalindrome("aa");
            Assert.AreEqual("aa", actual);
        }

        /// <summary>
        /// Test removing the last char.
        /// </summary>
        [TestMethod]
        public void FindLongestPalindrome1BruteForceTest3RemoveLastChar()
        {
            var actual = FindLongestPalindrome1BruteForceComplete.FindLongestPalindrome("abac");
            Assert.AreEqual("aba", actual);
        }

        /// <summary>
        /// Test removing the first char.
        /// </summary>
        [TestMethod]
        public void FindLongestPalindrome1BruteForceTest4RemoveFirstChar()
        {
            var actual = FindLongestPalindrome1BruteForceComplete.FindLongestPalindrome("caba");
            Assert.AreEqual("aba", actual);
        }

        /// <summary>
        /// Test removing two last chars.
        /// </summary>
        [TestMethod]
        public void FindLongestPalindrome1BruteForceTest5RemoveLastTwoChars()
        {
            var actual = FindLongestPalindrome1BruteForceComplete.FindLongestPalindrome("abacc");
            Assert.AreEqual("aba", actual);
        }

        /// <summary>
        /// Test removing the two first chars.
        /// </summary>
        [TestMethod]
        public void FindLongestPalindrome1BruteForceTest6RemoveFirstTwoChars()
        {
            var actual = FindLongestPalindrome1BruteForceComplete.FindLongestPalindrome("ccaba");
            Assert.AreEqual("aba", actual);
        }

        /// <summary>
        /// Test non-palindrome until last letter.
        /// </summary>
        [TestMethod]
        public void FindLongestPalindrome1BruteForceTest7NoPalidrome()
        {
            var actual = FindLongestPalindrome1BruteForceComplete.FindLongestPalindrome("abcde");
            Assert.AreEqual("a", actual);
        }

        /// <summary>
        /// Test multiple-palindromes.
        /// </summary>
        [TestMethod]
        public void FindLongestPalindrome1BruteForceTest8MultiplePalindromes()
        {
            var actual = FindLongestPalindrome1BruteForceComplete.FindLongestPalindrome("abbfcceg");
            Assert.AreEqual("bb", actual);
        }

        /// <summary>
        /// Test empty string.
        /// </summary>
        [TestMethod]
        public void FindLongestPalindrome1BruteForceTest9EmptyString()
        {
            var actual = FindLongestPalindrome1BruteForceComplete.FindLongestPalindrome(string.Empty);
            Assert.AreEqual(string.Empty, actual);
        }

        /// <summary>
        /// Tests null string.
        /// </summary>
        [TestMethod]
        public void FindLongestPalindrome1BruteForceTest10NullList1()
        {
            try
            {
                FindLongestPalindrome1BruteForceComplete.FindLongestPalindrome(null);
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
