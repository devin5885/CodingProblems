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
            // Primary test cases.
            Assert.IsTrue(BinaryTreeCheckBalanced2RecursiveOptimizedComplete.CheckBalanced2OptimizedComplete(BinaryTreeNodeTestData.Tree5));
            Assert.IsFalse(BinaryTreeCheckBalanced2RecursiveOptimizedComplete.CheckBalanced2OptimizedComplete(BinaryTreeNodeTestData.Tree13));
            Assert.IsFalse(BinaryTreeCheckBalanced2RecursiveOptimizedComplete.CheckBalanced2OptimizedComplete(BinaryTreeNodeTestData.Tree14));

            // Additional test cases (All balanced).
            Assert.IsTrue(BinaryTreeCheckBalanced2RecursiveOptimizedComplete.CheckBalanced2OptimizedComplete(BinaryTreeNodeTestData.Tree1));
            Assert.IsTrue(BinaryTreeCheckBalanced2RecursiveOptimizedComplete.CheckBalanced2OptimizedComplete(BinaryTreeNodeTestData.Tree2));
            Assert.IsTrue(BinaryTreeCheckBalanced2RecursiveOptimizedComplete.CheckBalanced2OptimizedComplete(BinaryTreeNodeTestData.Tree3));
            Assert.IsTrue(BinaryTreeCheckBalanced2RecursiveOptimizedComplete.CheckBalanced2OptimizedComplete(BinaryTreeNodeTestData.Tree4));
            Assert.IsTrue(BinaryTreeCheckBalanced2RecursiveOptimizedComplete.CheckBalanced2OptimizedComplete(BinaryTreeNodeTestData.Tree6));
            Assert.IsTrue(BinaryTreeCheckBalanced2RecursiveOptimizedComplete.CheckBalanced2OptimizedComplete(BinaryTreeNodeTestData.Tree7));
            Assert.IsTrue(BinaryTreeCheckBalanced2RecursiveOptimizedComplete.CheckBalanced2OptimizedComplete(BinaryTreeNodeTestData.Tree8));
            Assert.IsTrue(BinaryTreeCheckBalanced2RecursiveOptimizedComplete.CheckBalanced2OptimizedComplete(BinaryTreeNodeTestData.Tree9));
            Assert.IsTrue(BinaryTreeCheckBalanced2RecursiveOptimizedComplete.CheckBalanced2OptimizedComplete(BinaryTreeNodeTestData.Tree10));
            Assert.IsTrue(BinaryTreeCheckBalanced2RecursiveOptimizedComplete.CheckBalanced2OptimizedComplete(BinaryTreeNodeTestData.Tree11));
            Assert.IsTrue(BinaryTreeCheckBalanced2RecursiveOptimizedComplete.CheckBalanced2OptimizedComplete(BinaryTreeNodeTestData.Tree12));

            Assert.IsTrue(BinaryTreeCheckBalanced2RecursiveOptimizedComplete.CheckBalanced2OptimizedComplete(BinaryTreeNodeTestData.SubTree41));
            Assert.IsTrue(BinaryTreeCheckBalanced2RecursiveOptimizedComplete.CheckBalanced2OptimizedComplete(BinaryTreeNodeTestData.SubTree51));
            Assert.IsTrue(BinaryTreeCheckBalanced2RecursiveOptimizedComplete.CheckBalanced2OptimizedComplete(BinaryTreeNodeTestData.SubTree111));
            Assert.IsTrue(BinaryTreeCheckBalanced2RecursiveOptimizedComplete.CheckBalanced2OptimizedComplete(BinaryTreeNodeTestData.SubTree121));
        }
    }
}
