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
        /// Tests IsFull.
        /// </summary>
        /// <param name="data">The test data.</param>
        [DataTestMethod]
        [BinaryTreeDataSource]
        public void TestIsFull(BinaryTreeNodeTestData data)
        {
            Assert.AreEqual(data.Full, BinaryTreeIsFull1Complete.IsFull(data.Root));
        }
    }
}
