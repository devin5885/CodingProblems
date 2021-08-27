using CodingProblems.BinaryTree.Node;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodingProblems.BinaryTree.GetHeight
{
    /// <summary>
    /// Tests for BinaryTreeNode.GetHeight1RecursiveComplete.
    /// </summary>
    [TestClass]
    public class BinaryTreeGetHeight1RecursiveCompleteTests
    {
        /// <summary>
        /// Checks that GetHeight1RecursiveComplete works correctly for various binary trees.
        /// </summary>
        [TestMethod]
        public void BinaryTreeGetHeight1RecursiveCompleteTest1()
        {
            Assert.AreEqual(1, BinaryTreeGetHeight1RecursiveComplete.GetHeight1RecursiveComplete(BinaryTreeNodeTestData.Tree1));
            Assert.AreEqual(2, BinaryTreeGetHeight1RecursiveComplete.GetHeight1RecursiveComplete(BinaryTreeNodeTestData.Tree2));
            Assert.AreEqual(2, BinaryTreeGetHeight1RecursiveComplete.GetHeight1RecursiveComplete(BinaryTreeNodeTestData.Tree3));
            Assert.AreEqual(2, BinaryTreeGetHeight1RecursiveComplete.GetHeight1RecursiveComplete(BinaryTreeNodeTestData.Tree4));
            Assert.AreEqual(3, BinaryTreeGetHeight1RecursiveComplete.GetHeight1RecursiveComplete(BinaryTreeNodeTestData.Tree5));
            Assert.AreEqual(3, BinaryTreeGetHeight1RecursiveComplete.GetHeight1RecursiveComplete(BinaryTreeNodeTestData.Tree6));
            Assert.AreEqual(3, BinaryTreeGetHeight1RecursiveComplete.GetHeight1RecursiveComplete(BinaryTreeNodeTestData.Tree7));
            Assert.AreEqual(3, BinaryTreeGetHeight1RecursiveComplete.GetHeight1RecursiveComplete(BinaryTreeNodeTestData.Tree8));
            Assert.AreEqual(3, BinaryTreeGetHeight1RecursiveComplete.GetHeight1RecursiveComplete(BinaryTreeNodeTestData.Tree9));
            Assert.AreEqual(3, BinaryTreeGetHeight1RecursiveComplete.GetHeight1RecursiveComplete(BinaryTreeNodeTestData.Tree10));
            Assert.AreEqual(4, BinaryTreeGetHeight1RecursiveComplete.GetHeight1RecursiveComplete(BinaryTreeNodeTestData.Tree11));
            Assert.AreEqual(4, BinaryTreeGetHeight1RecursiveComplete.GetHeight1RecursiveComplete(BinaryTreeNodeTestData.Tree12));

            Assert.AreEqual(1, BinaryTreeGetHeight1RecursiveComplete.GetHeight1RecursiveComplete(BinaryTreeNodeTestData.TreeSubTree41));
            Assert.AreEqual(2, BinaryTreeGetHeight1RecursiveComplete.GetHeight1RecursiveComplete(BinaryTreeNodeTestData.TreeSubTree51));
            Assert.AreEqual(2, BinaryTreeGetHeight1RecursiveComplete.GetHeight1RecursiveComplete(BinaryTreeNodeTestData.TreeSubTree111));
            Assert.AreEqual(3, BinaryTreeGetHeight1RecursiveComplete.GetHeight1RecursiveComplete(BinaryTreeNodeTestData.TreeSubTree121));
        }
    }
}
