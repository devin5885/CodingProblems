using System;
using CodingProblems.BinaryTree.Node;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodingProblems.BinaryTree.IsFull
{
    /// <summary>
    /// Tests IsFull.
    /// </summary>
    [TestClass]
    public class BinaryTreeIsFull1CompleteTests
    {
        /// <summary>
        /// Run all tests.
        /// </summary>
        [TestMethod]
        public void TestIsFull1CompleteAllTests()
        {
            Assert.IsTrue(BinaryTreeIsFull1Complete.IsFull(null));
            Assert.IsTrue(BinaryTreeIsFull1Complete.IsFull(BinaryTreeNodeTestData.Tree1));
            Assert.IsFalse(BinaryTreeIsFull1Complete.IsFull(BinaryTreeNodeTestData.Tree2));
            Assert.IsFalse(BinaryTreeIsFull1Complete.IsFull(BinaryTreeNodeTestData.Tree3));
            Assert.IsTrue(BinaryTreeIsFull1Complete.IsFull(BinaryTreeNodeTestData.Tree4));
            Assert.IsTrue(BinaryTreeIsFull1Complete.IsFull(BinaryTreeNodeTestData.Tree5));
            Assert.IsTrue(BinaryTreeIsFull1Complete.IsFull(BinaryTreeNodeTestData.Tree6));
            Assert.IsTrue(BinaryTreeIsFull1Complete.IsFull(BinaryTreeNodeTestData.Tree7));
            Assert.IsFalse(BinaryTreeIsFull1Complete.IsFull(BinaryTreeNodeTestData.Tree8));
            Assert.IsFalse(BinaryTreeIsFull1Complete.IsFull(BinaryTreeNodeTestData.Tree9));
            Assert.IsTrue(BinaryTreeIsFull1Complete.IsFull(BinaryTreeNodeTestData.Tree10));
            Assert.IsFalse(BinaryTreeIsFull1Complete.IsFull(BinaryTreeNodeTestData.Tree11));
            Assert.IsTrue(BinaryTreeIsFull1Complete.IsFull(BinaryTreeNodeTestData.Tree12));
            Assert.IsTrue(BinaryTreeIsFull1Complete.IsFull(BinaryTreeNodeTestData.Tree12));
            Assert.IsFalse(BinaryTreeIsFull1Complete.IsFull(BinaryTreeNodeTestData.Tree13));
            Assert.IsFalse(BinaryTreeIsFull1Complete.IsFull(BinaryTreeNodeTestData.Tree14));
            Assert.IsFalse(BinaryTreeIsFull1Complete.IsFull(BinaryTreeNodeTestData.Tree15));
            Assert.IsFalse(BinaryTreeIsFull1Complete.IsFull(BinaryTreeNodeTestData.Tree16));
        }
    }
}
