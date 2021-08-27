using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodingProblems.String_.Palindrome.GetMakePalindromeStepCount
{
    /// <summary>
    /// Tests GetMakePalindromeStepCount.
    /// </summary>
    [TestClass]
    public class GetMakePalindromeStepCount1StandardCompleteTests
    {
        /// <summary>
        /// Test single char string.
        /// </summary>
        [TestMethod]
        public void GetMakePalindromeStepCount1StandardCompleteTestsTest1Char()
        {
            var actual = GetMakePalindromeStepCount1StandardComplete.GetMakePalindromeStepCount("a");
            Assert.AreEqual(0, actual);
        }

        /// <summary>
        /// 2 char string, already Palindrome.
        /// </summary>
        [TestMethod]
        public void GetMakePalindromeStepCount1StandardCompleteTestsTest2CharAlready()
        {
            var actual = GetMakePalindromeStepCount1StandardComplete.GetMakePalindromeStepCount("aa");
            Assert.AreEqual(0, actual);
        }

        /// <summary>
        /// 2 char string, not Palindrome.
        /// </summary>
        [TestMethod]
        public void GetMakePalindromeStepCount1StandardCompleteTestsTest3CharNot()
        {
            var actual = GetMakePalindromeStepCount1StandardComplete.GetMakePalindromeStepCount("ab");
            Assert.AreEqual(1, actual);
        }

        /// <summary>
        /// 3 char string, not Palindrome.
        /// </summary>
        [TestMethod]
        public void GetMakePalindromeStepCount1StandardCompleteTestsTest4CharNot()
        {
            var actual = GetMakePalindromeStepCount1StandardComplete.GetMakePalindromeStepCount("bbc");
            Assert.AreEqual(1, actual);
        }

        /// <summary>
        /// 6 char string, 1 delete will fix.
        /// </summary>
        [TestMethod]
        public void GetMakePalindromeStepCount1StandardCompleteTestsTest5Need1Delete()
        {
            var actual = GetMakePalindromeStepCount1StandardComplete.GetMakePalindromeStepCount(@"abdbea");
            Assert.AreEqual(1, actual);
        }

        /// <summary>
        /// 8 char string, 1 delete will fix.
        /// </summary>
        [TestMethod]
        public void GetMakePalindromeStepCount1StandardCompleteTestsTest6Need2Delete()
        {
            var actual = GetMakePalindromeStepCount1StandardComplete.GetMakePalindromeStepCount(@"abcddeceba");
            Assert.AreEqual(2, actual);
        }

        /// <summary>
        /// Tests null string.
        /// </summary>
        [TestMethod]
        public void GetMakePalindromeStepCount1StandardCompleteTestsTest7NullString()
        {
            try
            {
                GetMakePalindromeStepCount1StandardComplete.GetMakePalindromeStepCount(null);
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
