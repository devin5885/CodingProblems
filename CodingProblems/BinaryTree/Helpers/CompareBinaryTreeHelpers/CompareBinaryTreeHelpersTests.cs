using CodingProblems.BinaryTree.Node;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodingProblems.BinaryTree.Helpers.CompareBinaryTreeHelpers
{
    /// <summary>
    ///  Tests for CompareBinaryTreeHelpers.CompareBinaryTrees
    /// </summary>
    [TestClass]
    public class CompareBinaryTreeHelpersTests
    {
        /// <summary>
        /// Compare trees Null 1. (No-Match)
        /// </summary>
        [TestMethod]
        public void CompareBinaryTrees1NoMatchNull1_ShouldReturnFalse()
        {
            Assert.IsFalse(CompareBinaryTreeHelpers.CompareBinaryTrees(BinaryTreeNodeTestDataHolder.Tree1.Root, null));
        }

        /// <summary>
        /// Compare trees Null 2. (No-Match)
        /// </summary>
        [TestMethod]
        public void CompareBinaryTrees1NoMatchNull2_ShouldReturnFale()
        {
            Assert.IsFalse(CompareBinaryTreeHelpers.CompareBinaryTrees(BinaryTreeNodeTestDataHolder.Tree2.Root, null));
        }

        /// <summary>
        /// Compare trees 1 to 2. (No-Match)
        /// </summary>
        [TestMethod]
        public void CompareBinaryTrees1To2NoMatch_ShouldReturnFale()
        {
            Assert.IsFalse(CompareBinaryTreeHelpers.CompareBinaryTrees(BinaryTreeNodeTestDataHolder.Tree1.Root, BinaryTreeNodeTestDataHolder.Tree2.Root));
        }

        /// <summary>
        /// Compare trees 1 to 3. (No-Match)
        /// </summary>
        [TestMethod]
        public void CompareBinaryTrees1To3NoMatch_ShouldReturnFale()
        {
            Assert.IsFalse(CompareBinaryTreeHelpers.CompareBinaryTrees(BinaryTreeNodeTestDataHolder.Tree1.Root, BinaryTreeNodeTestDataHolder.Tree3.Root));
        }

        /// <summary>
        /// Compare trees 2 to 3. (No-Match)
        /// </summary>
        [TestMethod]
        public void CompareBinaryTrees2To3NoMatch_ShouldReturnFale()
        {
            Assert.IsFalse(CompareBinaryTreeHelpers.CompareBinaryTrees(BinaryTreeNodeTestDataHolder.Tree2.Root, BinaryTreeNodeTestDataHolder.Tree3.Root));
        }

        /// <summary>
        /// Compare trees 4 to 5. (No-Match)
        /// </summary>
        [TestMethod]
        public void CompareBinaryTrees4To5NoMatch_ShouldReturnFale()
        {
            Assert.IsFalse(CompareBinaryTreeHelpers.CompareBinaryTrees(BinaryTreeNodeTestDataHolder.Tree4.Root, BinaryTreeNodeTestDataHolder.Tree5.Root));
        }

        /// <summary>
        /// Compare trees 6 to 7. (No-Match)
        /// </summary>
        [TestMethod]
        public void CompareBinaryTrees6To7NoMatch_ShouldReturnFale()
        {
            Assert.IsFalse(CompareBinaryTreeHelpers.CompareBinaryTrees(BinaryTreeNodeTestDataHolder.Tree6.Root, BinaryTreeNodeTestDataHolder.Tree7.Root));
        }

        /// <summary>
        /// Compare trees. (Match)
        /// </summary>
        /// <param name="data">The test data.</param>
        [DataTestMethod]
        [BinaryTreeDataSource]
        public void CompareBinaryTreesMatch_ShouldReturnTrue(BinaryTreeNodeTestData data)
        {
            Assert.IsTrue(CompareBinaryTreeHelpers.CompareBinaryTrees(data.Root, data.Root));
        }
    }
}
