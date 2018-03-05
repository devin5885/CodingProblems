using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodingProblems.LinkedList.SingleLink.Helpers
{
    /// <summary>
    /// Tests the LinkedListSingleLinkNode.CreateFromData method.
    /// </summary>
    [TestClass]
    public class LinkedListSingleLinkCreateFromDataTests
    {
        /// <summary>
        /// Test the null case.
        /// </summary>
        [TestMethod]
        public void LinkedListSingleLinkTestsCreateFromDataNull()
        {
            // Create with helper.
            var resa = LinkedListSingleLinkNode<int>.CreateFromData(null);

            // Compare
            Assert.IsTrue(LinkedListSingleLinkNode<int>.Compare(null, resa));
        }

        /// <summary>
        /// Tests creating a list with a single node.
        /// </summary>
        [TestMethod]
        public void LinkedListSingleLinkTestsCreateFromDataOne()
        {
            // Create manually.
            var a = new LinkedListSingleLinkNode<int>(1);

            // Create with helper.
            var resa = LinkedListSingleLinkNode<int>.CreateFromData(1);

            // Compare
            Assert.IsTrue(LinkedListSingleLinkNode<int>.Compare(a, resa));
        }

        /// <summary>
        /// Tests creating a list with two nodes.
        /// </summary>
        [TestMethod]
        public void LinkedListSingleLinkTestsCreateFromDataTwo()
        {
            // Create manually.
            var b = new LinkedListSingleLinkNode<int>(2);
            var a = new LinkedListSingleLinkNode<int>(1, b);

            // Create with helper.
            var resa = LinkedListSingleLinkNode<int>.CreateFromData(1, 2);

            // Compare
            Assert.IsTrue(LinkedListSingleLinkNode<int>.Compare(a, resa));
        }

        /// <summary>
        /// Tests creating a list with three nodes.
        /// </summary>
        [TestMethod]
        public void LinkedListSingleLinkTestsCreateFromDataThree()
        {
            // Create manually.
            var c = new LinkedListSingleLinkNode<int>(3);
            var b = new LinkedListSingleLinkNode<int>(2, c);
            var a = new LinkedListSingleLinkNode<int>(1, b);

            // Create with helper.
            var resa = LinkedListSingleLinkNode<int>.CreateFromData(1, 2, 3);

            // Compare
            Assert.IsTrue(LinkedListSingleLinkNode<int>.Compare(a, resa));
        }
    }
}
