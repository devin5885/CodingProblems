using CodingProblems.BinaryTree.Node;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodingProblems.BinaryTree.GetHeight
{
    /// <summary>
    /// Tests GetHeight1RecursiveComplete.
    /// </summary>
    [TestClass]
    public class BinaryTreeGetHeight1RecursiveCompleteTests
    {
        /// <summary>
        /// Tests GetHeight1RecursiveComplete.
        /// </summary>
        /// <param name="data">The test data.</param>
        [DataTestMethod]
        [BinaryTreeDataSource]
        public void TestGetHeight1RecursiveComplete(BinaryTreeNodeTestData data)
        {
            Assert.AreEqual(data.Height, BinaryTreeGetHeight1RecursiveComplete.GetHeight1RecursiveComplete(data.Root));
        }
    }
}
