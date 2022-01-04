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
            var expected = BinaryTreeNodeTestData.Tree1PreOrder;
            var actual = BinaryTreeTraversePostOrder2IterativeComplete.TraversePostOrder(BinaryTreeNodeTestData.Tree1);
            CollectionAssert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Tests with test data Tree2
        /// </summary>
        [TestMethod]
        public void PostOrderTestTree2()
        {
            var expected = BinaryTreeNodeTestData.Tree2PostOrder;
            var actual = BinaryTreeTraversePostOrder2IterativeComplete.TraversePostOrder(BinaryTreeNodeTestData.Tree2);
            CollectionAssert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Tests with test data Tree3
        /// </summary>
        [TestMethod]
        public void PostOrderTestTree3()
        {
            var expected = BinaryTreeNodeTestData.Tree3PostOrder;
            var actual = BinaryTreeTraversePostOrder2IterativeComplete.TraversePostOrder(BinaryTreeNodeTestData.Tree3);
            CollectionAssert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Tests with test data Tree4
        /// </summary>
        [TestMethod]
        public void PostOrderTestTree4()
        {
            var expected = BinaryTreeNodeTestData.Tree4PostOrder;
            var actual = BinaryTreeTraversePostOrder2IterativeComplete.TraversePostOrder(BinaryTreeNodeTestData.Tree4);
            CollectionAssert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Tests with test data Tree5
        /// </summary>
        [TestMethod]
        public void PostOrderTestTree5()
        {
            var expected = BinaryTreeNodeTestData.Tree5PostOrder;
            var actual = BinaryTreeTraversePostOrder2IterativeComplete.TraversePostOrder(BinaryTreeNodeTestData.Tree5);
            CollectionAssert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Tests with test data Tree6
        /// </summary>
        [TestMethod]
        public void PostOrderTestTree6()
        {
            var expected = BinaryTreeNodeTestData.Tree6PostOrder;
            var actual = BinaryTreeTraversePostOrder2IterativeComplete.TraversePostOrder(BinaryTreeNodeTestData.Tree6);
            CollectionAssert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Tests with test data Tree7
        /// </summary>
        [TestMethod]
        public void PostOrderTestTree7()
        {
            var expected = BinaryTreeNodeTestData.Tree7PostOrder;
            var actual = BinaryTreeTraversePostOrder2IterativeComplete.TraversePostOrder(BinaryTreeNodeTestData.Tree7);
            CollectionAssert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Tests with test data Tree8
        /// </summary>
        [TestMethod]
        public void PostOrderTestTree8()
        {
            var expected = BinaryTreeNodeTestData.Tree8PostOrder;
            var actual = BinaryTreeTraversePostOrder2IterativeComplete.TraversePostOrder(BinaryTreeNodeTestData.Tree8);
            CollectionAssert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Tests with test data Tree9
        /// </summary>
        [TestMethod]
        public void PostOrderTestTree9()
        {
            var expected = BinaryTreeNodeTestData.Tree9PostOrder;
            var actual = BinaryTreeTraversePostOrder2IterativeComplete.TraversePostOrder(BinaryTreeNodeTestData.Tree9);
            CollectionAssert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Tests with test data Tree10
        /// </summary>
        [TestMethod]
        public void PostOrderTestTree10()
        {
            var expected = BinaryTreeNodeTestData.Tree10PostOrder;
            var actual = BinaryTreeTraversePostOrder2IterativeComplete.TraversePostOrder(BinaryTreeNodeTestData.Tree10);
            CollectionAssert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Tests with test data Tree11
        /// </summary>
        [TestMethod]
        public void PostOrderTestTree11()
        {
            var expected = BinaryTreeNodeTestData.Tree11PostOrder;
            var actual = BinaryTreeTraversePostOrder2IterativeComplete.TraversePostOrder(BinaryTreeNodeTestData.Tree11);
            CollectionAssert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Tests with test data Tree12
        /// </summary>
        [TestMethod]
        public void PostOrderTestTree12()
        {
            var expected = BinaryTreeNodeTestData.Tree12PostOrder;
            var actual = BinaryTreeTraversePostOrder2IterativeComplete.TraversePostOrder(BinaryTreeNodeTestData.Tree12);
            CollectionAssert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Tests with test data Tree13
        /// </summary>
        [TestMethod]
        public void PostOrderTestTree13()
        {
            var expected = BinaryTreeNodeTestData.Tree13PostOrder;
            var actual = BinaryTreeTraversePostOrder2IterativeComplete.TraversePostOrder(BinaryTreeNodeTestData.Tree13);
            CollectionAssert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Tests with test data Tree14
        /// </summary>
        [TestMethod]
        public void PostOrderTestTree14()
        {
            var expected = BinaryTreeNodeTestData.Tree14PostOrder;
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
