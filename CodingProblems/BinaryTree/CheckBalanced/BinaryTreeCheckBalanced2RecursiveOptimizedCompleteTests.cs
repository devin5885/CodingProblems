using CodingProblems.BinaryTree.Node;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodingProblems.BinaryTree.CheckBalanced
{
    /// <summary>
    /// Tests for CheckBalanced2OptimizedComplete.
    /// </summary>
    [TestClass]
    public class BinaryTreeCheckBalanced2RecursiveOptimizedCompleteTests
    {
        /// <summary>
        /// Tests for CheckBalanced2OptimizedComplete.
        /// </summary>
        /// <param name="data">The test data.</param>
        [DataTestMethod]
        [BinaryTreeDataSource]
        public void TestCheckBalanced2OptimizedComplete(BinaryTreeNodeTestData data)
        {
            Assert.AreEqual(data.Balanced, BinaryTreeCheckBalanced2RecursiveOptimizedComplete.CheckBalanced2OptimizedComplete(data.Root));
        }
    }
}
