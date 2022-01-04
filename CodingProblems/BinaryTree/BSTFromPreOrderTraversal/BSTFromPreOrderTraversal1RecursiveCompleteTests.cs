using CodingProblems.BinaryTree.Helpers.CompareBinaryTreeHelpers;
using CodingProblems.BinaryTree.Node;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodingProblems.BinaryTree.BSTFromPreOrderTraversal
{
    /// <summary>
    /// Tests Traverse.
    /// </summary>
    [TestClass]
    public class BSTFromPreOrderTraversal1RecursiveCompleteTests
    {
        /// <summary>
        /// Tests with test data Tree1
        /// </summary>
        [TestMethod]
        public void TestBSTFromPreOrderTraversalTree1()
        {
            var preOrder = BinaryTreeNodeTestData.Tree1PreOrder;
            var actual = BSTFromPreOrderTraversal1RecursiveComplete<int>.BSTFromPreOrderTraversal(preOrder);
            Assert.IsTrue(CompareBinaryTreeHelpers.CompareBinaryTrees(BinaryTreeNodeTestData.Tree1, actual));
        }

        /// <summary>
        /// Tests with test data Tree2
        /// </summary>
        [TestMethod]
        public void TestBSTFromPreOrderTraversalTree2()
        {
            var preOrder = BinaryTreeNodeTestData.Tree2PreOrder;
            var actual = BSTFromPreOrderTraversal1RecursiveComplete<int>.BSTFromPreOrderTraversal(preOrder);
            Assert.IsTrue(CompareBinaryTreeHelpers.CompareBinaryTrees(BinaryTreeNodeTestData.Tree2, actual));
        }

        /// <summary>
        /// Tests with test data Tree4
        /// </summary>
        [TestMethod]
        public void TestBSTFromPreOrderTraversalTree4()
        {
            var preOrder = BinaryTreeNodeTestData.Tree4PreOrder;
            var actual = BSTFromPreOrderTraversal1RecursiveComplete<int>.BSTFromPreOrderTraversal(preOrder);
            Assert.IsTrue(CompareBinaryTreeHelpers.CompareBinaryTrees(BinaryTreeNodeTestData.Tree4, actual));
        }

        /// <summary>
        /// Tests with test data Tree5
        /// </summary>
        [TestMethod]
        public void TestBSTFromPreOrderTraversalTree5()
        {
            var preOrder = BinaryTreeNodeTestData.Tree5PreOrder;
            var actual = BSTFromPreOrderTraversal1RecursiveComplete<int>.BSTFromPreOrderTraversal(preOrder);
            Assert.IsTrue(CompareBinaryTreeHelpers.CompareBinaryTrees(BinaryTreeNodeTestData.Tree5, actual));
        }

        /// <summary>
        /// Tests with test data Tree8
        /// </summary>
        [TestMethod]
        public void TestBSTFromPreOrderTraversalTree8()
        {
            var preOrder = BinaryTreeNodeTestData.Tree8PreOrder;
            var actual = BSTFromPreOrderTraversal1RecursiveComplete<int>.BSTFromPreOrderTraversal(preOrder);
            Assert.IsTrue(CompareBinaryTreeHelpers.CompareBinaryTrees(BinaryTreeNodeTestData.Tree8, actual));
        }

        /// <summary>
        /// Tests with test data Tree9
        /// </summary>
        [TestMethod]
        public void TestBSTFromPreOrderTraversalTree9()
        {
            var preOrder = BinaryTreeNodeTestData.Tree9PreOrder;
            var actual = BSTFromPreOrderTraversal1RecursiveComplete<int>.BSTFromPreOrderTraversal(preOrder);
            Assert.IsTrue(CompareBinaryTreeHelpers.CompareBinaryTrees(BinaryTreeNodeTestData.Tree9, actual));
        }

        /// <summary>
        /// Tests with test data Tree10
        /// </summary>
        [TestMethod]
        public void TestBSTFromPreOrderTraversalTree10()
        {
            var preOrder = BinaryTreeNodeTestData.Tree10PreOrder;
            var actual = BSTFromPreOrderTraversal1RecursiveComplete<int>.BSTFromPreOrderTraversal(preOrder);
            Assert.IsTrue(CompareBinaryTreeHelpers.CompareBinaryTrees(BinaryTreeNodeTestData.Tree10, actual));
        }

        /// <summary>
        /// Tests with test data Tree11
        /// </summary>
        [TestMethod]
        public void TestBSTFromPreOrderTraversalTree11()
        {
            var preOrder = BinaryTreeNodeTestData.Tree11PreOrder;
            var actual = BSTFromPreOrderTraversal1RecursiveComplete<int>.BSTFromPreOrderTraversal(preOrder);
            Assert.IsTrue(CompareBinaryTreeHelpers.CompareBinaryTrees(BinaryTreeNodeTestData.Tree11, actual));
        }

        /// <summary>
        /// Tests with test data Tree12
        /// </summary>
        [TestMethod]
        public void TestBSTFromPreOrderTraversalTree12()
        {
            var preOrder = BinaryTreeNodeTestData.Tree12PreOrder;
            var actual = BSTFromPreOrderTraversal1RecursiveComplete<int>.BSTFromPreOrderTraversal(preOrder);
            Assert.IsTrue(CompareBinaryTreeHelpers.CompareBinaryTrees(BinaryTreeNodeTestData.Tree12, actual));
        }

        /// <summary>
        /// Tests with test data SampleTree1
        /// </summary>
        [TestMethod]
        public void TestBSTFromPreOrderTraversalTreeFromSampleData1()
        {
            var preOrder = BinaryTreeNodeTestData.TreeFromSampleData1PreOrder;
            var actual = BSTFromPreOrderTraversal1RecursiveComplete<int>.BSTFromPreOrderTraversal(preOrder);
            Assert.IsTrue(CompareBinaryTreeHelpers.CompareBinaryTrees(BinaryTreeNodeTestData.TreeFromSampleData1, actual));
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
