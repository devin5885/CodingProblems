using CodingProblems.LinkedList.SingleLink.Helpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodingProblems.LinkedList.SingleLink.FindIntersection
{
    /// <summary>
    /// Tests LinkedListSingleLinkFindIntersection1Complete.FindIntersection.
    /// </summary>
    [TestClass]
    public class LinkedListSingleLinkFindIntersection1BruteForceCompleteTests
    {
        /// <summary>
        /// Tests the case in which the lists intersect.
        /// </summary>
        [TestMethod]
        public void LinkedListSingleLinkFindIntersection1BruteForceCompleteTest1IntersectionFound()
        {
            // Note that since we need intersecting nodes, we can't use our helpers
            // to construct these lists.

            // Construct:
            // 11 -> 12 -> 13 -> (Common) 101 -> (Common) 102
            // 21 -> 22 -> 23 -> 24 ->  (Common) 101 -> (Common) 102

            // Initialize first list.
            var third1 = new LinkedListSingleLinkNode<int>
            {
                Value = 13
            };

            var second1 = new LinkedListSingleLinkNode<int>
            {
                Next = third1,
                Value = 12
            };

            var first1 = new LinkedListSingleLinkNode<int>
            {
                Next = second1,
                Value = 11
            };

            // Initialize second list.
            var fourth2 = new LinkedListSingleLinkNode<int>
            {
                Value = 24
            };

            var third2 = new LinkedListSingleLinkNode<int>
            {
                Next = fourth2,
                Value = 23
            };

            var second2 = new LinkedListSingleLinkNode<int>
            {
                Next = third2,
                Value = 22
            };

            var first2 = new LinkedListSingleLinkNode<int>
            {
                Next = second2,
                Value = 21
            };

            // Initialize common nodes.
            var common1 = new LinkedListSingleLinkNode<int>
            {
                Value = 101
            };
            fourth2.Next = common1;
            third1.Next = common1;

            var common2 = new LinkedListSingleLinkNode<int>
            {
                Value = 102
            };
            common1.Next = common2;

            // Do check.
            Assert.AreEqual(common1, LinkedListSingleLinkFindIntersection1BruteForceComplete.FindIntersection(first1, first2));
        }

        /// <summary>
        /// Tests the case in which the lists do no intersect.
        /// </summary>
        [TestMethod]
        public void LinkedListSingleLinkFindIntersection1BruteForceCompleteTest2NoIntersectionFound()
        {
            // Note that since we need intersecting nodes, we can't use our helpers
            // to construct these lists.

            // Construct:
            // 11 -> 12 -> 13
            // 21 -> 22 -> 23 -> 24

            // Initialize first list.
            var third1 = new LinkedListSingleLinkNode<int>
            {
                Value = 13
            };

            var second1 = new LinkedListSingleLinkNode<int>
            {
                Next = third1,
                Value = 12
            };

            var first1 = new LinkedListSingleLinkNode<int>
            {
                Next = second1,
                Value = 11
            };

            // Initialize second list.
            var fourth2 = new LinkedListSingleLinkNode<int>
            {
                Value = 24
            };

            var third2 = new LinkedListSingleLinkNode<int>
            {
                Next = fourth2,
                Value = 23
            };

            var second2 = new LinkedListSingleLinkNode<int>
            {
                Next = third2,
                Value = 22
            };

            var first2 = new LinkedListSingleLinkNode<int>
            {
                Next = second2,
                Value = 21
            };

            // Do check.
            Assert.AreEqual(null, LinkedListSingleLinkFindIntersection1BruteForceComplete.FindIntersection(first1, first2));
        }

        /// <summary>
        /// Tests the case in which both lists are the same list.
        /// </summary>
        [TestMethod]
        public void LinkedListSingleLinkFindIntersection1BruteForceCompleteTest3SameList()
        {
            // Note that since we need intersecting nodes, we can't use our helpers
            // to construct these lists.

            // Construct:
            // 11 -> 12 -> 13

            // Initialize first list.
            var third1 = new LinkedListSingleLinkNode<int>
            {
                Value = 13
            };

            var second1 = new LinkedListSingleLinkNode<int>
            {
                Next = third1,
                Value = 12
            };

            var first1 = new LinkedListSingleLinkNode<int>
            {
                Next = second1,
                Value = 11
            };

            // Do check.
            Assert.AreEqual(first1, LinkedListSingleLinkFindIntersection1BruteForceComplete.FindIntersection(first1, first1));
        }

        /// <summary>
        /// Tests the null list 1 case.
        /// </summary>
        [TestMethod]
        public void LinkedListSingleLinkFindIntersection1BruteForceCompleteTest4NullList1()
        {
            var first2 = new LinkedListSingleLinkNode<int>
            {
                Value = 21
            };

            // Do check.
            Assert.AreEqual(null, LinkedListSingleLinkFindIntersection1BruteForceComplete.FindIntersection(null, first2));
        }

        /// <summary>
        /// Tests the null list 2 case.
        /// </summary>
        [TestMethod]
        public void LinkedListSingleLinkFindIntersection1BruteForceCompleteTest5NullList2()
        {
            var first1 = new LinkedListSingleLinkNode<int>
            {
                Value = 11
            };

            // Do check.
            Assert.AreEqual(null, LinkedListSingleLinkFindIntersection1BruteForceComplete.FindIntersection(first1, null));
        }

        /// <summary>
        /// Tests the both null lists.
        /// </summary>
        [TestMethod]
        public void LinkedListSingleLinkFindIntersection1BruteForceCompleteTest6NullListBoth()
        {
            Assert.AreEqual(null, LinkedListSingleLinkFindIntersection1BruteForceComplete.FindIntersection(null, null));
        }
    }
}
