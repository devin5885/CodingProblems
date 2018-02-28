using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodingProblems.Stack.UsingArray.FixedSize
{
    /// <summary>
    /// Tests for StackUsingArray1FixedSizeComplete class.
    /// </summary>
    [TestClass]
    public class StackUsingArray1FixedSizeCompleteTests
    {
        /// <summary>
        /// Tests push, pop, peek, count with an array with one item.
        /// </summary>
        [TestMethod]
        public void StackUsingArray1FixedSizeTestOneItem()
        {
            // Create stack with capacity of 1.
            var st = new StackUsingArray1FixedSizeComplete<int>(1);

            // Check the count.
            Assert.AreEqual(0, st.Count);

            // Push an item.
            st.Push(1);

            // Check the count.
            Assert.AreEqual(1, st.Count);

            // Peek at the item.
            Assert.AreEqual(1, st.Peek());

            // Pop the item.
            Assert.AreEqual(1, st.Pop());

            // Check the count.
            Assert.AreEqual(0, st.Count);
        }

        /// <summary>
        /// Tests push, pop, peek, count with an array with multiple items.
        /// </summary>
        [TestMethod]
        public void StackUsingArray1FixedSizeTestTwoItems()
        {
            // Create stack with capacity of 3.
            var st = new StackUsingArray1FixedSizeComplete<int>(3);

            // Check the count.
            Assert.AreEqual(0, st.Count);

            // Push & pop items.
            st.Push(1);
            st.Pop();
            st.Push(1);
            st.Push(2);
            st.Push(3);
            st.Pop();

            // Check the count.
            Assert.AreEqual(2, st.Count);

            // Peek at the top item.
            Assert.AreEqual(2, st.Peek());

            // Pop the item.
            Assert.AreEqual(2, st.Pop());

            // Check the count.
            Assert.AreEqual(1, st.Count);
        }

        /// <summary>
        /// Tests push with a full stack.
        /// </summary>
        [TestMethod]
        public void StackUsingArray1FixedSizeTestOverflow()
        {
            // Create stack & push three items.
            var st = new StackUsingArray1FixedSizeComplete<int>(2);
            st.Push(1);
            st.Push(2);

            try
            {
                st.Push(3);
            }
            catch (InvalidOperationException)
            {
                // Exception.
                Assert.IsTrue(true);
                return;
            }

            // No exception.
            Assert.Fail();
        }

        /// <summary>
        /// Tests pop with an empty stack.
        /// </summary>
        [TestMethod]
        public void StackUsingArray1FixedSizeTestPopEmptyStack()
        {
            // Create stack & push three items.
            var st = new StackUsingArray1FixedSizeComplete<int>(2);

            try
            {
                st.Pop();
            }
            catch (InvalidOperationException)
            {
                // Exception.
                Assert.IsTrue(true);
                return;
            }

            // No exception.
            Assert.Fail();
        }

        /// <summary>
        /// Tests peek with an empty stack.
        /// </summary>
        [TestMethod]
        public void StackUsingArray1FixedSizeTestPeekEmptyStack()
        {
            // Create stack & push three items.
            var st = new StackUsingArray1FixedSizeComplete<int>(2);

            try
            {
                st.Peek();
            }
            catch (InvalidOperationException)
            {
                // Exception.
                Assert.IsTrue(true);
                return;
            }

            // No exception.
            Assert.Fail();
        }
    }
}
