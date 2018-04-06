using System;
using CodingProblems.BinaryTree.Node;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodingProblems.BinaryTree.IsBinarySearchTree
{
    /// <summary>
    /// Tests IsPerfect.
    /// </summary>
    [TestClass]
    public class BinaryTreeIsBinarySearchTree1RecursiveCompleteTests
    {
        /// <summary>
        /// Run all tests.
        /// </summary>
        [TestMethod]
        public void TestIsBinarySearchTree1RecursiveCompleteAllTests()
        {
            Assert.IsTrue(BinaryTreeIsBinarySearchTree1RecursiveComplete.IsBinarySearchTree(null));
            Assert.IsTrue(BinaryTreeIsBinarySearchTree1RecursiveComplete.IsBinarySearchTree(BinaryTreeNodeTestData.Tree1));
            Assert.IsTrue(BinaryTreeIsBinarySearchTree1RecursiveComplete.IsBinarySearchTree(BinaryTreeNodeTestData.Tree2));
            Assert.IsFalse(BinaryTreeIsBinarySearchTree1RecursiveComplete.IsBinarySearchTree(BinaryTreeNodeTestData.Tree3));
            Assert.IsTrue(BinaryTreeIsBinarySearchTree1RecursiveComplete.IsBinarySearchTree(BinaryTreeNodeTestData.Tree4));
            Assert.IsTrue(BinaryTreeIsBinarySearchTree1RecursiveComplete.IsBinarySearchTree(BinaryTreeNodeTestData.Tree5));
            Assert.IsFalse(BinaryTreeIsBinarySearchTree1RecursiveComplete.IsBinarySearchTree(BinaryTreeNodeTestData.Tree6));
            Assert.IsFalse(BinaryTreeIsBinarySearchTree1RecursiveComplete.IsBinarySearchTree(BinaryTreeNodeTestData.Tree7));
            Assert.IsTrue(BinaryTreeIsBinarySearchTree1RecursiveComplete.IsBinarySearchTree(BinaryTreeNodeTestData.Tree8));
            Assert.IsTrue(BinaryTreeIsBinarySearchTree1RecursiveComplete.IsBinarySearchTree(BinaryTreeNodeTestData.Tree9));
            Assert.IsTrue(BinaryTreeIsBinarySearchTree1RecursiveComplete.IsBinarySearchTree(BinaryTreeNodeTestData.Tree10));
            Assert.IsTrue(BinaryTreeIsBinarySearchTree1RecursiveComplete.IsBinarySearchTree(BinaryTreeNodeTestData.Tree11));
            Assert.IsTrue(BinaryTreeIsBinarySearchTree1RecursiveComplete.IsBinarySearchTree(BinaryTreeNodeTestData.Tree12));
            Assert.IsFalse(BinaryTreeIsBinarySearchTree1RecursiveComplete.IsBinarySearchTree(BinaryTreeNodeTestData.Tree13));
            Assert.IsFalse(BinaryTreeIsBinarySearchTree1RecursiveComplete.IsBinarySearchTree(BinaryTreeNodeTestData.Tree14));
            Assert.IsFalse(BinaryTreeIsBinarySearchTree1RecursiveComplete.IsBinarySearchTree(BinaryTreeNodeTestData.Tree15));
            Assert.IsFalse(BinaryTreeIsBinarySearchTree1RecursiveComplete.IsBinarySearchTree(BinaryTreeNodeTestData.Tree16));
        }
    }
}
