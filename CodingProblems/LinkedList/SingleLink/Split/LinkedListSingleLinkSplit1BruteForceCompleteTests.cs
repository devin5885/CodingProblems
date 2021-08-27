using System;
using CodingProblems.LinkedList.SingleLink.Helpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodingProblems.LinkedList.SingleLink.Split
{
    /// <summary>
    /// Tests Split.
    /// </summary>
    [TestClass]
    public class LinkedListSingleLinkSplit1BruteForceCompleteTests
    {
        /// <summary>
        /// Tests Split on an list with an even number of elements.
        /// </summary>
        [TestMethod]
        public void LinkedListSingleLinkSplit1BruteForceCompleteTestSimpleEven()
        {
            // First list.
            var a = LinkedListSingleLinkNode<int>.CreateFromData(1, 2, 3, 4);

            // Expected A (1st half of list)
            var expectedA = LinkedListSingleLinkNode<int>.CreateFromData(1, 2);

            // Expected B (2nd half of list)
            var expectedB = LinkedListSingleLinkNode<int>.CreateFromData(3, 4);

            // Split the list.
            LinkedListSingleLinkSplit1BruteForceComplete.Split(a, out var resultA, out var resultB, out var resultDropped);

            // Do the compare.
            Assert.IsTrue(LinkedListSingleLinkNode<int>.Compare(resultA, expectedA));
            Assert.IsTrue(LinkedListSingleLinkNode<int>.Compare(resultB, expectedB));
            Assert.IsTrue(LinkedListSingleLinkNode<int>.Compare(resultDropped, null));
        }

        /// <summary>
        /// Tests Split on an list with an odd number of elements.
        /// </summary>
        [TestMethod]
        public void LinkedListSingleLinkSplit1BruteForceCompleteTestSimpleOdd()
        {
            // First list.
            var a = LinkedListSingleLinkNode<int>.CreateFromData(1, 2, 3);

            // Expected A (1st half of list)
            var expectedA = LinkedListSingleLinkNode<int>.CreateFromData(1);

            // Expected B (2nd half of list)
            var expectedB = LinkedListSingleLinkNode<int>.CreateFromData(3);

            // Expected dropped.
            var expectedDropped = LinkedListSingleLinkNode<int>.CreateFromData(2);

            // Split the list.
            LinkedListSingleLinkSplit1BruteForceComplete.Split(a, out var resultA, out var resultB, out var resultDropped);

            // Do the compare.
            Assert.IsTrue(LinkedListSingleLinkNode<int>.Compare(resultA, expectedA));
            Assert.IsTrue(LinkedListSingleLinkNode<int>.Compare(resultB, expectedB));
            Assert.IsTrue(LinkedListSingleLinkNode<int>.Compare(resultDropped, expectedDropped));
        }

        /// <summary>
        /// Tests Split on an list with a single element.
        /// </summary>
        [TestMethod]
        public void LinkedListSingleLinkSplit1BruteForceCompleteTestSingleElement()
        {
            // First list.
            var toSplit = LinkedListSingleLinkNode<int>.CreateFromData(3);

            // Expected A (1st half of list)
            var expectedDropped = LinkedListSingleLinkNode<int>.CreateFromData(3);

            // Split the list.
            LinkedListSingleLinkSplit1BruteForceComplete.Split(toSplit, out var resultA, out var resultB, out var resultDropped);

            // Do the compare.
            Assert.IsTrue(LinkedListSingleLinkNode<int>.Compare(resultA, null));
            Assert.IsTrue(LinkedListSingleLinkNode<int>.Compare(resultB, null));
            Assert.IsTrue(LinkedListSingleLinkNode<int>.Compare(resultDropped, expectedDropped));
        }

        /// <summary>
        /// Tests Split on an empty list (null reference)
        /// </summary>
        [TestMethod]
        public void LinkedListSingleLinkSplit1BruteForceCompleteTestEmptyList()
        {
            // Split the list.
            LinkedListSingleLinkSplit1BruteForceComplete.Split(null, out var resultA, out var resultB, out var resultDropped);

            // Do the compare.
            Assert.IsTrue(LinkedListSingleLinkNode<int>.Compare(resultA, null));
            Assert.IsTrue(LinkedListSingleLinkNode<int>.Compare(resultB, null));
            Assert.IsTrue(LinkedListSingleLinkNode<int>.Compare(resultDropped, null));
        }
    }
}
