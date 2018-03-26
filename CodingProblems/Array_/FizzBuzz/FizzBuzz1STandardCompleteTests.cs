using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodingProblems.Array_.FizzBuzz
{
    /// <summary>
    /// Tests FizzBuzzz.
    /// </summary>
    [TestClass]
    public class FizzBuzz1StandardCompleteTests
    {
        /// <summary>
        /// Standard test.
        /// </summary>
        [TestMethod]
        public void FizzBuzz1StandardCompleteTest1()
        {
            var expected = new[] { "FizzBuzz", "1", "2", "Fizz", "4", "Buzz", "Fizz", "7", "8", "Fizz", "Buzz", "11", "Fizz", "13", "14", "FizzBuzz", "16", "17", "Fizz", "19", "Buzz" };
            var actual = FizzBuzz1StandardComplete.FizzBuzz(21);
            CollectionAssert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Error negative number test.
        /// </summary>
        [TestMethod]
        public void FizzBuzz1StandardCompleteTest2ErrorNegativeInput()
        {
            try
            {
                FizzBuzz1StandardComplete.FizzBuzz(-1);
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
