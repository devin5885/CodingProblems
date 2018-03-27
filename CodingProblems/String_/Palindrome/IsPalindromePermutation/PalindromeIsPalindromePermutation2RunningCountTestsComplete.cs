using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodingProblems.String_.Palindrome.IsPalindromePermutation
{
    /// <summary>
    /// Tests for PalindromeIsPalindromePermutation2RunningCountComplete.IsPalindromePermutation.
    /// </summary>
    [TestClass]
    public class PalindromeIsPalindromePermutation2RunningCountTestsComplete
    {
        /// <summary>
        /// Test empty string.
        /// </summary>
        [TestMethod]
        public void PalindromeStringIsPalindromePermuation1TestEmptyString()
        {
            Assert.IsTrue(PalindromeIsPalindromePermutation2RunningCountComplete.IsPalindromePermutation(string.Empty));
        }

        /// <summary>
        /// Test single char string.
        /// </summary>
        [TestMethod]
        public void PalindromeStringIsPalindromePermuation2Test1Char()
        {
            Assert.IsTrue(PalindromeIsPalindromePermutation2RunningCountComplete.IsPalindromePermutation("a"));
        }

        /// <summary>
        /// 2 char string, already Palindrome.
        /// </summary>
        [TestMethod]
        public void PalindromeStringIsPalindromePermuation2Test2Char()
        {
            Assert.IsTrue(PalindromeIsPalindromePermutation2RunningCountComplete.IsPalindromePermutation("aa"));
        }

        /// <summary>
        /// 2 char string, not a Palindrome permutation.
        /// </summary>
        [TestMethod]
        public void PalindromeStringIsPalindromePermuation2Test2CharNot()
        {
            Assert.IsFalse(PalindromeIsPalindromePermutation2RunningCountComplete.IsPalindromePermutation("ab"));
        }

        /// <summary>
        /// 3 char string, not Palindrome permutation.
        /// </summary>
        [TestMethod]
        public void PalindromeStringIsPalindromePermuation2Test3CharNot()
        {
            Assert.IsFalse(PalindromeIsPalindromePermutation2RunningCountComplete.IsPalindromePermutation("bcd"));
        }

        /// <summary>
        /// 3 char string, Palindrome permutation.
        /// </summary>
        [TestMethod]
        public void PalindromeStringIsPalindromePermuation2Test3Char()
        {
            Assert.IsTrue(PalindromeIsPalindromePermutation2RunningCountComplete.IsPalindromePermutation("cbc"));
        }

        /// <summary>
        /// 4 char string, Palindrome permutation.
        /// </summary>
        [TestMethod]
        public void PalindromeStringIsPalindromePermuation2Test4Char()
        {
            Assert.IsTrue(PalindromeIsPalindromePermutation2RunningCountComplete.IsPalindromePermutation("cbbc"));
        }

        /// <summary>
        /// Multiple odd # of characters.
        /// </summary>
        [TestMethod]
        public void PalindromeStringIsPalindromePermuation1TestMultipleOdd()
        {
            Assert.IsFalse(PalindromeIsPalindromePermutation2RunningCountComplete.IsPalindromePermutation("cbdbce"));
        }

        /// <summary>
        /// Test null string.
        /// </summary>
        [TestMethod]
        public void PalindromeStringIsPalindromePermuation1TestNull()
        {
            try
            {
                PalindromeIsPalindromePermutation2RunningCountComplete.IsPalindromePermutation(null);
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
