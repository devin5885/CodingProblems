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
            Assert.IsTrue(BinaryTreeIsBinarySearchTree1RecursiveComplete<int>.IsBinarySearchTree(null));
            Assert.IsTrue(BinaryTreeIsBinarySearchTree1RecursiveComplete<int>.IsBinarySearchTree(BinaryTreeNodeTestData.Tree1));
            Assert.IsTrue(BinaryTreeIsBinarySearchTree1RecursiveComplete<int>.IsBinarySearchTree(BinaryTreeNodeTestData.Tree2));
            Assert.IsFalse(BinaryTreeIsBinarySearchTree1RecursiveComplete<int>.IsBinarySearchTree(BinaryTreeNodeTestData.Tree3));
            Assert.IsTrue(BinaryTreeIsBinarySearchTree1RecursiveComplete<int>.IsBinarySearchTree(BinaryTreeNodeTestData.Tree4));
            Assert.IsTrue(BinaryTreeIsBinarySearchTree1RecursiveComplete<int>.IsBinarySearchTree(BinaryTreeNodeTestData.Tree5));
            Assert.IsFalse(BinaryTreeIsBinarySearchTree1RecursiveComplete<int>.IsBinarySearchTree(BinaryTreeNodeTestData.Tree6));
            Assert.IsFalse(BinaryTreeIsBinarySearchTree1RecursiveComplete<int>.IsBinarySearchTree(BinaryTreeNodeTestData.Tree7));
            Assert.IsTrue(BinaryTreeIsBinarySearchTree1RecursiveComplete<int>.IsBinarySearchTree(BinaryTreeNodeTestData.Tree8));
            Assert.IsTrue(BinaryTreeIsBinarySearchTree1RecursiveComplete<int>.IsBinarySearchTree(BinaryTreeNodeTestData.Tree9));
            Assert.IsTrue(BinaryTreeIsBinarySearchTree1RecursiveComplete<int>.IsBinarySearchTree(BinaryTreeNodeTestData.Tree10));
            Assert.IsTrue(BinaryTreeIsBinarySearchTree1RecursiveComplete<int>.IsBinarySearchTree(BinaryTreeNodeTestData.Tree11));
            Assert.IsTrue(BinaryTreeIsBinarySearchTree1RecursiveComplete<int>.IsBinarySearchTree(BinaryTreeNodeTestData.Tree12));
            Assert.IsFalse(BinaryTreeIsBinarySearchTree1RecursiveComplete<int>.IsBinarySearchTree(BinaryTreeNodeTestData.Tree13));
            Assert.IsFalse(BinaryTreeIsBinarySearchTree1RecursiveComplete<int>.IsBinarySearchTree(BinaryTreeNodeTestData.Tree14));
            Assert.IsFalse(BinaryTreeIsBinarySearchTree1RecursiveComplete<int>.IsBinarySearchTree(BinaryTreeNodeTestData.Tree15));
            Assert.IsFalse(BinaryTreeIsBinarySearchTree1RecursiveComplete<int>.IsBinarySearchTree(BinaryTreeNodeTestData.Tree16));

            Assert.IsTrue(BinaryTreeIsBinarySearchTree1RecursiveComplete<int>.IsBinarySearchTree(BinaryTreeNodeTestData.TreeFromSampleData1));
            Assert.IsFalse(BinaryTreeIsBinarySearchTree1RecursiveComplete<int>.IsBinarySearchTree(BinaryTreeNodeTestData.TreeFromSampleData2));
        }
    }
}
