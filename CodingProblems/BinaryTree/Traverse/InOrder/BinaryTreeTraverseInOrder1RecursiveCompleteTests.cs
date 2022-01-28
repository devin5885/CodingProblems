using CodingProblems.BinaryTree.Node;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodingProblems.BinaryTree.Traverse.InOrder
{
    /// <summary>
    /// Tests TraverseInOrder.
    /// </summary>
    [TestClass]
    public class BinaryTreeTraverseInOrder1RecursiveCompleteTests
    {
        /// <summary>
        /// Tests TraverseInOrder.
        /// </summary>
        /// <param name="data">The test data.</param>
        [DataTestMethod]
        [BinaryTreeDataSource]
        public void TestTraverseInOrder(BinaryTreeNodeTestData data)
        {
            var actual = BinaryTreeTraverseInOrder1RecursiveComplete.TraverseInOrder(data.Root);
            CollectionAssert.AreEqual(data.InOrder, actual);
        }
    }
}
