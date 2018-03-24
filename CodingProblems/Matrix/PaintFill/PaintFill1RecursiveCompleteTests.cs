using System;
using CodingProblems.Matrix.Helpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodingProblems.Matrix.PaintFill
{
    /// <summary>
    /// Tests PaintFill1RecursiveCompleteTests.PaintFill
    /// </summary>
    [TestClass]
    public class PaintFill1RecursiveCompleteTests
    {
        /// <summary>
        /// General test.
        /// </summary>
        [TestMethod]
        public void PaintFill1RecursiveCompleteTest1General()
        {
            var actual = new[,] { { 3, 0, 3, 3 }, { 0, 0, 0, 3 }, { 0, 0, 0, 3 }, { 3, 3, 3, 3 } };
            var expected = new[,] { { 3, -1, 3, 3 }, { -1, -1, -1, 3 }, { -1, -1, -1, 3 }, { 3, 3, 3, 3 } };
            Assert.IsTrue(PaintFill1RecursiveComplete.PaintFill(actual, 1, 1, -1));
            Assert.IsTrue(MatrixHelpers.Compare(actual, expected));
        }

        /// <summary>
        /// General test.
        /// </summary>
        [TestMethod]
        public void PaintFill1RecursiveCompleteTest2NoUpdate()
        {
            var actual = new[,] { { 3, 0, 3, 3 }, { 0, 0, 0, 3 }, { 3, 3, 3, 3 } };
            var expected = new[,] { { 3, 0, 3, 3 }, { 0, 0, 0, 3 }, { 3, 3, 3, 3 } };
            Assert.IsFalse(PaintFill1RecursiveComplete.PaintFill(actual, 1, 1, 0));
            Assert.IsTrue(MatrixHelpers.Compare(actual, expected));
        }

        /// <summary>
        /// General test.
        /// </summary>
        [TestMethod]
        public void PaintFill1RecursiveCompleteTest3IrregularImage()
        {
            var actual = new[,] { { 3, 0, 3, 3 }, { 0, 0, 0, 3 }, { 3, 3, 3, 3 } };
            var expected = new[,] { { 3, -1, 3, 3 }, { -1, -1, -1, 3 }, { 3, 3, 3, 3 } };
            Assert.IsTrue(PaintFill1RecursiveComplete.PaintFill(actual, 1, 1, -1));
            Assert.IsTrue(MatrixHelpers.Compare(actual, expected));
        }
    }
}