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
        /// Tests IsPerfect.
        /// </summary>
        /// <param name="data">The test data.</param>
        [DataTestMethod]
        [BinaryTreeDataSource]
        public void TestIsPerfect(BinaryTreeNodeTestData data)
        {
            Assert.AreEqual(data.Perfect, BinaryTreeIsPerfect1Complete.IsPerfect(data.Root));
        }
    }
}
