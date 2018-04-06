using System;
using CodingProblems.BinaryTree.Node;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodingProblems.BinaryTree.IsComplete
{
    /// <summary>
    /// Tests IsComplete.
    /// </summary>
    [TestClass]
    public class BinaryTreeIsComplete1CompleteTests
    {
        /// <summary>
        /// Run all tests.
        /// </summary>
        [TestMethod]
        public void TestIsBinaryTreeComplete1CompleteAllTests()
        {
            Assert.IsTrue(BinaryTreeIsComplete1Complete.IsComplete(null));
            Assert.IsTrue(BinaryTreeIsComplete1Complete.IsComplete(BinaryTreeNodeTestData.Tree1));
            Assert.IsTrue(BinaryTreeIsComplete1Complete.IsComplete(BinaryTreeNodeTestData.Tree2));
            Assert.IsFalse(BinaryTreeIsComplete1Complete.IsComplete(BinaryTreeNodeTestData.Tree3));
            Assert.IsTrue(BinaryTreeIsComplete1Complete.IsComplete(BinaryTreeNodeTestData.Tree4));
            Assert.IsTrue(BinaryTreeIsComplete1Complete.IsComplete(BinaryTreeNodeTestData.Tree5));
            Assert.IsTrue(BinaryTreeIsComplete1Complete.IsComplete(BinaryTreeNodeTestData.Tree6));
            Assert.IsTrue(BinaryTreeIsComplete1Complete.IsComplete(BinaryTreeNodeTestData.Tree7));
            Assert.IsTrue(BinaryTreeIsComplete1Complete.IsComplete(BinaryTreeNodeTestData.Tree8));
            Assert.IsFalse(BinaryTreeIsComplete1Complete.IsComplete(BinaryTreeNodeTestData.Tree9));
            Assert.IsTrue(BinaryTreeIsComplete1Complete.IsComplete(BinaryTreeNodeTestData.Tree10));
            Assert.IsFalse(BinaryTreeIsComplete1Complete.IsComplete(BinaryTreeNodeTestData.Tree11));
            Assert.IsTrue(BinaryTreeIsComplete1Complete.IsComplete(BinaryTreeNodeTestData.Tree12));
            Assert.IsFalse(BinaryTreeIsComplete1Complete.IsComplete(BinaryTreeNodeTestData.Tree13));
            Assert.IsFalse(BinaryTreeIsComplete1Complete.IsComplete(BinaryTreeNodeTestData.Tree14));
            Assert.IsFalse(BinaryTreeIsComplete1Complete.IsComplete(BinaryTreeNodeTestData.Tree15));
            Assert.IsFalse(BinaryTreeIsComplete1Complete.IsComplete(BinaryTreeNodeTestData.Tree16));
        }
    }
}
