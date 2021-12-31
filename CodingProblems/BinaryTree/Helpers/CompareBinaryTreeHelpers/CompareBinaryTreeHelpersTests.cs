using CodingProblems.BinaryTree.Node;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodingProblems.BinaryTree.Helpers.CompareBinaryTreeHelpers
{
    /// <summary>
    ///  Tests for CompareBinaryTreeHelpers
    /// </summary>
    [TestClass]
    public class CompareBinaryTreeHelpersTests
    {
        /// <summary>
        /// Compare trees Null 1. (No-Match)
        /// </summary>
        [TestMethod]
        public void CompareBinaryTrees1NoMatchNull1_ShouldReturnFale()
        {
            Assert.IsFalse(CompareBinaryTreeHelpers.CompareBinaryTrees(BinaryTreeNodeTestData.Tree1, null));
        }

        /// <summary>
        /// Compare trees Null 2. (No-Match)
        /// </summary>
        [TestMethod]
        public void CompareBinaryTrees1NoMatchNull2_ShouldReturnFale()
        {
            Assert.IsFalse(CompareBinaryTreeHelpers.CompareBinaryTrees(BinaryTreeNodeTestData.Tree2, null));
        }

        /// <summary>
        /// Compare trees 1 to 2. (No-Match)
        /// </summary>
        [TestMethod]
        public void CompareBinaryTrees1To2NoMatch_ShouldReturnFale()
        {
            Assert.IsFalse(CompareBinaryTreeHelpers.CompareBinaryTrees(BinaryTreeNodeTestData.Tree1, BinaryTreeNodeTestData.Tree2));
        }

        /// <summary>
        /// Compare trees 1 to 3. (No-Match)
        /// </summary>
        [TestMethod]
        public void CompareBinaryTrees1To3NoMatch_ShouldReturnFale()
        {
            Assert.IsFalse(CompareBinaryTreeHelpers.CompareBinaryTrees(BinaryTreeNodeTestData.Tree1, BinaryTreeNodeTestData.Tree3));
        }

        /// <summary>
        /// Compare trees 2 to 3. (No-Match)
        /// </summary>
        [TestMethod]
        public void CompareBinaryTrees2To3NoMatch_ShouldReturnFale()
        {
            Assert.IsFalse(CompareBinaryTreeHelpers.CompareBinaryTrees(BinaryTreeNodeTestData.Tree2, BinaryTreeNodeTestData.Tree3));
        }

        /// <summary>
        /// Compare trees 4 to 5. (No-Match)
        /// </summary>
        [TestMethod]
        public void CompareBinaryTrees4To5NoMatch_ShouldReturnFale()
        {
            Assert.IsFalse(CompareBinaryTreeHelpers.CompareBinaryTrees(BinaryTreeNodeTestData.Tree4, BinaryTreeNodeTestData.Tree5));
        }

        /// <summary>
        /// Compare trees 6 to 7. (No-Match)
        /// </summary>
        [TestMethod]
        public void CompareBinaryTrees6To7NoMatch_ShouldReturnFale()
        {
            Assert.IsFalse(CompareBinaryTreeHelpers.CompareBinaryTrees(BinaryTreeNodeTestData.Tree6, BinaryTreeNodeTestData.Tree7));
        }

        /// <summary>
        /// Compare trees 1. (Match)
        /// </summary>
        [TestMethod]
        public void CompareBinaryTrees1Match_ShouldReturnTrue()
        {
            Assert.IsTrue(CompareBinaryTreeHelpers.CompareBinaryTrees(BinaryTreeNodeTestData.Tree1, BinaryTreeNodeTestData.Tree1));
        }

        /// <summary>
        /// Compare trees 2. (Match)
        /// </summary>
        [TestMethod]
        public void CompareBinaryTrees2Match_ShouldReturnTrue()
        {
            Assert.IsTrue(CompareBinaryTreeHelpers.CompareBinaryTrees(BinaryTreeNodeTestData.Tree2, BinaryTreeNodeTestData.Tree2));
        }

        /// <summary>
        /// Compare trees 3. (Match)
        /// </summary>
        [TestMethod]
        public void CompareBinaryTrees3Match_ShouldReturnTrue()
        {
            Assert.IsTrue(CompareBinaryTreeHelpers.CompareBinaryTrees(BinaryTreeNodeTestData.Tree3, BinaryTreeNodeTestData.Tree3));
        }

        /// <summary>
        /// Compare trees 4. (Match)
        /// </summary>
        [TestMethod]
        public void CompareBinaryTrees4_MatchShouldReturnTrue()
        {
            Assert.IsTrue(CompareBinaryTreeHelpers.CompareBinaryTrees(BinaryTreeNodeTestData.Tree4, BinaryTreeNodeTestData.Tree4));
        }

        /// <summary>
        /// Compare trees 5. (Match)
        /// </summary>
        [TestMethod]
        public void CompareBinaryTrees5_MatchShouldReturnTrue()
        {
            Assert.IsTrue(CompareBinaryTreeHelpers.CompareBinaryTrees(BinaryTreeNodeTestData.Tree5, BinaryTreeNodeTestData.Tree5));
        }

        /// <summary>
        /// Compare trees 6. (Match)
        /// </summary>
        [TestMethod]
        public void CompareBinaryTrees6_MatchShouldReturnTrue()
        {
            Assert.IsTrue(CompareBinaryTreeHelpers.CompareBinaryTrees(BinaryTreeNodeTestData.Tree6, BinaryTreeNodeTestData.Tree6));
        }

        /// <summary>
        /// Compare trees 7. (Match)
        /// </summary>
        [TestMethod]
        public void CompareBinaryTrees7_MatchShouldReturnTrue()
        {
            Assert.IsTrue(CompareBinaryTreeHelpers.CompareBinaryTrees(BinaryTreeNodeTestData.Tree7, BinaryTreeNodeTestData.Tree7));
        }

        /// <summary>
        /// Compare trees 8. (Match)
        /// </summary>
        [TestMethod]
        public void CompareBinaryTrees8_MatchShouldReturnTrue()
        {
            Assert.IsTrue(CompareBinaryTreeHelpers.CompareBinaryTrees(BinaryTreeNodeTestData.Tree8, BinaryTreeNodeTestData.Tree8));
        }

        /// <summary>
        /// Compare trees 9. (Match)
        /// </summary>
        [TestMethod]
        public void CompareBinaryTrees9_MatchShouldReturnTrue()
        {
            Assert.IsTrue(CompareBinaryTreeHelpers.CompareBinaryTrees(BinaryTreeNodeTestData.Tree9, BinaryTreeNodeTestData.Tree9));
        }

        /// <summary>
        /// Compare trees 10. (Match)
        /// </summary>
        [TestMethod]
        public void CompareBinaryTrees10_MatchShouldReturnTrue()
        {
            Assert.IsTrue(CompareBinaryTreeHelpers.CompareBinaryTrees(BinaryTreeNodeTestData.Tree10, BinaryTreeNodeTestData.Tree10));
        }

        /// <summary>
        /// Compare trees 11. (Match)
        /// </summary>
        [TestMethod]
        public void CompareBinaryTrees11_MatchShouldReturnTrue()
        {
            Assert.IsTrue(CompareBinaryTreeHelpers.CompareBinaryTrees(BinaryTreeNodeTestData.Tree11, BinaryTreeNodeTestData.Tree11));
        }

        /// <summary>
        /// Compare trees 12. (Match)
        /// </summary>
        [TestMethod]
        public void CompareBinaryTrees12_MatchShouldReturnTrue()
        {
            Assert.IsTrue(CompareBinaryTreeHelpers.CompareBinaryTrees(BinaryTreeNodeTestData.Tree12, BinaryTreeNodeTestData.Tree12));
        }

        /// <summary>
        /// Compare trees 13. (Match)
        /// </summary>
        [TestMethod]
        public void CompareBinaryTrees13_MatchShouldReturnTrue()
        {
            Assert.IsTrue(CompareBinaryTreeHelpers.CompareBinaryTrees(BinaryTreeNodeTestData.Tree13, BinaryTreeNodeTestData.Tree13));
        }

        /// <summary>
        /// Compare trees 14. (Match)
        /// </summary>
        [TestMethod]
        public void CompareBinaryTrees14_MatchShouldReturnTrue()
        {
            Assert.IsTrue(CompareBinaryTreeHelpers.CompareBinaryTrees(BinaryTreeNodeTestData.Tree14, BinaryTreeNodeTestData.Tree14));
        }

        /// <summary>
        /// Compare trees 15. (Match)
        /// </summary>
        [TestMethod]
        public void CompareBinaryTrees15_MatchShouldReturnTrue()
        {
            Assert.IsTrue(CompareBinaryTreeHelpers.CompareBinaryTrees(BinaryTreeNodeTestData.Tree15, BinaryTreeNodeTestData.Tree15));
        }
    }
}
