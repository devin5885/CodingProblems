using CodingProblems.BinaryTree.Helpers.CompareBinaryTreeHelpers;
using CodingProblems.BinaryTree.Node;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodingProblems.BinaryTree.BSTFromPreOrderTraversal
{
    /// <summary>
    /// Tests BSTFromPreOrderTraversal.
    /// </summary>
    [TestClass]
    public class BSTFromPreOrderTraversal1RecursiveCompleteTests
    {
        /// <summary>
        /// Tests BSTFromPreOrderTraversal.
        /// </summary>
        /// <param name="data">The test data.</param>
        [DataTestMethod]
        [BinaryTreeDataSource]
        public void TestBSTFromPreOrderTraversal(BinaryTreeNodeTestData data)
        {
            // Test only works for BST.
            if (data.IsBST)
            {
                var actual = BSTFromPreOrderTraversal1RecursiveComplete<int>.BSTFromPreOrderTraversal(data.PreOrder);
                Assert.IsTrue(CompareBinaryTreeHelpers.CompareBinaryTrees(data.Root, actual));
            }
        }

        /// <summary>
        /// Tests with null for the first parameter.
        /// </summary>
        [TestMethod]
        public void TestBSTFromPreOrderTraversalTreeNullParams1()
        {
            var actual = BSTFromPreOrderTraversal1RecursiveComplete<int>.BSTFromPreOrderTraversal(null);
            Assert.IsNull(actual);
        }
    }
}
