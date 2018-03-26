using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodingProblems.String_.FindFirstNonRepeatedCharIndex
{
    /// <summary>
    /// Tests FindFirstNoRepeated.
    /// </summary>
    [TestClass]
    public class FindFirstNonRepeatedCharIndex1BruteForceCompleteTests
    {
        /// <summary>
        /// Simple Test 1
        /// </summary>
        [TestMethod]
        public void FindFirstNonRepeatedCharIndex1BruteForceCompleteTest1()
        {
            var index = FindFirstNonRepeatedCharIndex1BruteForceComplete.FindFirstNonRepeatedCharIndex("test");
            Assert.AreEqual(1, index);
        }

        /// <summary>
        /// Simple Test 2
        /// </summary>
        [TestMethod]
        public void FindFirstNonRepeatedCharIndex1BruteForceCompleteTest2()
        {
            var index = FindFirstNonRepeatedCharIndex1BruteForceComplete.FindFirstNonRepeatedCharIndex("teste");
            Assert.AreEqual(2, index);
        }

        /// <summary>
        /// Simple Test 3
        /// </summary>
        [TestMethod]
        public void FindFirstNonRepeatedCharIndex1BruteForceCompleteTest3()
        {
            var index = FindFirstNonRepeatedCharIndex1BruteForceComplete.FindFirstNonRepeatedCharIndex("teter");
            Assert.AreEqual(4, index);
        }

        /// <summary>
        /// Test string with all repeating characters.
        /// </summary>
        [TestMethod]
        public void FindFirstNonRepeatedCharIndex1BruteForceCompleteTest4NoNonRepeating()
        {
            var index = FindFirstNonRepeatedCharIndex1BruteForceComplete.FindFirstNonRepeatedCharIndex("testtest");
            Assert.AreEqual(-1, index);
        }

        /// <summary>
        /// Test empty string.
        /// </summary>
        [TestMethod]
        public void FindFirstNonRepeatedCharIndex1BruteForceCompleteTest4Empty()
        {
            var index = FindFirstNonRepeatedCharIndex1BruteForceComplete.FindFirstNonRepeatedCharIndex(string.Empty);
            Assert.AreEqual(-1, index);
        }

        /// <summary>
        /// Test null string.
        /// </summary>
        [TestMethod]
        public void FindFirstNonRepeatedCharIndex1BruteForceCompleteTest4Null()
        {
            try
            {
                FindFirstNonRepeatedCharIndex1BruteForceComplete.FindFirstNonRepeatedCharIndex(null);
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
