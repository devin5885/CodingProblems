using System;
using CodingProblems.BinaryTree.Node;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodingProblems.BinaryTree.IsComplete
{
    /// <summary>
    /// Tests IsBinaryTreeComplete.
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
            Assert.IsTrue(BinaryTreeIsComplete1Complete.IsBinaryTreeComplete(null));
            Assert.IsTrue(BinaryTreeIsComplete1Complete.IsBinaryTreeComplete(BinaryTreeNodeTestData.Tree1));
            Assert.IsTrue(BinaryTreeIsComplete1Complete.IsBinaryTreeComplete(BinaryTreeNodeTestData.Tree2));
            Assert.IsFalse(BinaryTreeIsComplete1Complete.IsBinaryTreeComplete(BinaryTreeNodeTestData.Tree3));
            Assert.IsTrue(BinaryTreeIsComplete1Complete.IsBinaryTreeComplete(BinaryTreeNodeTestData.Tree4));
            Assert.IsTrue(BinaryTreeIsComplete1Complete.IsBinaryTreeComplete(BinaryTreeNodeTestData.Tree5));
            Assert.IsTrue(BinaryTreeIsComplete1Complete.IsBinaryTreeComplete(BinaryTreeNodeTestData.Tree6));
            Assert.IsTrue(BinaryTreeIsComplete1Complete.IsBinaryTreeComplete(BinaryTreeNodeTestData.Tree7));
            Assert.IsTrue(BinaryTreeIsComplete1Complete.IsBinaryTreeComplete(BinaryTreeNodeTestData.Tree8));
            Assert.IsFalse(BinaryTreeIsComplete1Complete.IsBinaryTreeComplete(BinaryTreeNodeTestData.Tree9));
            Assert.IsTrue(BinaryTreeIsComplete1Complete.IsBinaryTreeComplete(BinaryTreeNodeTestData.Tree10));
            Assert.IsFalse(BinaryTreeIsComplete1Complete.IsBinaryTreeComplete(BinaryTreeNodeTestData.Tree11));
            Assert.IsTrue(BinaryTreeIsComplete1Complete.IsBinaryTreeComplete(BinaryTreeNodeTestData.Tree12));
            Assert.IsFalse(BinaryTreeIsComplete1Complete.IsBinaryTreeComplete(BinaryTreeNodeTestData.Tree13));
            Assert.IsFalse(BinaryTreeIsComplete1Complete.IsBinaryTreeComplete(BinaryTreeNodeTestData.Tree14));
            Assert.IsFalse(BinaryTreeIsComplete1Complete.IsBinaryTreeComplete(BinaryTreeNodeTestData.Tree15));
            Assert.IsFalse(BinaryTreeIsComplete1Complete.IsBinaryTreeComplete(BinaryTreeNodeTestData.Tree16));
        }
    }
}
