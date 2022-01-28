﻿using CodingProblems.BinaryTree.Node;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodingProblems.BinaryTree.Traverse.PreOrder
{
    /// <summary>
    /// Tests TraversePreOrder.
    /// </summary>
    [TestClass]
    public class BinaryTreeTraversePreOrder1RecursiveCompleteTests
    {
        /// <summary>
        /// Tests TraversePreOrder.
        /// </summary>
        /// <param name="data">The test data.</param>
        [DataTestMethod]
        [BinaryTreeDataSource]
        public void TestTraversePreOrder(BinaryTreeNodeTestData data)
        {
            var actual = BinaryTreeTraversePreOrder1RecursiveComplete.TraversePreOrder(data.Root);
            CollectionAssert.AreEqual(data.PreOrder, actual);
        }
    }
}
