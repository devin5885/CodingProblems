using CodingProblems.BinaryTree.Node;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodingProblems.BinaryTree.GetHeight
{
    /// <summary>
    /// Tests for BinaryTreeNode.GetHeight1Recursive.
    /// </summary>
    [TestClass]
    public class BinaryTreeGetHeight2IterativeCompleteTests
    {
        /// <summary>
        /// Checks that GetHeight2Iterative works correctly for various binary trees.
        /// </summary>
        [TestMethod]
        public void BinaryTreeGetHeight2IterativeCompleteTest1()
        {
            Assert.AreEqual(1, BinaryTreeGetHeight2IterativeComplete.GetHeight2IterativeComplete(BinaryTreeNodeTestData.Tree1));
            Assert.AreEqual(2, BinaryTreeGetHeight2IterativeComplete.GetHeight2IterativeComplete(BinaryTreeNodeTestData.Tree2));
            Assert.AreEqual(2, BinaryTreeGetHeight2IterativeComplete.GetHeight2IterativeComplete(BinaryTreeNodeTestData.Tree3));
            Assert.AreEqual(2, BinaryTreeGetHeight2IterativeComplete.GetHeight2IterativeComplete(BinaryTreeNodeTestData.Tree4));
            Assert.AreEqual(3, BinaryTreeGetHeight2IterativeComplete.GetHeight2IterativeComplete(BinaryTreeNodeTestData.Tree5));
            Assert.AreEqual(3, BinaryTreeGetHeight2IterativeComplete.GetHeight2IterativeComplete(BinaryTreeNodeTestData.Tree6));
            Assert.AreEqual(3, BinaryTreeGetHeight2IterativeComplete.GetHeight2IterativeComplete(BinaryTreeNodeTestData.Tree7));
            Assert.AreEqual(3, BinaryTreeGetHeight2IterativeComplete.GetHeight2IterativeComplete(BinaryTreeNodeTestData.Tree8));
            Assert.AreEqual(3, BinaryTreeGetHeight2IterativeComplete.GetHeight2IterativeComplete(BinaryTreeNodeTestData.Tree9));
            Assert.AreEqual(3, BinaryTreeGetHeight2IterativeComplete.GetHeight2IterativeComplete(BinaryTreeNodeTestData.Tree10));
            Assert.AreEqual(4, BinaryTreeGetHeight2IterativeComplete.GetHeight2IterativeComplete(BinaryTreeNodeTestData.Tree11));
            Assert.AreEqual(4, BinaryTreeGetHeight2IterativeComplete.GetHeight2IterativeComplete(BinaryTreeNodeTestData.Tree12));

            Assert.AreEqual(1, BinaryTreeGetHeight2IterativeComplete.GetHeight2IterativeComplete(BinaryTreeNodeTestData.TreeSubTree41));
            Assert.AreEqual(2, BinaryTreeGetHeight2IterativeComplete.GetHeight2IterativeComplete(BinaryTreeNodeTestData.TreeSubTree51));
            Assert.AreEqual(2, BinaryTreeGetHeight2IterativeComplete.GetHeight2IterativeComplete(BinaryTreeNodeTestData.TreeSubTree111));
            Assert.AreEqual(3, BinaryTreeGetHeight2IterativeComplete.GetHeight2IterativeComplete(BinaryTreeNodeTestData.TreeSubTree121));
        }
    }
}
