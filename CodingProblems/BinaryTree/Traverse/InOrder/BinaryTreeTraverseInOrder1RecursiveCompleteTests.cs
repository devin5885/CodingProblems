using System;
using System.Collections.Generic;
using CodingProblems.BinaryTree.Node;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodingProblems.BinaryTree.Traverse.InOrder
{
    /// <summary>
    /// Tests TraverseInOrder.
    /// </summary>
    [TestClass]
    public class BinaryTreeTraverseInOrder1RecursiveCompleteTests
    {
        /// <summary>
        /// Tests with test data Tree1
        /// </summary>
        [TestMethod]
        public void InOrderTestTree1()
        {
            var expected = new List<int> { 1 };
            var actual = BinaryTreeTraverseInOrder1RecursiveComplete.TraverseInOrder(BinaryTreeNodeTestData.Tree1);
            CollectionAssert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Tests with test data Tree2
        /// </summary>
        [TestMethod]
        public void InOrderTestTree2()
        {
            var expected = new List<int> { 1, 2 };
            var actual = BinaryTreeTraverseInOrder1RecursiveComplete.TraverseInOrder(BinaryTreeNodeTestData.Tree2);
            CollectionAssert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Tests with test data Tree3
        /// </summary>
        [TestMethod]
        public void InOrderTestTree3()
        {
            var expected = new List<int> { 1, 2 };
            var actual = BinaryTreeTraverseInOrder1RecursiveComplete.TraverseInOrder(BinaryTreeNodeTestData.Tree2);
            CollectionAssert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Tests with test data Tree4
        /// </summary>
        [TestMethod]
        public void InOrderTestTree4()
        {
            var expected = new List<int> { 1, 2, 3 };
            var actual = BinaryTreeTraverseInOrder1RecursiveComplete.TraverseInOrder(BinaryTreeNodeTestData.Tree4);
            CollectionAssert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Tests with test data Tree5
        /// </summary>
        [TestMethod]
        public void InOrderTestTree5()
        {
            var expected = new List<int> { 4, 7, 8, 10, 11, 15, 18 };
            var actual = BinaryTreeTraverseInOrder1RecursiveComplete.TraverseInOrder(BinaryTreeNodeTestData.Tree5);
            CollectionAssert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Tests with test data Tree6
        /// </summary>
        [TestMethod]
        public void InOrderTestTree6()
        {
            var expected = new List<int> { 8, 7, 9, 10, 11, 15, 18 };
            var actual = BinaryTreeTraverseInOrder1RecursiveComplete.TraverseInOrder(BinaryTreeNodeTestData.Tree6);
            CollectionAssert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Tests with test data Tree7
        /// </summary>
        [TestMethod]
        public void InOrderTestTree7()
        {
            var expected = new List<int> { 5, 7, 6, 10, 11, 15, 18 };
            var actual = BinaryTreeTraverseInOrder1RecursiveComplete.TraverseInOrder(BinaryTreeNodeTestData.Tree7);
            CollectionAssert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Tests with test data Tree8
        /// </summary>
        [TestMethod]
        public void InOrderTestTree8()
        {
            var expected = new List<int> { 4, 7, 8, 10, 11, 15 };
            var actual = BinaryTreeTraverseInOrder1RecursiveComplete.TraverseInOrder(BinaryTreeNodeTestData.Tree8);
            CollectionAssert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Tests with test data Tree9
        /// </summary>
        [TestMethod]
        public void InOrderTestTree9()
        {
            var expected = new List<int> { 7, 9, 10, 15, 18 };
            var actual = BinaryTreeTraverseInOrder1RecursiveComplete.TraverseInOrder(BinaryTreeNodeTestData.Tree9);
            CollectionAssert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Tests with test data Tree10
        /// </summary>
        [TestMethod]
        public void InOrderTestTree10()
        {
            var expected = new List<int> { 5, 7, 8, 10, 15 };
            var actual = BinaryTreeTraverseInOrder1RecursiveComplete.TraverseInOrder(BinaryTreeNodeTestData.Tree10);
            CollectionAssert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Tests with test data Tree11
        /// </summary>
        [TestMethod]
        public void InOrderTestTree11()
        {
            var expected = new List<int> { 7, 8, 10, 11, 12, 13, 15, 18 };
            var actual = BinaryTreeTraverseInOrder1RecursiveComplete.TraverseInOrder(BinaryTreeNodeTestData.Tree11);
            CollectionAssert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Tests with test data Tree12
        /// </summary>
        [TestMethod]
        public void InOrderTestTree12()
        {
            var expected = new List<int> { 5, 6, 7, 9, 10, 11, 12, 15, 16, 17, 18, 23, 24, 25, 26 };
            var actual = BinaryTreeTraverseInOrder1RecursiveComplete.TraverseInOrder(BinaryTreeNodeTestData.Tree12);
            CollectionAssert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Tests with test data Tree13
        /// </summary>
        [TestMethod]
        public void InOrderTestTree13()
        {
            var expected = new List<int> { 3, 2, 1 };
            var actual = BinaryTreeTraverseInOrder1RecursiveComplete.TraverseInOrder(BinaryTreeNodeTestData.Tree13);
            CollectionAssert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Tests with test data Tree14
        /// </summary>
        [TestMethod]
        public void InOrderTestTree14()
        {
            var expected = new List<int> { 6, 4, 2, 1, 7, 5, 3 };
            var actual = BinaryTreeTraverseInOrder1RecursiveComplete.TraverseInOrder(BinaryTreeNodeTestData.Tree14);
            CollectionAssert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Tests with null.
        /// </summary>
        [TestMethod]
        public void InOrderTestNullTree()
        {
            var actual = BinaryTreeTraverseInOrder1RecursiveComplete.TraverseInOrder(null);
            Assert.AreEqual(0, actual.Count);
        }
    }
}
