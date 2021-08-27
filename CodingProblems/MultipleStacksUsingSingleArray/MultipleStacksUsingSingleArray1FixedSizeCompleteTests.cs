using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodingProblems.MultipleStacksUsingSingleArray
{
    /// <summary>
    /// Tests for StackUsingArray1FixedSizeComplete class.
    /// </summary>
    [TestClass]
    public class MultipleStacksUsingSingleArray1FixedSizeCompleteTests
    {
        /// <summary>
        /// Tests push, pop, peek, count with an array with one item.
        /// </summary>
        [TestMethod]
        public void MultipleStacksUsingSingleArray1FixedSizeCompleteTestOneItem()
        {
            // Create three stacks with capacity of 1.
            var st = new MultipleStacksUsingSingleArray1FixedSizeComplete<int>(1);

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
        public void MultipleStacksUsingSingleArray1FixedSizeCompleteTwoItems()
        {
            // Create three stacks with capacity of 3.
            var st = new MultipleStacksUsingSingleArray1FixedSizeComplete<int>(3);

            // Check the count of each stack.
            Assert.AreEqual(0, st.Count(0));
            Assert.AreEqual(0, st.Count(1));
            Assert.AreEqual(0, st.Count(2));

            // Push an item onto the 0 stack.
            st.Push(0, 1);

            // Check the count of each stack.
            Assert.AreEqual(1, st.Count(0));
            Assert.AreEqual(0, st.Count(1));
            Assert.AreEqual(0, st.Count(2));

            // Push an item onto the 1 stack.
            st.Push(1, 1);

            // Check the count of each stack.
            Assert.AreEqual(1, st.Count(0));
            Assert.AreEqual(1, st.Count(1));
            Assert.AreEqual(0, st.Count(2));

            // Push a second item onto the 1 stack.
            st.Push(1, 2);

            // Check the count of each stack.
            Assert.AreEqual(1, st.Count(0));
            Assert.AreEqual(2, st.Count(1));
            Assert.AreEqual(0, st.Count(2));

            // Push an item onto the 2 stack.
            st.Push(2, 1);

            // Check the count of each stack.
            Assert.AreEqual(1, st.Count(0));
            Assert.AreEqual(2, st.Count(1));
            Assert.AreEqual(1, st.Count(2));

            // Push a second item onto the 2 stack.
            st.Push(2, 2);

            // Check the count of each stack.
            Assert.AreEqual(1, st.Count(0));
            Assert.AreEqual(2, st.Count(1));
            Assert.AreEqual(2, st.Count(2));

            // Push an second item onto the 0 stack.
            st.Push(0, 2);

            // Peek at the items.
            Assert.AreEqual(2, st.Peek(0));
            Assert.AreEqual(2, st.Peek(1));
            Assert.AreEqual(2, st.Peek(2));

            // Pop the item from the 0 stack.
            Assert.AreEqual(2, st.Pop(0));

            // Check the count of each stack.
            Assert.AreEqual(1, st.Count(0));
            Assert.AreEqual(2, st.Count(1));
            Assert.AreEqual(2, st.Count(2));

            // Pop the item from the 1 stack.
            Assert.AreEqual(2, st.Pop(1));

            // Check the count of each stack.
            Assert.AreEqual(1, st.Count(0));
            Assert.AreEqual(1, st.Count(1));
            Assert.AreEqual(2, st.Count(2));

            // Pop the item from the 2 stack.
            Assert.AreEqual(2, st.Pop(2));

            // Check the count of each stack.
            Assert.AreEqual(1, st.Count(0));
            Assert.AreEqual(1, st.Count(1));
            Assert.AreEqual(1, st.Count(2));
        }

        /// <summary>
        /// Tests push with an invalid stack #.
        /// </summary>
        [TestMethod]
        public void MultipleStacksUsingSingleArray1FixedSizeCompleteTestInvalidStackNumber()
        {
            // Create three stack with 2 items each.
            var st = new MultipleStacksUsingSingleArray1FixedSizeComplete<int>(3, 2);

            try
            {
                st.Push(2, 1);
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
        /// Tests push with a full stack.
        /// </summary>
        [TestMethod]
        public void MultipleStacksUsingSingleArray1FixedSizeCompleteTestOverflow()
        {
            // Create three stack with 2 items each.
            var st = new MultipleStacksUsingSingleArray1FixedSizeComplete<int>(2);

            // Push 3 items to first stack.
            st.Push(0, 1);
            st.Push(0, 2);

            try
            {
                st.Push(0, 3);
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
        public void MultipleStacksUsingSingleArray1FixedSizeCompleteTestPopInvalidStackNumber()
        {
            // Create three stack with 2 items each.
            var st = new MultipleStacksUsingSingleArray1FixedSizeComplete<int>(3, 2);

            // Push an item.
            st.Push(0, 1);

            try
            {
                st.Pop(2);
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
                st.Pop(0);
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
        public void MultipleStacksUsingSingleArray1FixedSizeCompleteTestPeekInvalidStackNumber()
        {
            // Create three stack with 2 items each.
            var st = new MultipleStacksUsingSingleArray1FixedSizeComplete<int>(3, 2);

            // Push an item.
            st.Push(0, 1);

            try
            {
                st.Peek(2);
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
        public void MultipleStacksUsingSingleArray1FixedSizeCompleteTestPeekEmptyStack()
        {
            // Create stack & push three items.
            var st = new MultipleStacksUsingSingleArray1FixedSizeComplete<int>(2);

            try
            {
                st.Peek(0);
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
