using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodingProblems.MultipleStacksUsingSingleArray
{
    /// <summary>
    /// Tests for StackUsingArray1VariableSizeComplete class.
    /// </summary>
    [TestClass]
    public class MultipleStacksUsingSingleArray2VariableSizeCompleteTests
    {
        // Single array variable tests.
        /*
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
        */

        // Fixed size - Multiple stacks tests.

        /// <summary>
        /// Tests push, pop, peek, count with an array with one item.
        /// </summary>
        [TestMethod]
        public void MultipleStacksUsingSingleArray1VariableSizeCompleteTestOneItem()
        {
            // Create three stacks.
            var st = new MultipleStacksUsingSingleArray2VariableSizeComplete<int>();

            // Check the count of each stack.
            Assert.AreEqual(0, st.Count(0));
            Assert.AreEqual(0, st.Count(1));
            Assert.AreEqual(0, st.Count(2));

            // Push an item onto the first stack.
            st.Push(0, 1);

            // Check the count of each stack.
            Assert.AreEqual(1, st.Count(0));
            Assert.AreEqual(0, st.Count(1));
            Assert.AreEqual(0, st.Count(2));

            // Push an item onto the second stack.
            st.Push(1, 2);

            // Check the count of each stack.
            Assert.AreEqual(1, st.Count(0));
            Assert.AreEqual(1, st.Count(1));
            Assert.AreEqual(0, st.Count(2));

            // Push an item onto the third stack.
            st.Push(2, 3);

            // Check the count of each stack.
            Assert.AreEqual(1, st.Count(0));
            Assert.AreEqual(1, st.Count(1));
            Assert.AreEqual(1, st.Count(2));

            // Peek at the items.
            Assert.AreEqual(1, st.Peek(0));
            Assert.AreEqual(2, st.Peek(1));
            Assert.AreEqual(3, st.Peek(2));

            // Pop the item from the first stack.
            Assert.AreEqual(1, st.Pop(0));

            // Check the count of each stack.
            Assert.AreEqual(0, st.Count(0));
            Assert.AreEqual(1, st.Count(1));
            Assert.AreEqual(1, st.Count(2));

            // Pop the item from the second stack.
            Assert.AreEqual(2, st.Pop(1));

            // Check the count of each stack.
            Assert.AreEqual(0, st.Count(0));
            Assert.AreEqual(0, st.Count(1));
            Assert.AreEqual(1, st.Count(2));

            // Pop the item from the third stack.
            Assert.AreEqual(3, st.Pop(2));

            // Check the count of each stack.
            Assert.AreEqual(0, st.Count(0));
            Assert.AreEqual(0, st.Count(1));
            Assert.AreEqual(0, st.Count(2));
        }

        /// <summary>
        /// Tests push, pop, peek, count with an array with multiple items.
        /// </summary>
        [TestMethod]
        public void MultipleStacksUsingSingleArray2VariableSizeCompleteMultipleItems()
        {
            // Create three stacks.
            var st = new MultipleStacksUsingSingleArray2VariableSizeComplete<int>();

            // Check the count of each stack.
            Assert.AreEqual(0, st.Count(0));
            Assert.AreEqual(0, st.Count(1));
            Assert.AreEqual(0, st.Count(2));

            // Push an item onto the 0 stack.
            st.Push(stackNumber: 0, item: 1);

            // Check the count of each stack.
            Assert.AreEqual(1, st.Count(0));
            Assert.AreEqual(0, st.Count(1));
            Assert.AreEqual(0, st.Count(2));

            // Push an two items onto the 1 stack.
            st.Push(stackNumber: 1, item: 1);
            st.Push(stackNumber: 1, item: 2);

            // Check the count of each stack.
            Assert.AreEqual(1, st.Count(0));
            Assert.AreEqual(2, st.Count(1));
            Assert.AreEqual(0, st.Count(2));

            // Push a three items onto the 2 stack.
            st.Push(stackNumber: 2, item: 1);
            st.Push(stackNumber: 2, item: 2);
            st.Push(stackNumber: 2, item: 3);

            // Check the count of each stack.
            Assert.AreEqual(1, st.Count(0));
            Assert.AreEqual(2, st.Count(1));
            Assert.AreEqual(3, st.Count(2));

            // Peek at the top items in each stack.
            Assert.AreEqual(1, st.Peek(0));
            Assert.AreEqual(2, st.Peek(1));
            Assert.AreEqual(3, st.Peek(2));

            // Pop an item from each stack.
            Assert.AreEqual(1, st.Pop(0));
            Assert.AreEqual(2, st.Pop(1));
            Assert.AreEqual(3, st.Pop(2));

            // Check the count of each stack.
            Assert.AreEqual(0, st.Count(0));
            Assert.AreEqual(1, st.Count(1));
            Assert.AreEqual(2, st.Count(2));

            // Pop an item from the stacks that still have items.
            Assert.AreEqual(1, st.Pop(1));
            Assert.AreEqual(2, st.Pop(2));

            // Check the count of each stack.
            Assert.AreEqual(0, st.Count(0));
            Assert.AreEqual(0, st.Count(1));
            Assert.AreEqual(1, st.Count(2));

            // Pop an item from the stacks that still have items.
            Assert.AreEqual(1, st.Pop(2));

            // Check the count of each stack.
            Assert.AreEqual(0, st.Count(0));
            Assert.AreEqual(0, st.Count(1));
            Assert.AreEqual(0, st.Count(2));

            // Push allot of items onto the stacks.
            st.Push(stackNumber: 0, item: 1);
            st.Push(stackNumber: 0, item: 2);
            st.Push(stackNumber: 1, item: 1);
            st.Push(stackNumber: 1, item: 2);
            st.Push(stackNumber: 2, item: 1);
            st.Push(stackNumber: 2, item: 2);
            st.Push(stackNumber: 0, item: 3);
            st.Push(stackNumber: 1, item: 3);
            st.Push(stackNumber: 2, item: 3);
            st.Push(stackNumber: 0, item: 4);
            st.Push(stackNumber: 1, item: 4);
            st.Push(stackNumber: 2, item: 4);

            // Pop them.
            Assert.AreEqual(4, st.Pop(0));
            Assert.AreEqual(3, st.Pop(0));
            Assert.AreEqual(2, st.Pop(0));
            Assert.AreEqual(1, st.Pop(0));
            Assert.AreEqual(4, st.Pop(1));
            Assert.AreEqual(3, st.Pop(1));
            Assert.AreEqual(2, st.Pop(1));
            Assert.AreEqual(1, st.Pop(1));
            Assert.AreEqual(4, st.Pop(2));
            Assert.AreEqual(3, st.Pop(2));
            Assert.AreEqual(2, st.Pop(2));
            Assert.AreEqual(1, st.Pop(2));
        }

        /// <summary>
        /// Tests push with an invalid stack #.
        /// </summary>
        [TestMethod]
        public void MultipleStacksUsingSingleArray2VariableSizeCompleteTestInvalidStackNumber()
        {
            // Create three stack with 2 items each.
            var st = new MultipleStacksUsingSingleArray2VariableSizeComplete<int>(stackCount: 2);

            try
            {
                st.Push(stackNumber: 2, item: 1);
            }
            catch (ArgumentException)
            {
                // Exception.
                Assert.IsTrue(true);
                return;
            }

            // No exception.
            Assert.Fail();
        }

        /// <summary>
        /// Tests peek with an invalid stack #.
        /// </summary>
        [TestMethod]
        public void MultipleStacksUsingSingleArray2VariableSizeCompleteTestPopInvalidStackNumber()
        {
            // Create three stack with 2 items each.
            var st = new MultipleStacksUsingSingleArray2VariableSizeComplete<int>(stackCount: 2);

            // Push an item.
            st.Push(stackNumber: 0, item: 1);

            try
            {
                st.Pop(stackNumber: 2);
            }
            catch (ArgumentException)
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
        public void MultipleStacksUsingSingleArray1FixedSizeCompleteTestPopEmptyStack()
        {
            // Create stack & push three items.
            var st = new MultipleStacksUsingSingleArray1FixedSizeComplete<int>(2);

            try
            {
                st.Pop(stackNumber: 0);
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
        /// Tests peek with an invalid stack #.
        /// </summary>
        [TestMethod]
        public void MultipleStacksUsingSingleArray2VariableSizeCompleteTestPeekInvalidStackNumber()
        {
            // Create three stack with 2 items each.
            var st = new MultipleStacksUsingSingleArray2VariableSizeComplete<int>(stackCount: 2);

            // Push an item.
            st.Push(stackNumber: 0, item: 1);

            try
            {
                st.Peek(stackNumber: 2);
            }
            catch (ArgumentException)
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
        public void MultipleStacksUsingSingleArray2VariableSizeCompleteTestPeekEmptyStack()
        {
            // Create stack & push three items.
            var st = new MultipleStacksUsingSingleArray2VariableSizeComplete<int>(2);

            try
            {
                st.Peek(stackNumber: 0);
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
