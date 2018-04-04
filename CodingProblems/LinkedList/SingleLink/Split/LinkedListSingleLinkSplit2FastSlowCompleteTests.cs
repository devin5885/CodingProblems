using System;
using CodingProblems.LinkedList.SingleLink.Helpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodingProblems.LinkedList.SingleLink.Split
{
    /// <summary>
    /// Tests Split.
    /// </summary>
    [TestClass]
    public class LinkedListSingleLinkSplit2FastSlowCompleteTests
    {
        /// <summary>
        /// Tests Split on an list with an even number of elements.
        /// </summary>
        [TestMethod]
        public void LinkedListSingleLinkSplit2FastSlowCompleteTestSimpleEven()
        {
            // First list.
            var a = LinkedListSingleLinkNode<int>.CreateFromData(1, 2, 3, 4);

            // Expected A (1st half of list)
            var expectedA = LinkedListSingleLinkNode<int>.CreateFromData(1, 2);

            // Expected B (2nd half of list)
            var expectedB = LinkedListSingleLinkNode<int>.CreateFromData(3, 4);

            // Split the list.
            LinkedListSingleLinkSplit2FastSlowComplete.Split(a, out LinkedListSingleLinkNode<int> ResultA, out LinkedListSingleLinkNode<int> ResultB, out LinkedListSingleLinkNode<int> ResultDropped);

            // Do the compare.
            Assert.IsTrue(LinkedListSingleLinkNode<int>.Compare(ResultA, expectedA));
            Assert.IsTrue(LinkedListSingleLinkNode<int>.Compare(ResultB, expectedB));
            Assert.IsTrue(LinkedListSingleLinkNode<int>.Compare(ResultDropped, null));
        }

        /// <summary>
        /// Tests Split on an list with an odd number of elements.
        /// </summary>
        [TestMethod]
        public void LinkedListSingleLinkSplit2FastSlowCompleteTestSimpleOdd()
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
            LinkedListSingleLinkSplit2FastSlowComplete.Split(a, out LinkedListSingleLinkNode<int> ResultA, out LinkedListSingleLinkNode<int> ResultB, out LinkedListSingleLinkNode<int> ResultDropped);

            // Do the compare.
            Assert.IsTrue(LinkedListSingleLinkNode<int>.Compare(ResultA, expectedA));
            Assert.IsTrue(LinkedListSingleLinkNode<int>.Compare(ResultB, expectedB));
            Assert.IsTrue(LinkedListSingleLinkNode<int>.Compare(ResultDropped, expectedDropped));
        }

        /// <summary>
        /// Tests Split on an list with a single element.
        /// </summary>
        [TestMethod]
        public void LinkedListSingleLinkSplit2FastSlowCompleteTestSingleElement()
        {
            // First list.
            var toSplit = LinkedListSingleLinkNode<int>.CreateFromData(3);

            // Expected A (1st half of list)
            var expectedDropped = LinkedListSingleLinkNode<int>.CreateFromData(3);

            // Split the list.
            LinkedListSingleLinkSplit2FastSlowComplete.Split(toSplit, out LinkedListSingleLinkNode<int> ResultA, out LinkedListSingleLinkNode<int> ResultB, out LinkedListSingleLinkNode<int> ResultDropped);

            // Do the compare.
            Assert.IsTrue(LinkedListSingleLinkNode<int>.Compare(ResultA, null));
            Assert.IsTrue(LinkedListSingleLinkNode<int>.Compare(ResultB, null));
            Assert.IsTrue(LinkedListSingleLinkNode<int>.Compare(ResultDropped, expectedDropped));
        }

        /// <summary>
        /// Tests Split on an empty list (null reference)
        /// </summary>
        [TestMethod]
        public void LinkedListSingleLinkSplit2FastSlowCompleteTestEmptyList()
        {
            // Split the list.
            LinkedListSingleLinkSplit2FastSlowComplete.Split(null, out LinkedListSingleLinkNode<int> ResultA, out LinkedListSingleLinkNode<int> ResultB, out LinkedListSingleLinkNode<int> ResultDropped);

            // Do the compare.
            Assert.IsTrue(LinkedListSingleLinkNode<int>.Compare(ResultA, null));
            Assert.IsTrue(LinkedListSingleLinkNode<int>.Compare(ResultB, null));
            Assert.IsTrue(LinkedListSingleLinkNode<int>.Compare(ResultDropped, null));
        }
    }
}
