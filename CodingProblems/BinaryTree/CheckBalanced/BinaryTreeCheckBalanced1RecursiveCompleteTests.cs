using CodingProblems.BinaryTree.Node;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodingProblems.BinaryTree.CheckBalanced
{
    /// <summary>
    /// Tests for CheckBalanced1RecursiveComplete
    /// </summary>
    [TestClass]
    public class BinaryTreeCheckBalanced1RecursiveCompleteTests
    {
        /// <summary>
        /// Tests for CheckBalanced1RecursiveComplete
        /// </summary>
        /// <param name="data">The test data.</param>
        [DataTestMethod]
        [BinaryTreeDataSource]
        public void TestCheckBalanced1RecursiveComplete(BinaryTreeNodeTestData data)
        {
            Assert.AreEqual(data.Balanced, BinaryTreeCheckBalanced1RecursiveComplete.CheckBalanced1RecursiveComplete(data.Root));
        }
    }
}
