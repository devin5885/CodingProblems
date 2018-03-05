using CodingProblems.LinkedList.SingleLink.Helpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodingProblems.LinkedList.SingleLink.Partition
{
    /// <summary>
    /// Tests LinkedListSingleLinkPartition1StableComplete.Partition
    /// </summary>
    [TestClass]
    public class LinkedListSingleLinkPartition1StableCompleteTests
    {
        /// <summary>
        /// Null list.
        /// </summary>
        [TestMethod]
        public void LinkedListSingleLinkPartition1StableCompleteTest1NullList()
        {
            LinkedListSingleLinkNode<int> actual = null;
            LinkedListSingleLinkNode<int> expected = null;
            LinkedListSingleLinkPartition1StableComplete.Partition(ref actual, 7);
            Assert.IsTrue(LinkedListSingleLinkNode<int>.Compare(expected, actual));
        }

        /// <summary>
        /// Test in which there is a single node which is before the partition.
        /// </summary>
        [TestMethod]
        public void LinkedListSingleLinkPartition1StableCompleteTest2SingleAllBefore()
        {
            var actual = LinkedListSingleLinkNode<int>.CreateFromData(2);
            var expected = LinkedListSingleLinkNode<int>.CreateFromData(2);
            LinkedListSingleLinkPartition1StableComplete.Partition(ref actual, 3);
            Assert.IsTrue(LinkedListSingleLinkNode<int>.Compare(expected, actual));
        }

        /// <summary>
        /// Test in which there is a single node which is after the partition.
        /// </summary>
        [TestMethod]
        public void LinkedListSingleLinkPartition1StableCompleteTest3SingleAllAfter()
        {
            var actual = LinkedListSingleLinkNode<int>.CreateFromData(2);
            var expected = LinkedListSingleLinkNode<int>.CreateFromData(2);
            LinkedListSingleLinkPartition1StableComplete.Partition(ref actual, 1);
            Assert.IsTrue(LinkedListSingleLinkNode<int>.Compare(expected, actual));
        }

        /// <summary>
        /// Test in which there is a single node which is the partition.
        /// </summary>
        [TestMethod]
        public void LinkedListSingleLinkPartition1StableCompleteTest4SingleIsPartition()
        {
            var actual = LinkedListSingleLinkNode<int>.CreateFromData(1);
            var expected = LinkedListSingleLinkNode<int>.CreateFromData(1);
            LinkedListSingleLinkPartition1StableComplete.Partition(ref actual, 1);
            Assert.IsTrue(LinkedListSingleLinkNode<int>.Compare(expected, actual));
        }

        /// <summary>
        /// Test in which there are 2 nodes.
        /// </summary>
        [TestMethod]
        public void LinkedListSingleLinkPartition1StableCompleteTest5SingleBefore()
        {
            var actual = LinkedListSingleLinkNode<int>.CreateFromData(3, 2);
            var expected = LinkedListSingleLinkNode<int>.CreateFromData(3, 2);
            LinkedListSingleLinkPartition1StableComplete.Partition(ref actual, 2);
            Assert.IsTrue(LinkedListSingleLinkNode<int>.Compare(expected, actual));
        }

        /// <summary>
        /// Test in which there are 3 nodes.
        /// </summary>
        [TestMethod]
        public void LinkedListSingleLinkPartition1StableCompleteTest6SingleBeforeAfter()
        {
            var actual = LinkedListSingleLinkNode<int>.CreateFromData(3, 2, 1);
            var expected = LinkedListSingleLinkNode<int>.CreateFromData(1, 3, 2);
            LinkedListSingleLinkPartition1StableComplete.Partition(ref actual, 2);
            Assert.IsTrue(LinkedListSingleLinkNode<int>.Compare(expected, actual));
        }

        /// <summary>
        /// Test in which all nodes are before the partition value.
        /// </summary>
        [TestMethod]
        public void LinkedListSingleLinkPartition1StableCompleteTest7AllBefore()
        {
            var actual = LinkedListSingleLinkNode<int>.CreateFromData(1, 2, 8, 7, 5, 3);
            var expected = LinkedListSingleLinkNode<int>.CreateFromData(1, 2, 8, 7, 5, 3);
            LinkedListSingleLinkPartition1StableComplete.Partition(ref actual, 9);
            Assert.IsTrue(LinkedListSingleLinkNode<int>.Compare(expected, actual));
        }

        /// <summary>
        /// Test in which all nodes are after the partition value.
        /// </summary>
        [TestMethod]
        public void LinkedListSingleLinkPartition1StableCompleteTest8AllAfter()
        {
            var actual = LinkedListSingleLinkNode<int>.CreateFromData(1, 2, 8, 7, 5, 3);
            var expected = LinkedListSingleLinkNode<int>.CreateFromData(1, 2, 8, 7, 5, 3);
            LinkedListSingleLinkPartition1StableComplete.Partition(ref actual, 0);
            Assert.IsTrue(LinkedListSingleLinkNode<int>.Compare(expected, actual));
        }

        /// <summary>
        /// Default Test.
        /// </summary>
        [TestMethod]
        public void LinkedListSingleLinkPartition1StableCompleteTest9Default()
        {
            var actual = LinkedListSingleLinkNode<int>.CreateFromData(1, 2, 8, 7, 5, 3);
            var expected = LinkedListSingleLinkNode<int>.CreateFromData(1, 2, 5, 3, 8, 7);
            LinkedListSingleLinkPartition1StableComplete.Partition(ref actual, 7);
            Assert.IsTrue(LinkedListSingleLinkNode<int>.Compare(expected, actual));
        }
    }
}
