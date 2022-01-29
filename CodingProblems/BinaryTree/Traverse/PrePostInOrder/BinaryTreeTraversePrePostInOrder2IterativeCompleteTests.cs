using CodingProblems.BinaryTree.Node;
using CodingProblems.BinaryTree.Traverse.Helpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodingProblems.BinaryTree.Traverse.PrePostInOrder
{
    /// <summary>
    /// Tests Traverse.
    /// </summary>
    [TestClass]
    public class BinaryTreeTraversePrePostInOrder2IterativeCompleteTests
    {
        /// <summary>
        /// Tests Traverse with the PreOrderPending option.
        /// </summary>
        /// <param name="data">The test data.</param>
        [DataTestMethod]
        [BinaryTreeDataSource]
        public void TestTraverseWithPreOrderOption(BinaryTreeNodeTestData data)
        {
            var actual = BinaryTreeTraversePrePostInOrder2IterativeComplete.Traverse(data.Root, TraversalType.PreOrder);
            CollectionAssert.AreEqual(data.PreOrder, actual);
        }

        /// <summary>
        /// Tests Traverse with the InOrderPending option.
        /// </summary>
        /// <param name="data">The test data.</param>
        [DataTestMethod]
        [BinaryTreeDataSource]
        public void TestTraverseWithInOrderOption(BinaryTreeNodeTestData data)
        {
            var actual = BinaryTreeTraversePrePostInOrder2IterativeComplete.Traverse(data.Root, TraversalType.InOrder);
            CollectionAssert.AreEqual(data.InOrder, actual);
        }

        /// <summary>
        /// Tests Traverse with the PostOrderPending option.
        /// </summary>
        /// <param name="data">The test data.</param>
        [DataTestMethod]
        [BinaryTreeDataSource]
        public void TestTraverseWithPostOrderOption(BinaryTreeNodeTestData data)
        {
            var actual = BinaryTreeTraversePrePostInOrder2IterativeComplete.Traverse(data.Root, TraversalType.PostOrder);
            CollectionAssert.AreEqual(data.PostOrder, actual);
        }
    }
}