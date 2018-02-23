using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodingProblems.Stack.UsingArray
{
    /// <summary>
    /// Tests for StackUsingArray1VariableSizeComplete class.
    /// </summary>
    [TestClass]
    public class StackUsingArray2VariableSizeCompleteTests
    {
        /// <summary>
        /// Tests push, pop, peek, count with an array with one item.
        /// </summary>
        [TestMethod]
        public void StackUsingArray1VariableSizeTestOneItem()
        {
            // Create stack with capacity of 1.
            var st = new StackUsingArray2VariableSizeComplete<int>();

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
        public void StackUsingArray1VariableSizeTestTwoItems()
        {
            // Create stack with capacity of 3.
            var st = new StackUsingArray2VariableSizeComplete<int>();

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
        /// Tests pop with an empty stack.
        /// </summary>
        [TestMethod]
        public void StackUsingArray1VariableSizeTestPopEmptyStack()
        {
            // Create stack & push three items.
            var st = new StackUsingArray2VariableSizeComplete<int>();

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
        public void StackUsingArray1VariableSizeTestPeekEmptyStack()
        {
            // Create stack & push three items.
            var st = new StackUsingArray2VariableSizeComplete<int>();

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
