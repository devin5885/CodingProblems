using System;
using CodingProblems.Matrix.Helpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodingProblems.Matrix.Rotate
{
    /// <summary>
    /// Tests for MatrixRotate1Complete.Rotate.
    /// </summary>
    [TestClass]
    public class MatrixRotate1CompleteTests
    {
        /// <summary>
        /// Test 1.
        /// </summary>
        [TestMethod]
        public void MatrixRotate1CompleteTest1()
        {
            var actual = new[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            var expected = new[,] { { 7, 4, 1 }, { 8, 5, 2 }, { 9, 6, 3 } };
            MatrixRotate1Complete.Rotate(ref actual);
            Assert.IsTrue(MatrixHelpers.Compare(actual, expected));
        }

        /// <summary>
        /// Test 2.
        /// </summary>
        [TestMethod]
        public void MatrixRotate1CompleteTest2()
        {
            var actual = new[,] { { 1, 2 }, { 3, 4 } };
            var expected = new[,] { { 3, 1 }, { 4, 2 } };
            MatrixRotate1Complete.Rotate(ref actual);
            Assert.IsTrue(MatrixHelpers.Compare(actual, expected));
        }

        /// <summary>
        /// Test 3.
        /// </summary>
        [TestMethod]
        public void MatrixRotate1CompleteTest3()
        {
            var actual = new[,] { { 1 } };
            var expected = new[,] { { 1 } };
            MatrixRotate1Complete.Rotate(ref actual);
            Assert.IsTrue(MatrixHelpers.Compare(actual, expected));
        }

        /// <summary>
        /// Test 4.
        /// </summary>
        [TestMethod]
        public void MatrixRotate1CompleteTest4()
        {
            var actual = new[,] { { 1, 2, 3, 4 }, { 5, 6, 7, 8 }, { 9, 10, 11, 12 }, { 13, 14, 15, 16 } };
            var expected = new[,] { { 13, 9, 5, 1 }, { 14, 10, 6, 2 }, { 15, 11, 7, 3 }, { 16, 12, 8, 4 } };
            MatrixRotate1Complete.Rotate(ref actual);
            Assert.IsTrue(MatrixHelpers.Compare(actual, expected));
        }

        /// <summary>
        /// Test Exception null.
        /// </summary>
        [TestMethod]
        public void MatrixRotate1CompleteTestExceptionNull()
        {
            try
            {
                int[,] actual = null;
                MatrixRotate1Complete.Rotate(ref actual);
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
