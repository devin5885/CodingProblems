using CodingProblems.BinaryTree.Node;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodingProblems.BinaryTree.GetHeight
{
    /// <summary>
    /// Tests GetHeight2IterativeComplete.
    /// </summary>
    [TestClass]
    public class BinaryTreeGetHeight2IterativeCompleteTests
    {
        /// <summary>
        /// Tests GetHeight2IterativeComplete.
        /// </summary>
        /// <param name="data">The test data.</param>
        [DataTestMethod]
        [BinaryTreeDataSource]
        public void TestGetHeight2IterativeComplete(BinaryTreeNodeTestData data)
        {
            Assert.AreEqual(data.Height, BinaryTreeGetHeight2IterativeComplete.GetHeight2IterativeComplete(data.Root));
        }
    }
}
