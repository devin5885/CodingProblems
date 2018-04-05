using System;
using System.Collections.Generic;
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
            var preOrderExpected = new List<int> { 1 };
            var preOrderActual = BinaryTreeTraversePreOrder1RecursiveComplete.TraversePreOrder(BinaryTreeNodeTestData.Tree1);
            CollectionAssert.AreEqual(preOrderExpected, preOrderActual);
        }

        /// <summary>
        /// Tests with test data Tree2
        /// </summary>
        [TestMethod]
        public void PreOrderTestTree2()
        {
            var preOrderExpected = new List<int> { 2, 1 };
            var preOrderActual = BinaryTreeTraversePreOrder1RecursiveComplete.TraversePreOrder(BinaryTreeNodeTestData.Tree2);
            CollectionAssert.AreEqual(preOrderExpected, preOrderActual);
        }

        /// <summary>
        /// Tests with test data Tree3
        /// </summary>
        [TestMethod]
        public void PreOrderTestTree3()
        {
            var preOrderExpected = new List<int> { 2, 1 };
            var preOrderActual = BinaryTreeTraversePreOrder1RecursiveComplete.TraversePreOrder(BinaryTreeNodeTestData.Tree2);
            CollectionAssert.AreEqual(preOrderExpected, preOrderActual);
        }

        /// <summary>
        /// Tests with test data Tree4
        /// </summary>
        [TestMethod]
        public void PreOrderTestTree4()
        {
            var preOrderExpected = new List<int> { 2, 1, 3 };
            var preOrderActual = BinaryTreeTraversePreOrder1RecursiveComplete.TraversePreOrder(BinaryTreeNodeTestData.Tree4);
            CollectionAssert.AreEqual(preOrderExpected, preOrderActual);
        }

        /// <summary>
        /// Tests with test data Tree5
        /// </summary>
        [TestMethod]
        public void PreOrderTestTree5()
        {
            var preOrderExpected = new List<int> { 10, 7, 4, 8, 15, 11, 18 };
            var preOrderActual = BinaryTreeTraversePreOrder1RecursiveComplete.TraversePreOrder(BinaryTreeNodeTestData.Tree5);
            CollectionAssert.AreEqual(preOrderExpected, preOrderActual);
        }

        /// <summary>
        /// Tests with test data Tree6
        /// </summary>
        [TestMethod]
        public void PreOrderTestTree6()
        {
            var preOrderExpected = new List<int> { 10, 7, 8, 9, 15, 11, 18 };
            var preOrderActual = BinaryTreeTraversePreOrder1RecursiveComplete.TraversePreOrder(BinaryTreeNodeTestData.Tree6);
            CollectionAssert.AreEqual(preOrderExpected, preOrderActual);
        }

        /// <summary>
        /// Tests with test data Tree7
        /// </summary>
        [TestMethod]
        public void PreOrderTestTree7()
        {
            var preOrderExpected = new List<int> { 10, 7, 5, 6, 15, 11, 18 };
            var preOrderActual = BinaryTreeTraversePreOrder1RecursiveComplete.TraversePreOrder(BinaryTreeNodeTestData.Tree7);
            CollectionAssert.AreEqual(preOrderExpected, preOrderActual);
        }

        /// <summary>
        /// Tests with test data Tree8
        /// </summary>
        [TestMethod]
        public void PreOrderTestTree8()
        {
            var preOrderExpected = new List<int> { 10, 7, 4, 8, 15, 11 };
            var preOrderActual = BinaryTreeTraversePreOrder1RecursiveComplete.TraversePreOrder(BinaryTreeNodeTestData.Tree8);
            CollectionAssert.AreEqual(preOrderExpected, preOrderActual);
        }

        /// <summary>
        /// Tests with test data Tree9
        /// </summary>
        [TestMethod]
        public void PreOrderTestTree9()
        {
            var preOrderExpected = new List<int> { 10, 7, 9, 15, 18 };
            var preOrderActual = BinaryTreeTraversePreOrder1RecursiveComplete.TraversePreOrder(BinaryTreeNodeTestData.Tree9);
            CollectionAssert.AreEqual(preOrderExpected, preOrderActual);
        }

        /// <summary>
        /// Tests with test data Tree10
        /// </summary>
        [TestMethod]
        public void PreOrderTestTree10()
        {
            var preOrderExpected = new List<int> { 10, 7, 5, 8, 15 };
            var preOrderActual = BinaryTreeTraversePreOrder1RecursiveComplete.TraversePreOrder(BinaryTreeNodeTestData.Tree10);
            CollectionAssert.AreEqual(preOrderExpected, preOrderActual);
        }

        /// <summary>
        /// Tests with test data Tree11
        /// </summary>
        [TestMethod]
        public void PreOrderTestTree11()
        {
            var preOrderExpected = new List<int> { 10, 7, 8, 15, 12, 11, 13, 18 };
            var preOrderActual = BinaryTreeTraversePreOrder1RecursiveComplete.TraversePreOrder(BinaryTreeNodeTestData.Tree11);
            CollectionAssert.AreEqual(preOrderExpected, preOrderActual);
        }

        /// <summary>
        /// Tests with test data Tree12
        /// </summary>
        [TestMethod]
        public void PreOrderTestTree12()
        {
            var preOrderExpected = new List<int> { 15, 9, 6, 5, 7, 11, 10, 12, 23, 17, 16, 18, 25, 24, 26 };
            var preOrderActual = BinaryTreeTraversePreOrder1RecursiveComplete.TraversePreOrder(BinaryTreeNodeTestData.Tree12);
            CollectionAssert.AreEqual(preOrderExpected, preOrderActual);
        }

        /// <summary>
        /// Tests with test data Tree13
        /// </summary>
        [TestMethod]
        public void PreOrderTestTree13()
        {
            var preOrderExpected = new List<int> { 1, 2, 3 };
            var preOrderActual = BinaryTreeTraversePreOrder1RecursiveComplete.TraversePreOrder(BinaryTreeNodeTestData.Tree13);
            CollectionAssert.AreEqual(preOrderExpected, preOrderActual);
        }

        /// <summary>
        /// Tests with test data Tree14
        /// </summary>
        [TestMethod]
        public void PreOrderTestTree14()
        {
            var preOrderExpected = new List<int> { 1, 2, 4, 6, 3, 5, 7 };
            var preOrderActual = BinaryTreeTraversePreOrder1RecursiveComplete.TraversePreOrder(BinaryTreeNodeTestData.Tree14);
            CollectionAssert.AreEqual(preOrderExpected, preOrderActual);
        }

        /// <summary>
        /// Tests with null.
        /// </summary>
        [TestMethod]
        public void PreOrderTestNullTree()
        {
            var preOrderActual = BinaryTreeTraversePreOrder1RecursiveComplete.TraversePreOrder(null);
            Assert.AreEqual(0, preOrderActual.Count);
        }
    }
}
