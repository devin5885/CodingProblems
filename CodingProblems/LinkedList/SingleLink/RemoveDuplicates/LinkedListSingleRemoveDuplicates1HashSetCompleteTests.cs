using CodingProblems.LinkedList.SingleLink.Helpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodingProblems.LinkedList.SingleLink.RemoveDuplicates
{
    /// <summary>
    /// Tests LinkedListSingleRemoveDuplicates1HashSetComplete.RemoveDuplicates
    /// </summary>
    [TestClass]
    public class LinkedListSingleRemoveDuplicates1HashSetCompleteTests
    {
        /// <summary>
        /// Test removing a single duplicate.
        /// </summary>
        [TestMethod]
        public void LinkedListSingleRemoveDuplicates1HashSetCompleteTest1SingleDup()
        {
            // Create with helper.
            var actual = LinkedListSingleLinkNode<int>.CreateFromData(1, 2, 2, 3);
            var expected = LinkedListSingleLinkNode<int>.CreateFromData(1, 2, 3);
            LinkedListSingleRemoveDuplicates1HashSetComplete.RemoveDuplicates(actual);
            LinkedListSingleLinkNode<int>.Compare(expected, actual);
        }

        /// <summary>
        /// Test removing no duplicates.
        /// </summary>
        [TestMethod]
        public void LinkedListSingleRemoveDuplicates1HashSetCompleteTest2NoDups()
        {
            // Create with helper.
            var actual = LinkedListSingleLinkNode<int>.CreateFromData(1, 2, 3);
            var expected = LinkedListSingleLinkNode<int>.CreateFromData(1, 2, 3);
            LinkedListSingleRemoveDuplicates1HashSetComplete.RemoveDuplicates(actual);
            LinkedListSingleLinkNode<int>.Compare(expected, actual);
        }

        /// <summary>
        /// Test removing a duplicate at the end of the list.
        /// </summary>
        [TestMethod]
        public void LinkedListSingleRemoveDuplicates1HashSetCompleteTest3LastDup()
        {
            // Create with helper.
            var actual = LinkedListSingleLinkNode<int>.CreateFromData(1, 2, 2);
            var expected = LinkedListSingleLinkNode<int>.CreateFromData(1, 2);
            LinkedListSingleRemoveDuplicates1HashSetComplete.RemoveDuplicates(actual);
            LinkedListSingleLinkNode<int>.Compare(expected, actual);
        }

        /// <summary>
        /// Test removing a duplicate when the list only contains duplicates.
        /// </summary>
        [TestMethod]
        public void LinkedListSingleRemoveDuplicates1HashSetCompleteTest4SingleDup()
        {
            // Create with helper.
            var actual = LinkedListSingleLinkNode<int>.CreateFromData(1, 1, 1);
            var expected = LinkedListSingleLinkNode<int>.CreateFromData(1);
            LinkedListSingleRemoveDuplicates1HashSetComplete.RemoveDuplicates(actual);
            LinkedListSingleLinkNode<int>.Compare(expected, actual);
        }

        /// <summary>
        /// Test null list.
        /// </summary>
        [TestMethod]
        public void LinkedListSingleRemoveDuplicates1HashSetCompleteTest5NullList()
        {
            LinkedListSingleRemoveDuplicates1HashSetComplete.RemoveDuplicates(null);
        }

        /// <summary>
        /// Test removing a duplicate when the list only contains a single node.
        /// </summary>
        [TestMethod]
        public void LinkedListSingleRemoveDuplicates1HashSetCompleteTest6SingleNode()
        {
            // Create with helper.
            var actual = LinkedListSingleLinkNode<int>.CreateFromData(1);
            var expected = LinkedListSingleLinkNode<int>.CreateFromData(1);
            LinkedListSingleRemoveDuplicates1HashSetComplete.RemoveDuplicates(actual);
            LinkedListSingleLinkNode<int>.Compare(expected, actual);
        }
    }
}
