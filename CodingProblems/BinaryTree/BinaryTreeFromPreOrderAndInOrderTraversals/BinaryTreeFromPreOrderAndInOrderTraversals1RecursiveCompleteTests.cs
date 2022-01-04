using CodingProblems.BinaryTree.Helpers.CompareBinaryTreeHelpers;
using CodingProblems.BinaryTree.Node;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodingProblems.BinaryTree.BinaryTreeFromPreOrderAndInOrderTraversals
{
    /// <summary>
    /// Tests Traverse.
    /// </summary>
    [TestClass]
    public class BinaryTreeFromPreOrderAndInOrderTraversals1RecursiveCompleteTests
    {
        /// <summary>
        /// Tests with test data Tree1
        /// </summary>
        [TestMethod]
        public void TestFromPreOrderAndInOrderTraversalsTree1()
        {
            var preOrder = BinaryTreeNodeTestData.Tree1PreOrder;
            var inOrder = BinaryTreeNodeTestData.Tree1InOrder;
            var actual = BinaryTreeFromPreOrderAndInOrderTraversals1RecursiveComplete<int>.FromPreOrderAndInOrderTraversals(preOrder, inOrder);
            Assert.IsTrue(CompareBinaryTreeHelpers.CompareBinaryTrees(BinaryTreeNodeTestData.Tree1, actual));
        }

        /// <summary>
        /// Tests with test data Tree2
        /// </summary>
        [TestMethod]
        public void TestFromPreOrderAndInOrderTraversalsTree2()
        {
            var preOrder = BinaryTreeNodeTestData.Tree2PreOrder;
            var inOrder = BinaryTreeNodeTestData.Tree2InOrder;
            var actual = BinaryTreeFromPreOrderAndInOrderTraversals1RecursiveComplete<int>.FromPreOrderAndInOrderTraversals(preOrder, inOrder);
            Assert.IsTrue(CompareBinaryTreeHelpers.CompareBinaryTrees(BinaryTreeNodeTestData.Tree2, actual));
        }

        /// <summary>
        /// Tests with test data Tree3
        /// </summary>
        [TestMethod]
        public void TestFromPreOrderAndInOrderTraversalsTree3()
        {
            var preOrder = BinaryTreeNodeTestData.Tree3PreOrder;
            var inOrder = BinaryTreeNodeTestData.Tree3InOrder;
            var actual = BinaryTreeFromPreOrderAndInOrderTraversals1RecursiveComplete<int>.FromPreOrderAndInOrderTraversals(preOrder, inOrder);
            Assert.IsTrue(CompareBinaryTreeHelpers.CompareBinaryTrees(BinaryTreeNodeTestData.Tree3, actual));
        }

        /// <summary>
        /// Tests with test data Tree4
        /// </summary>
        [TestMethod]
        public void TestFromPreOrderAndInOrderTraversalsTree4()
        {
            var preOrder = BinaryTreeNodeTestData.Tree4PreOrder;
            var inOrder = BinaryTreeNodeTestData.Tree4InOrder;
            var actual = BinaryTreeFromPreOrderAndInOrderTraversals1RecursiveComplete<int>.FromPreOrderAndInOrderTraversals(preOrder, inOrder);
            Assert.IsTrue(CompareBinaryTreeHelpers.CompareBinaryTrees(BinaryTreeNodeTestData.Tree4, actual));
        }

        /// <summary>
        /// Tests with test data Tree5
        /// </summary>
        [TestMethod]
        public void TestFromPreOrderAndInOrderTraversalsTree5()
        {
            var preOrder = BinaryTreeNodeTestData.Tree5PreOrder;
            var inOrder = BinaryTreeNodeTestData.Tree5InOrder;
            var actual = BinaryTreeFromPreOrderAndInOrderTraversals1RecursiveComplete<int>.FromPreOrderAndInOrderTraversals(preOrder, inOrder);
            Assert.IsTrue(CompareBinaryTreeHelpers.CompareBinaryTrees(BinaryTreeNodeTestData.Tree5, actual));
        }

        /// <summary>
        /// Tests with test data Tree6
        /// </summary>
        [TestMethod]
        public void TestFromPreOrderAndInOrderTraversalsTree6()
        {
            var preOrder = BinaryTreeNodeTestData.Tree6PreOrder;
            var inOrder = BinaryTreeNodeTestData.Tree6InOrder;
            var actual = BinaryTreeFromPreOrderAndInOrderTraversals1RecursiveComplete<int>.FromPreOrderAndInOrderTraversals(preOrder, inOrder);
            Assert.IsTrue(CompareBinaryTreeHelpers.CompareBinaryTrees(BinaryTreeNodeTestData.Tree6, actual));
        }

        /// <summary>
        /// Tests with test data Tree7
        /// </summary>
        [TestMethod]
        public void TestFromPreOrderAndInOrderTraversalsTree7()
        {
            var preOrder = BinaryTreeNodeTestData.Tree7PreOrder;
            var inOrder = BinaryTreeNodeTestData.Tree7InOrder;
            var actual = BinaryTreeFromPreOrderAndInOrderTraversals1RecursiveComplete<int>.FromPreOrderAndInOrderTraversals(preOrder, inOrder);
            Assert.IsTrue(CompareBinaryTreeHelpers.CompareBinaryTrees(BinaryTreeNodeTestData.Tree7, actual));
        }

        /// <summary>
        /// Tests with test data Tree8
        /// </summary>
        [TestMethod]
        public void TestFromPreOrderAndInOrderTraversalsTree8()
        {
            var preOrder = BinaryTreeNodeTestData.Tree8PreOrder;
            var inOrder = BinaryTreeNodeTestData.Tree8InOrder;
            var actual = BinaryTreeFromPreOrderAndInOrderTraversals1RecursiveComplete<int>.FromPreOrderAndInOrderTraversals(preOrder, inOrder);
            Assert.IsTrue(CompareBinaryTreeHelpers.CompareBinaryTrees(BinaryTreeNodeTestData.Tree8, actual));
        }

        /// <summary>
        /// Tests with test data Tree9
        /// </summary>
        [TestMethod]
        public void TestFromPreOrderAndInOrderTraversalsTree9()
        {
            var preOrder = BinaryTreeNodeTestData.Tree9PreOrder;
            var inOrder = BinaryTreeNodeTestData.Tree9InOrder;
            var actual = BinaryTreeFromPreOrderAndInOrderTraversals1RecursiveComplete<int>.FromPreOrderAndInOrderTraversals(preOrder, inOrder);
            Assert.IsTrue(CompareBinaryTreeHelpers.CompareBinaryTrees(BinaryTreeNodeTestData.Tree9, actual));
        }

        /// <summary>
        /// Tests with test data Tree10
        /// </summary>
        [TestMethod]
        public void TestFromPreOrderAndInOrderTraversalsTree10()
        {
            var preOrder = BinaryTreeNodeTestData.Tree10PreOrder;
            var inOrder = BinaryTreeNodeTestData.Tree10InOrder;
            var actual = BinaryTreeFromPreOrderAndInOrderTraversals1RecursiveComplete<int>.FromPreOrderAndInOrderTraversals(preOrder, inOrder);
            Assert.IsTrue(CompareBinaryTreeHelpers.CompareBinaryTrees(BinaryTreeNodeTestData.Tree10, actual));
        }

        /// <summary>
        /// Tests with test data Tree11
        /// </summary>
        [TestMethod]
        public void TestFromPreOrderAndInOrderTraversalsTree11()
        {
            var preOrder = BinaryTreeNodeTestData.Tree11PreOrder;
            var inOrder = BinaryTreeNodeTestData.Tree11InOrder;
            var actual = BinaryTreeFromPreOrderAndInOrderTraversals1RecursiveComplete<int>.FromPreOrderAndInOrderTraversals(preOrder, inOrder);
            Assert.IsTrue(CompareBinaryTreeHelpers.CompareBinaryTrees(BinaryTreeNodeTestData.Tree11, actual));
        }

        /// <summary>
        /// Tests with test data Tree12
        /// </summary>
        [TestMethod]
        public void TestFromPreOrderAndInOrderTraversalsTree12()
        {
            var preOrder = BinaryTreeNodeTestData.Tree12PreOrder;
            var inOrder = BinaryTreeNodeTestData.Tree12InOrder;
            var actual = BinaryTreeFromPreOrderAndInOrderTraversals1RecursiveComplete<int>.FromPreOrderAndInOrderTraversals(preOrder, inOrder);
            Assert.IsTrue(CompareBinaryTreeHelpers.CompareBinaryTrees(BinaryTreeNodeTestData.Tree12, actual));
        }

        /// <summary>
        /// Tests with test data Tree13
        /// </summary>
        [TestMethod]
        public void TestFromPreOrderAndInOrderTraversalsTree13()
        {
            var preOrder = BinaryTreeNodeTestData.Tree13PreOrder;
            var inOrder = BinaryTreeNodeTestData.Tree13InOrder;
            var actual = BinaryTreeFromPreOrderAndInOrderTraversals1RecursiveComplete<int>.FromPreOrderAndInOrderTraversals(preOrder, inOrder);
            Assert.IsTrue(CompareBinaryTreeHelpers.CompareBinaryTrees(BinaryTreeNodeTestData.Tree13, actual));
        }

        /// <summary>
        /// Tests with test data Tree14
        /// </summary>
        [TestMethod]
        public void TestFromPreOrderAndInOrderTraversalsTree14()
        {
            var preOrder = BinaryTreeNodeTestData.Tree14PreOrder;
            var inOrder = BinaryTreeNodeTestData.Tree14InOrder;
            var actual = BinaryTreeFromPreOrderAndInOrderTraversals1RecursiveComplete<int>.FromPreOrderAndInOrderTraversals(preOrder, inOrder);
            Assert.IsTrue(CompareBinaryTreeHelpers.CompareBinaryTrees(BinaryTreeNodeTestData.Tree14, actual));
        }

        /// <summary>
        /// Tests with test data SampleTree1
        /// </summary>
        [TestMethod]
        public void TestFromPreOrderAndInOrderTraversalsTreeFromSampleData1()
        {
            var preOrder = BinaryTreeNodeTestData.TreeFromSampleData1PreOrder;
            var inOrder = BinaryTreeNodeTestData.TreeFromSampleData1InOrder;
            var actual = BinaryTreeFromPreOrderAndInOrderTraversals1RecursiveComplete<int>.FromPreOrderAndInOrderTraversals(preOrder, inOrder);
            Assert.IsTrue(CompareBinaryTreeHelpers.CompareBinaryTrees(BinaryTreeNodeTestData.TreeFromSampleData1, actual));
        }

        /// <summary>
        /// Tests with null for the first parameter.
        /// </summary>
        [TestMethod]
        public void TestFromPreOrderAndInOrderTraversalsNullParams1()
        {
            var inOrder = BinaryTreeNodeTestData.TreeFromSampleData1InOrder;
            var actual = BinaryTreeFromPreOrderAndInOrderTraversals1RecursiveComplete<int>.FromPreOrderAndInOrderTraversals(null, inOrder);
            Assert.IsNull(actual);
        }

        /// <summary>
        /// Tests with null for the second parameter.
        /// </summary>
        [TestMethod]
        public void TestFromPreOrderAndInOrderTraversalsNullParams2()
        {
            var preOrder = BinaryTreeNodeTestData.TreeFromSampleData1PreOrder;
            var actual = BinaryTreeFromPreOrderAndInOrderTraversals1RecursiveComplete<int>.FromPreOrderAndInOrderTraversals(preOrder, null);
            Assert.IsNull(actual);
        }
    }
}
