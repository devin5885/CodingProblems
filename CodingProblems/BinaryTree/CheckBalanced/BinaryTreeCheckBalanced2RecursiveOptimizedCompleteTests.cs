using CodingProblems.BinaryTree.Node;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodingProblems.BinaryTree.CheckBalanced
{
    /// <summary>
    /// Tests for BinaryTreeNode.CheckBalanced2OptimizedComplete.
    /// </summary>
    [TestClass]
    public class BinaryTreeCheckBalanced2RecursiveOptimizedCompleteTests
    {
        /// <summary>
        /// Checks that CheckBalanced2OptimizedComplete works correctly for various binary trees.
        /// </summary>
        [TestMethod]
        public void BinaryTreeCheckBalanced2OptimizedCompleteTest1()
        {
            Assert.IsTrue(BinaryTreeCheckBalanced2RecursiveOptimizedComplete.CheckBalanced2OptimizedComplete(BinaryTreeNodeTestData.Tree1));
            Assert.IsTrue(BinaryTreeCheckBalanced2RecursiveOptimizedComplete.CheckBalanced2OptimizedComplete(BinaryTreeNodeTestData.Tree2));
            Assert.IsTrue(BinaryTreeCheckBalanced2RecursiveOptimizedComplete.CheckBalanced2OptimizedComplete(BinaryTreeNodeTestData.Tree3));
            Assert.IsTrue(BinaryTreeCheckBalanced2RecursiveOptimizedComplete.CheckBalanced2OptimizedComplete(BinaryTreeNodeTestData.Tree4));
            Assert.IsTrue(BinaryTreeCheckBalanced2RecursiveOptimizedComplete.CheckBalanced2OptimizedComplete(BinaryTreeNodeTestData.Tree5));
            Assert.IsTrue(BinaryTreeCheckBalanced2RecursiveOptimizedComplete.CheckBalanced2OptimizedComplete(BinaryTreeNodeTestData.Tree6));
            Assert.IsTrue(BinaryTreeCheckBalanced2RecursiveOptimizedComplete.CheckBalanced2OptimizedComplete(BinaryTreeNodeTestData.Tree7));
            Assert.IsTrue(BinaryTreeCheckBalanced2RecursiveOptimizedComplete.CheckBalanced2OptimizedComplete(BinaryTreeNodeTestData.Tree8));
            Assert.IsTrue(BinaryTreeCheckBalanced2RecursiveOptimizedComplete.CheckBalanced2OptimizedComplete(BinaryTreeNodeTestData.Tree9));
            Assert.IsTrue(BinaryTreeCheckBalanced2RecursiveOptimizedComplete.CheckBalanced2OptimizedComplete(BinaryTreeNodeTestData.Tree10));
            Assert.IsTrue(BinaryTreeCheckBalanced2RecursiveOptimizedComplete.CheckBalanced2OptimizedComplete(BinaryTreeNodeTestData.Tree11));
            Assert.IsTrue(BinaryTreeCheckBalanced2RecursiveOptimizedComplete.CheckBalanced2OptimizedComplete(BinaryTreeNodeTestData.Tree12));
            Assert.IsFalse(BinaryTreeCheckBalanced2RecursiveOptimizedComplete.CheckBalanced2OptimizedComplete(BinaryTreeNodeTestData.Tree13));
            Assert.IsFalse(BinaryTreeCheckBalanced2RecursiveOptimizedComplete.CheckBalanced2OptimizedComplete(BinaryTreeNodeTestData.Tree14));
            Assert.IsTrue(BinaryTreeCheckBalanced2RecursiveOptimizedComplete.CheckBalanced2OptimizedComplete(BinaryTreeNodeTestData.Tree15));
            Assert.IsFalse(BinaryTreeCheckBalanced2RecursiveOptimizedComplete.CheckBalanced2OptimizedComplete(BinaryTreeNodeTestData.Tree16));

            Assert.IsTrue(BinaryTreeCheckBalanced2RecursiveOptimizedComplete.CheckBalanced2OptimizedComplete(BinaryTreeNodeTestData.TreeSubTree41));
            Assert.IsTrue(BinaryTreeCheckBalanced2RecursiveOptimizedComplete.CheckBalanced2OptimizedComplete(BinaryTreeNodeTestData.TreeSubTree51));
            Assert.IsTrue(BinaryTreeCheckBalanced2RecursiveOptimizedComplete.CheckBalanced2OptimizedComplete(BinaryTreeNodeTestData.TreeSubTree111));
            Assert.IsTrue(BinaryTreeCheckBalanced2RecursiveOptimizedComplete.CheckBalanced2OptimizedComplete(BinaryTreeNodeTestData.TreeSubTree121));
        }
    }
}
