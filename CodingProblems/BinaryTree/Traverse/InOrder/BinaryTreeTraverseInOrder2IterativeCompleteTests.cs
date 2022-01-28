using CodingProblems.BinaryTree.Node;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodingProblems.BinaryTree.Traverse.InOrder
{
    /// <summary>
    /// Tests TraverseInOrder.
    /// </summary>
    [TestClass]
    public class BinaryTreeTraverseInOrder2IterativeCompleteTests
    {
        /// <summary>
        /// Tests TraverseInOrder.
        /// </summary>
        /// <param name="data">The test data.</param>
        [DataTestMethod]
        [BinaryTreeDataSource]
        public void TestTraverseInOrder(BinaryTreeNodeTestData data)
        {
            var actual = BinaryTreeTraverseInOrder2IterativeComplete.TraverseInOrder(data.Root);
            CollectionAssert.AreEqual(data.InOrder, actual);
        }
    }
}
