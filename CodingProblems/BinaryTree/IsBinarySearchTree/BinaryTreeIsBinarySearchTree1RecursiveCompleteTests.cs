using System;
using CodingProblems.BinaryTree.Node;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodingProblems.BinaryTree.IsBinarySearchTree
{
    /// <summary>
    /// Tests IsBinarySearchTree.
    /// </summary>
    [TestClass]
    public class BinaryTreeIsBinarySearchTree1RecursiveCompleteTests
    {
        /// <summary>
        /// Tests IsBinarySearchTree.
        /// </summary>
        /// <param name="data">The test data.</param>
        [DataTestMethod]
        [BinaryTreeDataSource]
        public void TestIsBinarySearchTree(BinaryTreeNodeTestData data)
        {
            Assert.AreEqual(data.IsBST, BinaryTreeIsBinarySearchTree1RecursiveComplete<int>.IsBinarySearchTree(data.Root));
        }
    }
}
