using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodingProblems.Queue.Stacks
{
    /// <summary>
    /// Tests for QueueViaStack1SimpleComplete
    /// </summary>
    [TestClass]
    public class QueueViaStacks2OptimizedCompleteTests
    {
        /// <summary>
        /// Simple test that enqueues and dequeues an element with count checking.
        /// </summary>
        [TestMethod]
        public void QueueViaStacks2OptimizedCompleteTest1()
        {
            // Allocate queue.
            var q = new QueueViaStacks2OptimizedComplete<int>();

            // Check count.
            Assert.AreEqual(0, q.Count);

            // Enqueue
            q.Enqueue(5);

            // Check count.
            Assert.AreEqual(1, q.Count);

            // Peek
            Assert.AreEqual(5, q.Peek());

            // Dequeue
            Assert.AreEqual(5, q.Dequeue());

            // Check count.
            Assert.AreEqual(0, q.Count);
        }

        /// <summary>
        /// Test that enqueues and dequeues several elements with count checking.
        /// </summary>
        [TestMethod]
        public void QueueViaStacks2OptimizedCompleteTest2()
        {
            // Allocate queue.
            var q = new QueueViaStacks1SimpleComplete<int>();

            // Check count.
            Assert.AreEqual(0, q.Count);

            // Enqueue
            q.Enqueue(5);
            q.Enqueue(10);

            // Check count.
            Assert.AreEqual(2, q.Count);

            // Peek
            Assert.AreEqual(5, q.Peek());

            // Dequeue
            Assert.AreEqual(5, q.Dequeue());

            // Check count.
            Assert.AreEqual(1, q.Count);

            // Peek
            Assert.AreEqual(10, q.Peek());

            // Dequeue
            Assert.AreEqual(10, q.Dequeue());

            // Check count.
            Assert.AreEqual(0, q.Count);
        }

        /// <summary>
        /// Test that checks that attempting to dequeue from an empty queue
        /// fails with the appropriate exception.
        /// </summary>
        [TestMethod]
        public void QueueViaStacks2OptimizedCompleteErrorTestDequeueEmptyQueue()
        {
            // Allocate queue.
            var q = new QueueViaStacks1SimpleComplete<int>();

            try
            {
                q.Dequeue();
            }
            catch (InvalidOperationException)
            {
                Assert.IsTrue(true);
                return;
            }

            // Should not get here.
            Assert.Fail();
        }

        /// <summary>
        /// Test that checks that attempting to peek into an empty queue
        /// fails with the appropriate exception.
        /// </summary>
        [TestMethod]
        public void QueueViaStacks2OptimizedCompleteErrorTestPeekEmptyQueue()
        {
            // Allocate queue.
            var q = new QueueViaStacks1SimpleComplete<int>();

            try
            {
                q.Peek();
            }
            catch (InvalidOperationException)
            {
                Assert.IsTrue(true);
                return;
            }

            // Should not get here.
            Assert.Fail();
        }
    }
}
