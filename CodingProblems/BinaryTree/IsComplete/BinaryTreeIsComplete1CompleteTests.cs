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
        /// Tests IsComplete.
        /// </summary>
        /// <param name="data">The test data.</param>
        [DataTestMethod]
        [BinaryTreeDataSource]
        public void TestIsComplete(BinaryTreeNodeTestData data)
        {
            Assert.AreEqual(data.Complete, BinaryTreeIsComplete1Complete.IsComplete(data.Root));
        }
    }
}
