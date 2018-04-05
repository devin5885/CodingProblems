using System;
using System.Collections.Generic;
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
        /// Tests with test data Tree1
        /// </summary>
        [TestMethod]
        public void PostOrderTestTree1()
        {
            var expected = new List<int> { 1 };
            var actual = BinaryTreeTraversePostOrder2IterativeComplete.TraversePostOrder(BinaryTreeNodeTestData.Tree1);
            CollectionAssert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Tests with test data Tree2
        /// </summary>
        [TestMethod]
        public void PostOrderTestTree2()
        {
            var expected = new List<int> { 1, 2 };
            var actual = BinaryTreeTraversePostOrder2IterativeComplete.TraversePostOrder(BinaryTreeNodeTestData.Tree2);
            CollectionAssert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Tests with test data Tree3
        /// </summary>
        [TestMethod]
        public void PostOrderTestTree3()
        {
            var expected = new List<int> { 1, 2 };
            var actual = BinaryTreeTraversePostOrder2IterativeComplete.TraversePostOrder(BinaryTreeNodeTestData.Tree2);
            CollectionAssert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Tests with test data Tree4
        /// </summary>
        [TestMethod]
        public void PostOrderTestTree4()
        {
            var expected = new List<int> { 1, 3, 2 };
            var actual = BinaryTreeTraversePostOrder2IterativeComplete.TraversePostOrder(BinaryTreeNodeTestData.Tree4);
            CollectionAssert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Tests with test data Tree5
        /// </summary>
        [TestMethod]
        public void PostOrderTestTree5()
        {
            var expected = new List<int> { 4, 8, 7, 11, 18, 15, 10 };
            var actual = BinaryTreeTraversePostOrder2IterativeComplete.TraversePostOrder(BinaryTreeNodeTestData.Tree5);
            CollectionAssert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Tests with test data Tree6
        /// </summary>
        [TestMethod]
        public void PostOrderTestTree6()
        {
            var expected = new List<int> { 8, 9, 7, 11, 18, 15, 10 };
            var actual = BinaryTreeTraversePostOrder2IterativeComplete.TraversePostOrder(BinaryTreeNodeTestData.Tree6);
            CollectionAssert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Tests with test data Tree7
        /// </summary>
        [TestMethod]
        public void PostOrderTestTree7()
        {
            var expected = new List<int> { 5, 6, 7, 11, 18, 15, 10 };
            var actual = BinaryTreeTraversePostOrder2IterativeComplete.TraversePostOrder(BinaryTreeNodeTestData.Tree7);
            CollectionAssert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Tests with test data Tree8
        /// </summary>
        [TestMethod]
        public void PostOrderTestTree8()
        {
            var expected = new List<int> { 4, 8, 7, 11, 15, 10 };
            var actual = BinaryTreeTraversePostOrder2IterativeComplete.TraversePostOrder(BinaryTreeNodeTestData.Tree8);
            CollectionAssert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Tests with test data Tree9
        /// </summary>
        [TestMethod]
        public void PostOrderTestTree9()
        {
            var expected = new List<int> { 9, 7, 18, 15, 10 };
            var actual = BinaryTreeTraversePostOrder2IterativeComplete.TraversePostOrder(BinaryTreeNodeTestData.Tree9);
            CollectionAssert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Tests with test data Tree10
        /// </summary>
        [TestMethod]
        public void PostOrderTestTree10()
        {
            var expected = new List<int> { 5, 8, 7, 15, 10 };
            var actual = BinaryTreeTraversePostOrder2IterativeComplete.TraversePostOrder(BinaryTreeNodeTestData.Tree10);
            CollectionAssert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Tests with test data Tree11
        /// </summary>
        [TestMethod]
        public void PostOrderTestTree11()
        {
            var expected = new List<int> { 8, 7, 11, 13, 12, 18, 15, 10 };
            var actual = BinaryTreeTraversePostOrder2IterativeComplete.TraversePostOrder(BinaryTreeNodeTestData.Tree11);
            CollectionAssert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Tests with test data Tree12
        /// </summary>
        [TestMethod]
        public void PostOrderTestTree12()
        {
            var expected = new List<int> { 5, 7, 6, 10, 12, 11, 9, 16, 18, 17, 24, 26, 25, 23, 15 };
            var actual = BinaryTreeTraversePostOrder2IterativeComplete.TraversePostOrder(BinaryTreeNodeTestData.Tree12);
            CollectionAssert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Tests with test data Tree13
        /// </summary>
        [TestMethod]
        public void PostOrderTestTree13()
        {
            var expected = new List<int> { 3, 2, 1 };
            var actual = BinaryTreeTraversePostOrder2IterativeComplete.TraversePostOrder(BinaryTreeNodeTestData.Tree13);
            CollectionAssert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Tests with test data Tree14
        /// </summary>
        [TestMethod]
        public void PostOrderTestTree14()
        {
            var expected = new List<int> { 6, 4, 2, 7, 5, 3, 1 };
            var actual = BinaryTreeTraversePostOrder2IterativeComplete.TraversePostOrder(BinaryTreeNodeTestData.Tree14);
            CollectionAssert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Tests with null.
        /// </summary>
        [TestMethod]
        public void PostOrderTestNullTree()
        {
            var actual = BinaryTreeTraversePostOrder2IterativeComplete.TraversePostOrder(null);
            Assert.AreEqual(0, actual.Count);
        }
    }
}
