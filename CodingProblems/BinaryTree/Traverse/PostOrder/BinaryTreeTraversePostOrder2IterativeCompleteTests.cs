using CodingProblems.BinaryTree.Node;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodingProblems.BinaryTree.Traverse.PostOrder
{
    /// <summary>
    /// Tests TraversePostOrder.
    /// </summary>
    [TestClass]
    public class BinaryTreeTraversePostOrder2IterativeCompleteTests
    {
        /// <summary>
        /// Tests TraversePostOrder.
        /// </summary>
        /// <param name="data">The test data.</param>
        [DataTestMethod]
        [BinaryTreeDataSource]
        public void TestTraversePostOrder(BinaryTreeNodeTestData data)
        {
            var actual = BinaryTreeTraversePostOrder2IterativeComplete.TraversePostOrder(data.Root);
            CollectionAssert.AreEqual(data.PostOrder, actual);
        }
    }
}
