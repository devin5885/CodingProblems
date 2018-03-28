using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodingProblems.String_.Palindrome.FindLongestPalindrome
{
    /// <summary>
    /// Tests FindLongestPalindrome.
    /// </summary>
    [TestClass]
    public class FindLongestPalindrome2UseAnchorsCompleteTests
    {
        /// <summary>
        /// Test already a Palindrome.
        /// </summary>
        [TestMethod]
        public void FindLongestPalindrome2UseAnchorsTest1AlreadyPalidrome1()
        {
            var actual = FindLongestPalindrome2UseAnchorsComplete.FindLongestPalindrome("aba");
            Assert.AreEqual("aba", actual);
        }

        /// <summary>
        /// Test already a Palindrome.
        /// </summary>
        [TestMethod]
        public void FindLongestPalindrome2UseAnchorsTest2AlreadyPalidrome2()
        {
            var actual = FindLongestPalindrome2UseAnchorsComplete.FindLongestPalindrome("aa");
            Assert.AreEqual("aa", actual);
        }

        /// <summary>
        /// Test removing the last char.
        /// </summary>
        [TestMethod]
        public void FindLongestPalindrome2UseAnchorsTest3RemoveLastChar()
        {
            var actual = FindLongestPalindrome2UseAnchorsComplete.FindLongestPalindrome("abac");
            Assert.AreEqual("aba", actual);
        }

        /// <summary>
        /// Test removing the first char.
        /// </summary>
        [TestMethod]
        public void FindLongestPalindrome2UseAnchorsTest4RemoveFirstChar()
        {
            var actual = FindLongestPalindrome2UseAnchorsComplete.FindLongestPalindrome("caba");
            Assert.AreEqual("aba", actual);
        }

        /// <summary>
        /// Test removing two last chars.
        /// </summary>
        [TestMethod]
        public void FindLongestPalindrome2UseAnchorsTest5RemoveLastTwoChars()
        {
            var actual = FindLongestPalindrome2UseAnchorsComplete.FindLongestPalindrome("abacc");
            Assert.AreEqual("aba", actual);
        }

        /// <summary>
        /// Test removing the two first chars.
        /// </summary>
        [TestMethod]
        public void FindLongestPalindrome2UseAnchorsTest6RemoveFirstTwoChars()
        {
            var actual = FindLongestPalindrome2UseAnchorsComplete.FindLongestPalindrome("ccaba");
            Assert.AreEqual("aba", actual);
        }

        /// <summary>
        /// Test non-palindrome until last letter.
        /// </summary>
        [TestMethod]
        public void FindLongestPalindrome2UseAnchorsTest7NoPalidrome()
        {
            var actual = FindLongestPalindrome2UseAnchorsComplete.FindLongestPalindrome("abcde");
            Assert.AreEqual("a", actual);
        }

        /// <summary>
        /// Test multiple-palindromes.
        /// </summary>
        [TestMethod]
        public void FindLongestPalindrome2UseAnchorsTest8MultiplePalindromes()
        {
            var actual = FindLongestPalindrome2UseAnchorsComplete.FindLongestPalindrome("abbfcceg");
            Assert.AreEqual("bb", actual);
        }

        /// <summary>
        /// Test empty string.
        /// </summary>
        [TestMethod]
        public void FindLongestPalindrome2UseAnchorsTest9EmptyString()
        {
            var actual = FindLongestPalindrome2UseAnchorsComplete.FindLongestPalindrome(string.Empty);
            Assert.AreEqual(string.Empty, actual);
        }

        /// <summary>
        /// Tests null string.
        /// </summary>
        [TestMethod]
        public void FindLongestPalindrome2UseAnchorsTest10NullList1()
        {
            try
            {
                FindLongestPalindrome2UseAnchorsComplete.FindLongestPalindrome(null);
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
