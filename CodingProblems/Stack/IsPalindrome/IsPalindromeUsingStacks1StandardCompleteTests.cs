using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodingProblems.Stack.IsPalindrome
{
    /// <summary>
    /// Tests IsPalindromeUsingStacks
    /// </summary>
    [TestClass]
    public class IsPalindromeUsingStacks1StandardCompleteTests
    {
        /// <summary>
        /// Tests a one character string.
        /// </summary>
        [TestMethod]
        public void IsPalindromeUsingStacks1StandardTest1OneChar()
        {
            var actual = IsPalindromeUsingStacks1StandardComplete.IsPalindromeUsingStacks("1");
            Assert.AreEqual(true, actual);
        }

        /// <summary>
        /// Tests a simple string that is not a palindrome.
        /// </summary>
        [TestMethod]
        public void IsPalindromeUsingStacks1StandardTest2IsNotAPalindrome()
        {
            var actual = IsPalindromeUsingStacks1StandardComplete.IsPalindromeUsingStacks("test");
            Assert.AreEqual(false, actual);
        }

        /// <summary>
        /// Tests a string with two characters that is a palindrome.
        /// </summary>
        [TestMethod]
        public void IsPalindromeUsingStacks1StandardTest3IsAPalindromeTwoChars()
        {
            var actual = IsPalindromeUsingStacks1StandardComplete.IsPalindromeUsingStacks("55");
            Assert.AreEqual(true, actual);
        }

        /// <summary>
        /// Tests a string with an odd number of characters that is a palindrome.
        /// </summary>
        [TestMethod]
        public void IsPalindromeUsingStacks1StandardTest4IsAPalindromeOddChars()
        {
            var actual = IsPalindromeUsingStacks1StandardComplete.IsPalindromeUsingStacks("aba");
            Assert.AreEqual(true, actual);
        }

        /// <summary>
        /// Tests a string with an even number of characters that is a palindrome.
        /// </summary>
        [TestMethod]
        public void IsPalindromeUsingStacks1StandardTest5IsAPalindromeEvenChars()
        {
            var actual = IsPalindromeUsingStacks1StandardComplete.IsPalindromeUsingStacks("abba");
            Assert.AreEqual(true, actual);
        }
    }
}
