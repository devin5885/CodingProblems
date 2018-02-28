using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodingProblems.Stack.UsingArray.UnlimitedSize
{
    /// <summary>
    /// Tests for StackUsingArray1VariableSizeComplete class.
    /// </summary>
    [TestClass]
    public class StackUsingArray2UnlimitedSizeCompleteTests
    {
        /// <summary>
        /// Tests push, pop, peek, count with an array with one item.
        /// </summary>
        [TestMethod]
        public void StackUsingArray1UnlimitedSizeTestOneItem()
        {
            // Create stack with capacity of 1.
            var st = new StackUsingArray2UnlimitedSizeComplete<int>();

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
        public void StackUsingArray1UnlimitedSizeTestMultipleItems()
        {
            // Create stack.
            var st = new StackUsingArray2UnlimitedSizeComplete<int>();

            // Check the count.
            Assert.AreEqual(0, st.Count);

            // Push one item.
            st.Push(1);

            // Check the count.
            Assert.AreEqual(1, st.Count);

            // Peek at the top item.
            Assert.AreEqual(1, st.Peek());

            // Pop the item.
            Assert.AreEqual(1, st.Pop());

            // Check the count.
            Assert.AreEqual(0, st.Count);

            // Push two items.
            st.Push(1);
            st.Push(2);

            // Check the count.
            Assert.AreEqual(2, st.Count);

            // Peek at the top item.
            Assert.AreEqual(2, st.Peek());

            // Pop the item.
            Assert.AreEqual(2, st.Pop());

            // Check the count.
            Assert.AreEqual(1, st.Count);

            // Peek at the top item.
            Assert.AreEqual(1, st.Peek());

            // Pop the item.
            Assert.AreEqual(1, st.Pop());

            // Check the count.
            Assert.AreEqual(0, st.Count);

            // Push three items.
            st.Push(1);
            st.Push(2);
            st.Push(3);

            // Check the count.
            Assert.AreEqual(3, st.Count);

            // Peek at the top item.
            Assert.AreEqual(3, st.Peek());

            // Pop the item.
            Assert.AreEqual(3, st.Pop());

            // Check the count.
            Assert.AreEqual(2, st.Count);

            // Peek at the top item.
            Assert.AreEqual(2, st.Peek());

            // Pop the item.
            Assert.AreEqual(2, st.Pop());

            // Check the count.
            Assert.AreEqual(1, st.Count);

            // Peek at the top item.
            Assert.AreEqual(1, st.Peek());

            // Pop the item.
            Assert.AreEqual(1, st.Pop());

            // Check the count.
            Assert.AreEqual(0, st.Count);

            // Push five items (Force a reallocation & copy).
            st.Push(1);
            st.Push(2);
            st.Push(3);
            st.Push(4);
            st.Push(5);

            // Check the count.
            Assert.AreEqual(5, st.Count);

            // Peek at the top item.
            Assert.AreEqual(5, st.Peek());

            // Pop the items.
            Assert.AreEqual(5, st.Pop());
            Assert.AreEqual(4, st.Pop());
            Assert.AreEqual(3, st.Pop());
            Assert.AreEqual(2, st.Pop());
            Assert.AreEqual(1, st.Pop());

            // Check the count.
            Assert.AreEqual(0, st.Count);
        }

        /// <summary>
        /// Tests pop with an empty stack.
        /// </summary>
        [TestMethod]
        public void StackUsingArray1UnlimitedSizeTestPopEmptyStack()
        {
            // Create stack & push three items.
            var st = new StackUsingArray2UnlimitedSizeComplete<int>();

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
        public void StackUsingArray1UnlimitedSizeTestPeekEmptyStack()
        {
            // Create stack & push three items.
            var st = new StackUsingArray2UnlimitedSizeComplete<int>();

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
