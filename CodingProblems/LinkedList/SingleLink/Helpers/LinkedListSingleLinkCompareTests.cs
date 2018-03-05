using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodingProblems.LinkedList.SingleLink.Helpers
{
    /// <summary>
    /// Tests the LinkedListSingleLinkNode.Compare method.
    /// </summary>
    [TestClass]
    public class LinkedListSingleLinkCompareTests
    {
        /// <summary>
        /// Tests comparing null lists.
        /// </summary>
        [TestMethod]
        public void LinkedListSingleLinkTestsCompareNullLists()
        {
            Assert.IsTrue(LinkedListSingleLinkNode<int>.Compare(null, null));
        }

        /// <summary>
        /// Tests comparing a null list to a non-null list.
        /// </summary>
        [TestMethod]
        public void LinkedListSingleLinkTestsCompareNullListLeft()
        {
            var node1 = LinkedListSingleLinkNode<int>.CreateFromData(3);

            Assert.IsFalse(LinkedListSingleLinkNode<int>.Compare(null, node1));
        }

        /// <summary>
        /// Tests comparing a null list to a non-null list.
        /// </summary>
        [TestMethod]
        public void LinkedListSingleLinkTestsCompareNullListRight()
        {
            var node1 = LinkedListSingleLinkNode<int>.CreateFromData(3);

            Assert.IsFalse(LinkedListSingleLinkNode<int>.Compare(node1, null));
        }

        /// <summary>
        /// Tests comparing lists with a single matching elements.
        /// </summary>
        [TestMethod]
        public void LinkedListSingleLinkTestsCompareSingleMatchingElement()
        {
            var node1 = LinkedListSingleLinkNode<int>.CreateFromData(3);
            var node2 = LinkedListSingleLinkNode<int>.CreateFromData(3);

            Assert.IsTrue(LinkedListSingleLinkNode<int>.Compare(node1, node2));
        }

        /// <summary>
        /// Tests comparing lists with single non-matching elements.
        /// </summary>
        [TestMethod]
        public void LinkedListSingleLinkTestsCompareSingleNonMatchingElement()
        {
            var node1 = LinkedListSingleLinkNode<int>.CreateFromData(3);
            var node2 = LinkedListSingleLinkNode<int>.CreateFromData(4);

            Assert.IsFalse(LinkedListSingleLinkNode<int>.Compare(node1, node2));
        }

        /// <summary>
        /// Tests comparing lists with two matching elements.
        /// </summary>
        [TestMethod]
        public void LinkedListSingleLinkTestsCompareMultipleMatchingElements()
        {
            var node1 = LinkedListSingleLinkNode<int>.CreateFromData(3, 4);
            var node2 = LinkedListSingleLinkNode<int>.CreateFromData(3, 4);

            Assert.IsTrue(LinkedListSingleLinkNode<int>.Compare(node1, node2));
        }

        /// <summary>
        /// Tests comparing lists when the left list has more elements.
        /// </summary>
        [TestMethod]
        public void LinkedListSingleLinkTestsCompareSizeMismatchLeftLonger()
        {
            var node1 = LinkedListSingleLinkNode<int>.CreateFromData(3, 4);
            var node2 = LinkedListSingleLinkNode<int>.CreateFromData(3);

            Assert.IsFalse(LinkedListSingleLinkNode<int>.Compare(node1, node2));
        }

        /// <summary>
        /// Tests comparing lists when the right list has more elements.
        /// </summary>
        [TestMethod]
        public void LinkedListSingleLinkTestsCompareSizeMismatchRightLonger()
        {
            var node1 = LinkedListSingleLinkNode<int>.CreateFromData(3);
            var node2 = LinkedListSingleLinkNode<int>.CreateFromData(3, 4);

            Assert.IsFalse(LinkedListSingleLinkNode<int>.Compare(node1, node2));
        }
    }
}
