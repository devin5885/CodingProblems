using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodingProblems.String_.Palindrome.IsPalindrome
{
    /// <summary>
    /// Tests IsPalindrome.
    /// </summary>
    [TestClass]
    public class IsPalindrome1StandardCompleteTests
    {
        /// <summary>
        /// Tests a one character string.
        /// </summary>
        [TestMethod]
        public void IsPalindrome1StandardCompleteTest1OneChar()
        {
            var actual = IsPalindrome1StandardComplete.IsPalindrome("1");
            Assert.AreEqual(true, actual);
        }

        /// <summary>
        /// Tests a simple string that is not a palindrome.
        /// </summary>
        [TestMethod]
        public void IsPalindrome1StandardCompleteTest2IsNotAPalindrome()
        {
            var actual = IsPalindrome1StandardComplete.IsPalindrome("test");
            Assert.AreEqual(false, actual);
        }

        /// <summary>
        /// Tests a string with two characters that is a palindrome.
        /// </summary>
        [TestMethod]
        public void IsPalindrome1StandardCompleteTest3IsAPalindromeTwoChars()
        {
            var actual = IsPalindrome1StandardComplete.IsPalindrome("55");
            Assert.AreEqual(true, actual);
        }

        /// <summary>
        /// Tests a string with an odd number of characters that is a palindrome.
        /// </summary>
        [TestMethod]
        public void IsPalindrome1StandardCompleteTest4IsAPalindromeOddChars()
        {
            var actual = IsPalindrome1StandardComplete.IsPalindrome("aba");
            Assert.AreEqual(true, actual);
        }

        /// <summary>
        /// Tests a string with an even number of characters that is a palindrome.
        /// </summary>
        [TestMethod]
        public void IsPalindrome1StandardCompleteTest5IsAPalindromeEvenChars()
        {
            var actual = IsPalindrome1StandardComplete.IsPalindrome(@"abba");
            Assert.AreEqual(true, actual);
        }

        /// <summary>
        /// Tests null string.
        /// </summary>
        [TestMethod]
        public void IsPalindrome1StandardCompleteTest6IsAPalindromeNullList()
        {
            try
            {
                IsPalindrome1StandardComplete.IsPalindrome(null);
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
