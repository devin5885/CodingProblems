using CodingProblems.BinaryTree.Node;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodingProblems.BinaryTree.CheckBalanced
{
    /// <summary>
    /// Tests for BinaryTreeNode.CheckBalanced1RecursiveComplete.
    /// </summary>
    [TestClass]
    public class BinaryTreeCheckBalanced1RecursiveCompleteTests
    {
        /// <summary>
        /// Checks that CheckBalanced1RecursiveComplete works correctly for various binary trees.
        /// </summary>
        [TestMethod]
        public void BinaryTreeCheckBalanced1RecursiveCompleteTest1()
        {
            Assert.IsTrue(BinaryTreeCheckBalanced1RecursiveComplete.CheckBalanced1RecursiveComplete(BinaryTreeNodeTestData.Tree5));
            Assert.IsFalse(BinaryTreeCheckBalanced1RecursiveComplete.CheckBalanced1RecursiveComplete(BinaryTreeNodeTestData.Tree13));
            Assert.IsFalse(BinaryTreeCheckBalanced1RecursiveComplete.CheckBalanced1RecursiveComplete(BinaryTreeNodeTestData.Tree14));
            Assert.IsTrue(BinaryTreeCheckBalanced1RecursiveComplete.CheckBalanced1RecursiveComplete(BinaryTreeNodeTestData.Tree1));
            Assert.IsTrue(BinaryTreeCheckBalanced1RecursiveComplete.CheckBalanced1RecursiveComplete(BinaryTreeNodeTestData.Tree2));
            Assert.IsTrue(BinaryTreeCheckBalanced1RecursiveComplete.CheckBalanced1RecursiveComplete(BinaryTreeNodeTestData.Tree3));
            Assert.IsTrue(BinaryTreeCheckBalanced1RecursiveComplete.CheckBalanced1RecursiveComplete(BinaryTreeNodeTestData.Tree4));
            Assert.IsTrue(BinaryTreeCheckBalanced1RecursiveComplete.CheckBalanced1RecursiveComplete(BinaryTreeNodeTestData.Tree6));
            Assert.IsTrue(BinaryTreeCheckBalanced1RecursiveComplete.CheckBalanced1RecursiveComplete(BinaryTreeNodeTestData.Tree7));
            Assert.IsTrue(BinaryTreeCheckBalanced1RecursiveComplete.CheckBalanced1RecursiveComplete(BinaryTreeNodeTestData.Tree8));
            Assert.IsTrue(BinaryTreeCheckBalanced1RecursiveComplete.CheckBalanced1RecursiveComplete(BinaryTreeNodeTestData.Tree9));
            Assert.IsTrue(BinaryTreeCheckBalanced1RecursiveComplete.CheckBalanced1RecursiveComplete(BinaryTreeNodeTestData.Tree10));
            Assert.IsTrue(BinaryTreeCheckBalanced1RecursiveComplete.CheckBalanced1RecursiveComplete(BinaryTreeNodeTestData.Tree11));
            Assert.IsTrue(BinaryTreeCheckBalanced1RecursiveComplete.CheckBalanced1RecursiveComplete(BinaryTreeNodeTestData.Tree12));
            Assert.IsTrue(BinaryTreeCheckBalanced1RecursiveComplete.CheckBalanced1RecursiveComplete(BinaryTreeNodeTestData.Tree15));
            Assert.IsFalse(BinaryTreeCheckBalanced1RecursiveComplete.CheckBalanced1RecursiveComplete(BinaryTreeNodeTestData.Tree16));

            Assert.IsTrue(BinaryTreeCheckBalanced1RecursiveComplete.CheckBalanced1RecursiveComplete(BinaryTreeNodeTestData.TreeSubTree41));
            Assert.IsTrue(BinaryTreeCheckBalanced1RecursiveComplete.CheckBalanced1RecursiveComplete(BinaryTreeNodeTestData.TreeSubTree51));
            Assert.IsTrue(BinaryTreeCheckBalanced1RecursiveComplete.CheckBalanced1RecursiveComplete(BinaryTreeNodeTestData.TreeSubTree111));
            Assert.IsTrue(BinaryTreeCheckBalanced1RecursiveComplete.CheckBalanced1RecursiveComplete(BinaryTreeNodeTestData.TreeSubTree121));
        }
    }
}
