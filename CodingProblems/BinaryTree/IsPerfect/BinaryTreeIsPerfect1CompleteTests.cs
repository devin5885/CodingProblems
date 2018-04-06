using System;
using CodingProblems.BinaryTree.Node;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodingProblems.BinaryTree.IsPerfect
{
    /// <summary>
    /// Tests IsPerfect.
    /// </summary>
    [TestClass]
    public class BinaryTreeIsPerfect1CompleteTests
    {
        /// <summary>
        /// Run all tests.
        /// </summary>
        [TestMethod]
        public void TestIsPerfect1CompleteAllTests()
        {
            Assert.IsTrue(BinaryTreeIsPerfect1Complete.IsPerfect(null));
            Assert.IsTrue(BinaryTreeIsPerfect1Complete.IsPerfect(BinaryTreeNodeTestData.Tree1));
            Assert.IsFalse(BinaryTreeIsPerfect1Complete.IsPerfect(BinaryTreeNodeTestData.Tree2));
            Assert.IsFalse(BinaryTreeIsPerfect1Complete.IsPerfect(BinaryTreeNodeTestData.Tree3));
            Assert.IsTrue(BinaryTreeIsPerfect1Complete.IsPerfect(BinaryTreeNodeTestData.Tree4));
            Assert.IsTrue(BinaryTreeIsPerfect1Complete.IsPerfect(BinaryTreeNodeTestData.Tree5));
            Assert.IsTrue(BinaryTreeIsPerfect1Complete.IsPerfect(BinaryTreeNodeTestData.Tree6));
            Assert.IsTrue(BinaryTreeIsPerfect1Complete.IsPerfect(BinaryTreeNodeTestData.Tree7));
            Assert.IsFalse(BinaryTreeIsPerfect1Complete.IsPerfect(BinaryTreeNodeTestData.Tree8));
            Assert.IsFalse(BinaryTreeIsPerfect1Complete.IsPerfect(BinaryTreeNodeTestData.Tree9));
            Assert.IsFalse(BinaryTreeIsPerfect1Complete.IsPerfect(BinaryTreeNodeTestData.Tree10));
            Assert.IsFalse(BinaryTreeIsPerfect1Complete.IsPerfect(BinaryTreeNodeTestData.Tree11));
            Assert.IsTrue(BinaryTreeIsPerfect1Complete.IsPerfect(BinaryTreeNodeTestData.Tree12));
            Assert.IsFalse(BinaryTreeIsPerfect1Complete.IsPerfect(BinaryTreeNodeTestData.Tree13));
            Assert.IsFalse(BinaryTreeIsPerfect1Complete.IsPerfect(BinaryTreeNodeTestData.Tree14));
            Assert.IsFalse(BinaryTreeIsPerfect1Complete.IsPerfect(BinaryTreeNodeTestData.Tree15));
            Assert.IsFalse(BinaryTreeIsPerfect1Complete.IsPerfect(BinaryTreeNodeTestData.Tree16));
        }
    }
}
