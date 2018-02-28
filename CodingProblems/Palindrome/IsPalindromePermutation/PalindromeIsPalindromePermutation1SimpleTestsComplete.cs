using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodingProblems.Palindrome.IsPalindromePermutation
{
    /// <summary>
    /// Tests for PalindromeIsPalindromePermutation1SimpleComplete.IsPalindromePermutation.
    /// </summary>
    [TestClass]
    public class PalindromeIsPalindromePermutation1SimpleTestsComplete
    {
        /// <summary>
        /// Test empty string.
        /// </summary>
        [TestMethod]
        public void PalindromeStringIsPalindromePermuation1TestEmptyString()
        {
            Assert.IsTrue(PalindromeIsPalindromePermutation1SimpleComplete.IsPalindromePermutation(string.Empty));
        }

        /// <summary>
        /// Test single char string.
        /// </summary>
        [TestMethod]
        public void PalindromeStringIsPalindromePermuation1Test1Char()
        {
            Assert.IsTrue(PalindromeIsPalindromePermutation1SimpleComplete.IsPalindromePermutation("a"));
        }

        /// <summary>
        /// 2 char string, already Palindrome.
        /// </summary>
        [TestMethod]
        public void PalindromeStringIsPalindromePermuation1Test2Char()
        {
            Assert.IsTrue(PalindromeIsPalindromePermutation1SimpleComplete.IsPalindromePermutation("aa"));
        }

        /// <summary>
        /// 2 char string, not a Palindrome permutation.
        /// </summary>
        [TestMethod]
        public void PalindromeStringIsPalindromePermuation1Test2CharNot()
        {
            Assert.IsFalse(PalindromeIsPalindromePermutation1SimpleComplete.IsPalindromePermutation("ab"));
        }

        /// <summary>
        /// 3 char string, not Palindrome permutation.
        /// </summary>
        [TestMethod]
        public void PalindromeStringIsPalindromePermuation1Test3CharNot()
        {
            Assert.IsFalse(PalindromeIsPalindromePermutation1SimpleComplete.IsPalindromePermutation("bcd"));
        }

        /// <summary>
        /// 3 char string, Palindrome permutation.
        /// </summary>
        [TestMethod]
        public void PalindromeStringIsPalindromePermuation1Test3Char()
        {
            Assert.IsTrue(PalindromeIsPalindromePermutation1SimpleComplete.IsPalindromePermutation("cbc"));
        }

        /// <summary>
        /// 4 char string, Palindrome permutation.
        /// </summary>
        [TestMethod]
        public void PalindromeStringIsPalindromePermuation1Test4Char()
        {
            Assert.IsTrue(PalindromeIsPalindromePermutation1SimpleComplete.IsPalindromePermutation("cbbc"));
        }

        /// <summary>
        /// Multiple odd # of characters.
        /// </summary>
        [TestMethod]
        public void PalindromeStringIsPalindromePermuation1TestMultipleOdd()
        {
            Assert.IsFalse(PalindromeIsPalindromePermutation1SimpleComplete.IsPalindromePermutation("cbdbce"));
        }

        /// <summary>
        /// Test null string.
        /// </summary>
        [TestMethod]
        public void PalindromeStringIsPalindromePermuation1TestNull()
        {
            try
            {
                PalindromeIsPalindromePermutation1SimpleComplete.IsPalindromePermutation(null);
            }
            catch
            {
                Assert.IsTrue(true);
                return;
            }

            Assert.Fail();
        }
    }
}
