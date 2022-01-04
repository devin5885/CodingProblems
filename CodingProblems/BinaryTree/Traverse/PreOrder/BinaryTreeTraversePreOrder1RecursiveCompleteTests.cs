using CodingProblems.BinaryTree.Node;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodingProblems.BinaryTree.Traverse.PreOrder
{
    /// <summary>
    /// Tests TraversePreOrder.
    /// </summary>
    [TestClass]
    public class BinaryTreeTraversePreOrder1RecursiveCompleteTests
    {
        /// <summary>
        /// Tests with test data Tree1
        /// </summary>
        [TestMethod]
        public void PreOrderTestTree1()
        {
            var expected = BinaryTreeNodeTestData.Tree1PreOrder;
            var actual = BinaryTreeTraversePreOrder1RecursiveComplete.TraversePreOrder(BinaryTreeNodeTestData.Tree1);
            CollectionAssert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Tests with test data Tree2
        /// </summary>
        [TestMethod]
        public void PreOrderTestTree2()
        {
            var expected = BinaryTreeNodeTestData.Tree2PreOrder;
            var actual = BinaryTreeTraversePreOrder1RecursiveComplete.TraversePreOrder(BinaryTreeNodeTestData.Tree2);
            CollectionAssert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Tests with test data Tree3
        /// </summary>
        [TestMethod]
        public void PreOrderTestTree3()
        {
            var expected = BinaryTreeNodeTestData.Tree3PreOrder;
            var actual = BinaryTreeTraversePreOrder1RecursiveComplete.TraversePreOrder(BinaryTreeNodeTestData.Tree3);
            CollectionAssert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Tests with test data Tree4
        /// </summary>
        [TestMethod]
        public void PreOrderTestTree4()
        {
            var expected = BinaryTreeNodeTestData.Tree4PreOrder;
            var actual = BinaryTreeTraversePreOrder1RecursiveComplete.TraversePreOrder(BinaryTreeNodeTestData.Tree4);
            CollectionAssert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Tests with test data Tree5
        /// </summary>
        [TestMethod]
        public void PreOrderTestTree5()
        {
            var expected = BinaryTreeNodeTestData.Tree5PreOrder;
            var actual = BinaryTreeTraversePreOrder1RecursiveComplete.TraversePreOrder(BinaryTreeNodeTestData.Tree5);
            CollectionAssert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Tests with test data Tree6
        /// </summary>
        [TestMethod]
        public void PreOrderTestTree6()
        {
            var expected = BinaryTreeNodeTestData.Tree6PreOrder;
            var actual = BinaryTreeTraversePreOrder1RecursiveComplete.TraversePreOrder(BinaryTreeNodeTestData.Tree6);
            CollectionAssert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Tests with test data Tree7
        /// </summary>
        [TestMethod]
        public void PreOrderTestTree7()
        {
            var expected = BinaryTreeNodeTestData.Tree7PreOrder;
            var actual = BinaryTreeTraversePreOrder1RecursiveComplete.TraversePreOrder(BinaryTreeNodeTestData.Tree7);
            CollectionAssert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Tests with test data Tree8
        /// </summary>
        [TestMethod]
        public void PreOrderTestTree8()
        {
            var expected = BinaryTreeNodeTestData.Tree8PreOrder;
            var actual = BinaryTreeTraversePreOrder1RecursiveComplete.TraversePreOrder(BinaryTreeNodeTestData.Tree8);
            CollectionAssert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Tests with test data Tree9
        /// </summary>
        [TestMethod]
        public void PreOrderTestTree9()
        {
            var expected = BinaryTreeNodeTestData.Tree9PreOrder;
            var actual = BinaryTreeTraversePreOrder1RecursiveComplete.TraversePreOrder(BinaryTreeNodeTestData.Tree9);
            CollectionAssert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Tests with test data Tree10
        /// </summary>
        [TestMethod]
        public void PreOrderTestTree10()
        {
            var expected = BinaryTreeNodeTestData.Tree10PreOrder;
            var actual = BinaryTreeTraversePreOrder1RecursiveComplete.TraversePreOrder(BinaryTreeNodeTestData.Tree10);
            CollectionAssert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Tests with test data Tree11
        /// </summary>
        [TestMethod]
        public void PreOrderTestTree11()
        {
            var expected = BinaryTreeNodeTestData.Tree11PreOrder;
            var actual = BinaryTreeTraversePreOrder1RecursiveComplete.TraversePreOrder(BinaryTreeNodeTestData.Tree11);
            CollectionAssert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Tests with test data Tree12
        /// </summary>
        [TestMethod]
        public void PreOrderTestTree12()
        {
            var expected = BinaryTreeNodeTestData.Tree12PreOrder;
            var actual = BinaryTreeTraversePreOrder1RecursiveComplete.TraversePreOrder(BinaryTreeNodeTestData.Tree12);
            CollectionAssert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Tests with test data Tree13
        /// </summary>
        [TestMethod]
        public void PreOrderTestTree13()
        {
            var expected = BinaryTreeNodeTestData.Tree13PreOrder;
            var actual = BinaryTreeTraversePreOrder1RecursiveComplete.TraversePreOrder(BinaryTreeNodeTestData.Tree13);
            CollectionAssert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Tests with test data Tree14
        /// </summary>
        [TestMethod]
        public void PreOrderTestTree14()
        {
            var expected = BinaryTreeNodeTestData.Tree14PreOrder;
            var actual = BinaryTreeTraversePreOrder1RecursiveComplete.TraversePreOrder(BinaryTreeNodeTestData.Tree14);
            CollectionAssert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Tests with sample tree 1.
        /// </summary>
        [TestMethod]
        public void PreOrderTestSampleTree1()
        {
            var expected = BinaryTreeNodeTestData.TreeFromSampleData1PreOrder;
            var actual = BinaryTreeTraversePreOrder1RecursiveComplete.TraversePreOrder(BinaryTreeNodeTestData.TreeFromSampleData1);
            CollectionAssert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Tests with null.
        /// </summary>
        [TestMethod]
        public void PreOrderTestNullTree()
        {
            var actual = BinaryTreeTraversePreOrder1RecursiveComplete.TraversePreOrder(null);
            Assert.AreEqual(0, actual.Count);
        }
    }
}
