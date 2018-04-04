using System;
using CodingProblems.LinkedList.SingleLink.Helpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodingProblems.LinkedList.SingleLink.Reverse
{
    /// <summary>
    /// Tests Reverse.
    /// </summary>
    [TestClass]
    public class LinkedListSingleLinkReverse1CompleteTests
    {
        /// <summary>
        /// Tests a simple list with defaults.
        /// </summary>
        [TestMethod]
        public void LinkedListSingleLinkReverse1TestMultipleElementsWithDefaults()
        {
            // First list.
            var toReverse = LinkedListSingleLinkNode<int>.CreateFromData(1, 2, 3);

            // Expected list.
            var expected = LinkedListSingleLinkNode<int>.CreateFromData(3, 2, 1);

            // Reverse the list.
            LinkedListSingleLinkReverse1Complete.Reverse(ref toReverse);

            // Do the compare.
            Assert.IsTrue(LinkedListSingleLinkNode<int>.Compare(toReverse, expected));
        }

        /// <summary>
        /// Tests a simple list specifying a starting node.
        /// </summary>
        [TestMethod]
        public void LinkedListSingleLinkReverse1TestMultipleElementsWithStartingNode()
        {
            // List to reverse.
            var toReverse = LinkedListSingleLinkNode<int>.CreateFromData(1, 2, 3);

            // Expected list.
            var expected = LinkedListSingleLinkNode<int>.CreateFromData(1, 3, 2);

            // Reverse the list.
            LinkedListSingleLinkReverse1Complete.Reverse(ref toReverse, toReverse.Next);

            // Do the compare.
            Assert.IsTrue(LinkedListSingleLinkNode<int>.Compare(toReverse, expected));
        }

        /// <summary>
        /// Tests a simple list specifying a starting node and end node.
        /// </summary>
        [TestMethod]
        public void LinkedListSingleLinkReverse1TestMultipleElementsWithStartingNodeAndEndingNode()
        {
            // List to reverse.
            var toReverse = LinkedListSingleLinkNode<int>.CreateFromData(1, 2, 3, 4, 5);

            // Expected list.
            var expected = LinkedListSingleLinkNode<int>.CreateFromData(1, 2, 4, 3, 5);

            // Reverse the list.
            LinkedListSingleLinkReverse1Complete.Reverse(ref toReverse, toReverse.Next.Next, toReverse.Next.Next.Next);

            // Do the compare.
            Assert.IsTrue(LinkedListSingleLinkNode<int>.Compare(toReverse, expected));
        }

        /// <summary>
        /// Tests a simple list specifying an end node.
        /// </summary>
        [TestMethod]
        public void LinkedListSingleLinkReverse1TestMultipleElementsWithEndingNode()
        {
            // List to reverse.
            var toReverse = LinkedListSingleLinkNode<int>.CreateFromData(1, 2, 3, 4, 5);

            // Expected list.
            var expected = LinkedListSingleLinkNode<int>.CreateFromData(2, 1, 3, 4, 5);

            // Reverse the list.
            LinkedListSingleLinkReverse1Complete.Reverse(ref toReverse, endReverse: toReverse.Next);

            // Do the compare.
            Assert.IsTrue(LinkedListSingleLinkNode<int>.Compare(toReverse, expected));
        }

        /// <summary>
        /// Tests a simple list with a single node all defaults.
        /// </summary>
        [TestMethod]
        public void LinkedListSingleLinkReverse1TestSingleElementWithDefaults()
        {
            // List to reverse.
            var toReverse = LinkedListSingleLinkNode<int>.CreateFromData(3);

            // Expected list.
            var expected = LinkedListSingleLinkNode<int>.CreateFromData(3);

            // Reverse the list.
            LinkedListSingleLinkReverse1Complete.Reverse(ref toReverse);

            // Do the compare.
            Assert.IsTrue(LinkedListSingleLinkNode<int>.Compare(toReverse, expected));
        }

        /// <summary>
        /// Tests a simple list with a single node starting node.
        /// </summary>
        [TestMethod]
        public void LinkedListSingleLinkReverse1TestSingleElementWithStartingNode()
        {
            // List to reverse.
            var toReverse = LinkedListSingleLinkNode<int>.CreateFromData(3);

            // Expected list.
            var expected = LinkedListSingleLinkNode<int>.CreateFromData(3);

            // Reverse the list.
            LinkedListSingleLinkReverse1Complete.Reverse(ref toReverse, toReverse);

            // Do the compare.
            Assert.IsTrue(LinkedListSingleLinkNode<int>.Compare(toReverse, expected));
        }

        /// <summary>
        /// Tests an empty list with defaults.
        /// </summary>
        [TestMethod]
        public void LinkedListSingleLinkReverse1TestEmptyListWithDefaults()
        {
            // List to reverse.
            LinkedListSingleLinkNode<int> toReverse = null;

            // Reverse the list.
            LinkedListSingleLinkReverse1Complete.Reverse(ref toReverse);

            // Do the compare.
            Assert.IsTrue(LinkedListSingleLinkNode<int>.Compare(toReverse, null));
        }

        /// <summary>
        /// Tests a starting node not in the list.
        /// </summary>
        [TestMethod]
        public void LinkedListSingleLinkReverse1TestInvalidStartNode()
        {
            try
            {
                var toReverse = LinkedListSingleLinkNode<int>.CreateFromData(1, 2, 3);
                LinkedListSingleLinkReverse1Complete.Reverse(ref toReverse, new LinkedListSingleLinkNode<int>());
            }
            catch (ArgumentException)
            {
                Assert.IsTrue(true);
                return;
            }
            Assert.Fail();
        }

        /// <summary>
        /// Tests an invalid end node.
        /// </summary>
        [TestMethod]
        public void LinkedListSingleLinkReverse1TestInvalidEndNode()
        {
            try
            {
                var toReverse = LinkedListSingleLinkNode<int>.CreateFromData(1, 2, 3);
                LinkedListSingleLinkReverse1Complete.Reverse(ref toReverse, endReverse: new LinkedListSingleLinkNode<int>());
            }
            catch (ArgumentException)
            {
                Assert.IsTrue(true);
                return;
            }
            Assert.Fail();
        }

        /// <summary>
        /// Tests start before end.
        /// </summary>
        [TestMethod]
        public void LinkedListSingleLinkReverse1TestEndBeforeStartNode()
        {
            try
            {
                var toReverse = LinkedListSingleLinkNode<int>.CreateFromData(1, 2, 3);
                LinkedListSingleLinkReverse1Complete.Reverse(ref toReverse, toReverse.Next, toReverse);
            }
            catch (ArgumentException)
            {
                Assert.IsTrue(true);
                return;
            }
            Assert.Fail();
        }
    }
}
