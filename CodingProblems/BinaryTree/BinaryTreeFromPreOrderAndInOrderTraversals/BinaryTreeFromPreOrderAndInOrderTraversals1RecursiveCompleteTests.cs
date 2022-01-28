using System.Collections.Generic;
using CodingProblems.BinaryTree.Helpers.CompareBinaryTreeHelpers;
using CodingProblems.BinaryTree.Node;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodingProblems.BinaryTree.BinaryTreeFromPreOrderAndInOrderTraversals
{
    /// <summary>
    /// Tests FromPreOrderAndInOrderTraversals.
    /// </summary>
    [TestClass]
    public class BinaryTreeFromPreOrderAndInOrderTraversals1RecursiveCompleteTests
    {
        /// <summary>
        /// Tests FromPreOrderAndInOrderTraversals.
        /// </summary>
        /// <param name="data">The test data.</param>
        [DataTestMethod]
        [BinaryTreeDataSource]
        public void TestFromPreOrderAndInOrderTraversals(BinaryTreeNodeTestData data)
        {
            var actual = BinaryTreeFromPreOrderAndInOrderTraversals1RecursiveComplete<int>.FromPreOrderAndInOrderTraversals(data.PreOrder, data.InOrder);
            Assert.IsTrue(CompareBinaryTreeHelpers.CompareBinaryTrees(data.Root, actual));
        }

        /// <summary>
        /// Tests with null for the first parameter.
        /// </summary>
        [TestMethod]
        public void TestFromPreOrderAndInOrderTraversalsNullParams1()
        {
            var actual = BinaryTreeFromPreOrderAndInOrderTraversals1RecursiveComplete<int>.FromPreOrderAndInOrderTraversals(null, new List<int>());
            Assert.IsNull(actual);
        }

        /// <summary>
        /// Tests with null for the second parameter.
        /// </summary>
        [TestMethod]
        public void TestFromPreOrderAndInOrderTraversalsNullParams2()
        {
            var actual = BinaryTreeFromPreOrderAndInOrderTraversals1RecursiveComplete<int>.FromPreOrderAndInOrderTraversals(new List<int>(), null);
            Assert.IsNull(actual);
        }
    }
}
