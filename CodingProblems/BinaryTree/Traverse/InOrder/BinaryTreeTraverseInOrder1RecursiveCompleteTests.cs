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
            var expected = BinaryTreeNodeTestData.Tree1InOrder;
            var actual = BinaryTreeTraverseInOrder1RecursiveComplete.TraverseInOrder(BinaryTreeNodeTestData.Tree1);
            CollectionAssert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Tests with test data Tree2
        /// </summary>
        [TestMethod]
        public void InOrderTestTree2()
        {
            var expected = BinaryTreeNodeTestData.Tree2InOrder;
            var actual = BinaryTreeTraverseInOrder1RecursiveComplete.TraverseInOrder(BinaryTreeNodeTestData.Tree2);
            CollectionAssert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Tests with test data Tree3
        /// </summary>
        [TestMethod]
        public void InOrderTestTree3()
        {
            var expected = BinaryTreeNodeTestData.Tree3InOrder;
            var actual = BinaryTreeTraverseInOrder1RecursiveComplete.TraverseInOrder(BinaryTreeNodeTestData.Tree3);
            CollectionAssert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Tests with test data Tree4
        /// </summary>
        [TestMethod]
        public void InOrderTestTree4()
        {
            var expected = BinaryTreeNodeTestData.Tree4InOrder;
            var actual = BinaryTreeTraverseInOrder1RecursiveComplete.TraverseInOrder(BinaryTreeNodeTestData.Tree4);
            CollectionAssert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Tests with test data Tree5
        /// </summary>
        [TestMethod]
        public void InOrderTestTree5()
        {
            var expected = BinaryTreeNodeTestData.Tree5InOrder;
            var actual = BinaryTreeTraverseInOrder1RecursiveComplete.TraverseInOrder(BinaryTreeNodeTestData.Tree5);
            CollectionAssert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Tests with test data Tree6
        /// </summary>
        [TestMethod]
        public void InOrderTestTree6()
        {
            var expected = BinaryTreeNodeTestData.Tree6InOrder;
            var actual = BinaryTreeTraverseInOrder1RecursiveComplete.TraverseInOrder(BinaryTreeNodeTestData.Tree6);
            CollectionAssert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Tests with test data Tree7
        /// </summary>
        [TestMethod]
        public void InOrderTestTree7()
        {
            var expected = BinaryTreeNodeTestData.Tree7InOrder;
            var actual = BinaryTreeTraverseInOrder1RecursiveComplete.TraverseInOrder(BinaryTreeNodeTestData.Tree7);
            CollectionAssert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Tests with test data Tree8
        /// </summary>
        [TestMethod]
        public void InOrderTestTree8()
        {
            var expected = BinaryTreeNodeTestData.Tree8InOrder;
            var actual = BinaryTreeTraverseInOrder1RecursiveComplete.TraverseInOrder(BinaryTreeNodeTestData.Tree8);
            CollectionAssert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Tests with test data Tree9
        /// </summary>
        [TestMethod]
        public void InOrderTestTree9()
        {
            var expected = BinaryTreeNodeTestData.Tree9InOrder;
            var actual = BinaryTreeTraverseInOrder1RecursiveComplete.TraverseInOrder(BinaryTreeNodeTestData.Tree9);
            CollectionAssert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Tests with test data Tree10
        /// </summary>
        [TestMethod]
        public void InOrderTestTree10()
        {
            var expected = BinaryTreeNodeTestData.Tree10InOrder;
            var actual = BinaryTreeTraverseInOrder1RecursiveComplete.TraverseInOrder(BinaryTreeNodeTestData.Tree10);
            CollectionAssert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Tests with test data Tree11
        /// </summary>
        [TestMethod]
        public void InOrderTestTree11()
        {
            var expected = BinaryTreeNodeTestData.Tree11InOrder;
            var actual = BinaryTreeTraverseInOrder1RecursiveComplete.TraverseInOrder(BinaryTreeNodeTestData.Tree11);
            CollectionAssert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Tests with test data Tree12
        /// </summary>
        [TestMethod]
        public void InOrderTestTree12()
        {
            var expected = BinaryTreeNodeTestData.Tree12InOrder;
            var actual = BinaryTreeTraverseInOrder1RecursiveComplete.TraverseInOrder(BinaryTreeNodeTestData.Tree12);
            CollectionAssert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Tests with test data Tree13
        /// </summary>
        [TestMethod]
        public void InOrderTestTree13()
        {
            var expected = BinaryTreeNodeTestData.Tree13InOrder;
            var actual = BinaryTreeTraverseInOrder1RecursiveComplete.TraverseInOrder(BinaryTreeNodeTestData.Tree13);
            CollectionAssert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Tests with test data Tree14
        /// </summary>
        [TestMethod]
        public void InOrderTestTree14()
        {
            var expected = BinaryTreeNodeTestData.Tree14InOrder;
            var actual = BinaryTreeTraverseInOrder1RecursiveComplete.TraverseInOrder(BinaryTreeNodeTestData.Tree14);
            CollectionAssert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Tests with sample tree 1.
        /// </summary>
        [TestMethod]
        public void PreOrderTestSampleTree1()
        {
            var expected = BinaryTreeNodeTestData.TreeFromSampleData1InOrder;
            var actual = BinaryTreeTraverseInOrder1RecursiveComplete.TraverseInOrder(BinaryTreeNodeTestData.TreeFromSampleData1);
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
