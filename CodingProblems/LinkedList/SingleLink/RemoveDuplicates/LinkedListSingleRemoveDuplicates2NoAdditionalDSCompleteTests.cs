using CodingProblems.LinkedList.SingleLink.Helpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodingProblems.LinkedList.SingleLink.RemoveDuplicates
{
    /// <summary>
    /// Tests LinkedListSingleRemoveDuplicates1HashSetComplete.RemoveDuplicates
    /// </summary>
    [TestClass]
    public class LinkedListSingleRemoveDuplicates2NoAdditionalDSCompleteTests
    {
        /// <summary>
        /// Test removing a single duplicate.
        /// </summary>
        [TestMethod]
        public void LinkedListSingleRemoveDuplicates2NoAdditionalDSCompleteTest1SingleDup()
        {
            // Create with helper.
            var actual = LinkedListSingleLinkNode<int>.CreateFromData(1, 2, 2, 3);
            var expected = LinkedListSingleLinkNode<int>.CreateFromData(1, 2, 3);
            LinkedListSingleRemoveDuplicates2NoAdditionalDSComplete.RemoveDuplicates(actual);
            LinkedListSingleLinkNode<int>.Compare(expected, actual);
        }

        /// <summary>
        /// Test removing no duplicates.
        /// </summary>
        [TestMethod]
        public void LinkedListSingleRemoveDuplicates2NoAdditionalDSCompleteTest2NoDups()
        {
            // Create with helper.
            var actual = LinkedListSingleLinkNode<int>.CreateFromData(1, 2, 3);
            var expected = LinkedListSingleLinkNode<int>.CreateFromData(1, 2, 3);
            LinkedListSingleRemoveDuplicates2NoAdditionalDSComplete.RemoveDuplicates(actual);
            LinkedListSingleLinkNode<int>.Compare(expected, actual);
        }

        /// <summary>
        /// Test removing a duplicate at the end of the list.
        /// </summary>
        [TestMethod]
        public void LinkedListSingleRemoveDuplicates2NoAdditionalDSCompleteTest3LastDup()
        {
            // Create with helper.
            var actual = LinkedListSingleLinkNode<int>.CreateFromData(1, 2, 2);
            var expected = LinkedListSingleLinkNode<int>.CreateFromData(1, 2);
            LinkedListSingleRemoveDuplicates2NoAdditionalDSComplete.RemoveDuplicates(actual);
            LinkedListSingleLinkNode<int>.Compare(expected, actual);
        }

        /// <summary>
        /// Test removing a duplicate when the list only contains duplicates.
        /// </summary>
        [TestMethod]
        public void LinkedListSingleRemoveDuplicates2NoAdditionalDSCompleteTest4SingleDup()
        {
            // Create with helper.
            var actual = LinkedListSingleLinkNode<int>.CreateFromData(1, 1, 1);
            var expected = LinkedListSingleLinkNode<int>.CreateFromData(1);
            LinkedListSingleRemoveDuplicates2NoAdditionalDSComplete.RemoveDuplicates(actual);
            LinkedListSingleLinkNode<int>.Compare(expected, actual);
        }

        /// <summary>
        /// Test null list.
        /// </summary>
        [TestMethod]
        public void LinkedListSingleRemoveDuplicates1HashSetCompleteTest5NullList()
        {
            LinkedListSingleRemoveDuplicates2NoAdditionalDSComplete.RemoveDuplicates(null);
        }

        /// <summary>
        /// Test removing a duplicate when the list only contains a single node.
        /// </summary>
        [TestMethod]
        public void LinkedListSingleRemoveDuplicates2NoAdditionalDSCompleteTest6SingleNode()
        {
            // Create with helper.
            var actual = LinkedListSingleLinkNode<int>.CreateFromData(1);
            var expected = LinkedListSingleLinkNode<int>.CreateFromData(1);
            LinkedListSingleRemoveDuplicates2NoAdditionalDSComplete.RemoveDuplicates(actual);
            LinkedListSingleLinkNode<int>.Compare(expected, actual);
        }
    }
}
