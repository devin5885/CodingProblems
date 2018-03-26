using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodingProblems.String_.Fibonacci
{
    /// <summary>
    /// Tests Fibonacci
    /// </summary>
    [TestClass]
    public class Fibonacci1RecursiveCompleteTests
    {
        /// <summary>
        /// General test.
        /// </summary>
        [TestMethod]
        public void Fibonacci1RecursiveCompleteTest1()
        {
            // Build the expected array.
            var expected = new[] { 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, 610, 987, 1597, 2584, 4181 };

            // Calculate the first 20 Fibonacci numbers.
            var actual = new int[20];
            for (var n = 0; n < actual.Length; n++)
            {
                actual[n] = Fibonacci1RecursiveComplete.Fibonacci(n);
            }

            CollectionAssert.AreEqual(actual, expected);
        }

        /// <summary>
        /// Error test for negative index.
        /// </summary>
        [TestMethod]
        public void Fibonacci1RecursiveCompleteTest2ErrorNegativeNumber()
        {
            try
            {
                Fibonacci1RecursiveComplete.Fibonacci(-1);
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