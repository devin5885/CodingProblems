using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodingProblems.Utility.MinMaxHeap.UsingArray
{
    /// <summary>
    ///  Tests for MaxHeap.
    /// </summary>
    [TestClass]
    public class MaxHeapUsingArrayTests
    {
        /// <summary>
        ///  Check that a max heap with a single element works correctly.
        /// </summary>
        [TestMethod]
        public void MaxHeapTestOneElement()
        {
            // Create and add a single element.
            var maxHeap = new MaxHeap();
            maxHeap.Insert(4);
            Assert.IsTrue(maxHeap.CheckValid());
            CollectionAssert.AreEqual(new List<int> { default, 4 }, maxHeap.GetHeap());

            // Extract and check the extraction.
            Assert.AreEqual(4, maxHeap.Peek());
            Assert.AreEqual(4, maxHeap.Extract());
            Assert.IsTrue(maxHeap.CheckValid());
            CollectionAssert.AreEqual(new List<int> { default }, maxHeap.GetHeap());
        }

        /// <summary>
        ///  Check that a max heap with a two elements works correctly when the second element is larger.
        /// </summary>
        [TestMethod]
        public void MaxHeapTestTwoElementsAddLarger()
        {
            // Create and add a single element.
            var maxHeap = new MaxHeap();
            maxHeap.Insert(4);
            Assert.IsTrue(maxHeap.CheckValid());
            Assert.AreEqual(4, maxHeap.Peek());

            // Add a larger element & check state.
            maxHeap.Insert(7);
            Assert.IsTrue(maxHeap.CheckValid());
            Assert.AreEqual(7, maxHeap.Peek());
            CollectionAssert.AreEqual(new List<int> { default, 7, 4 }, maxHeap.GetHeap());

            // Extract the max and check state.
            Assert.AreEqual(7, maxHeap.Extract());
            Assert.IsTrue(maxHeap.CheckValid());
            CollectionAssert.AreEqual(new List<int> { default, 4 }, maxHeap.GetHeap());

            // Extract the max and check state.
            Assert.AreEqual(4, maxHeap.Extract());
            Assert.IsTrue(maxHeap.CheckValid());
            CollectionAssert.AreEqual(new List<int> { default }, maxHeap.GetHeap());
        }

        /// <summary>
        ///  Check that a max heap with a two elements works correctly when the second element is larger.
        /// </summary>
        [TestMethod]
        public void MaxHeapTestTwoElementsAddSmaller()
        {
            // Create and add a single element.
            var maxHeap = new MaxHeap();
            maxHeap.Insert(4);
            Assert.IsTrue(maxHeap.CheckValid());
            Assert.AreEqual(4, maxHeap.Peek());

            // Add a smaller element & check state.
            maxHeap.Insert(2);
            Assert.IsTrue(maxHeap.CheckValid());
            Assert.AreEqual(4, maxHeap.Peek());
            CollectionAssert.AreEqual(new List<int> { default, 4, 2 }, maxHeap.GetHeap());

            // Extract the max and check state.
            Assert.AreEqual(4, maxHeap.Extract());
            Assert.IsTrue(maxHeap.CheckValid());
            CollectionAssert.AreEqual(new List<int> { default, 2 }, maxHeap.GetHeap());

            // Extract the max and check state.
            Assert.AreEqual(2, maxHeap.Extract());
            Assert.IsTrue(maxHeap.CheckValid());
            CollectionAssert.AreEqual(new List<int> { default }, maxHeap.GetHeap());
        }

        /// <summary>
        ///  Check that a max heap with a three elements works correctly when a larger followed by a smaller is inserted.
        /// </summary>
        [TestMethod]
        public void MaxHeapTestThreeElementsAddLargerThenSmaller()
        {
            // Create and add a single element.
            var maxHeap = new MaxHeap();
            maxHeap.Insert(4);
            Assert.IsTrue(maxHeap.CheckValid());
            Assert.AreEqual(4, maxHeap.Peek());

            // Add a larger element & check state.
            maxHeap.Insert(7);
            Assert.IsTrue(maxHeap.CheckValid());
            Assert.AreEqual(7, maxHeap.Peek());
            CollectionAssert.AreEqual(new List<int> { default, 7, 4 }, maxHeap.GetHeap());

            // Add a smaller element & check state.
            maxHeap.Insert(2);
            Assert.IsTrue(maxHeap.CheckValid());
            Assert.AreEqual(7, maxHeap.Peek());
            CollectionAssert.AreEqual(new List<int> { default, 7, 4, 2 }, maxHeap.GetHeap());

            // Extract the max and check state.
            Assert.AreEqual(7, maxHeap.Extract());
            Assert.IsTrue(maxHeap.CheckValid());
            CollectionAssert.AreEqual(new List<int> { default, 4, 2 }, maxHeap.GetHeap());

            // Note: Remaining extracts are redundant with other tests.
        }

        /// <summary>
        ///  Check that a max heap with a three elements works correctly when a smaller followed by a larger is inserted.
        /// </summary>
        [TestMethod]
        public void MaxHeapTestThreeElementsAddSmallerThenLarger()
        {
            // Create and add a single element.
            var maxHeap = new MaxHeap();
            maxHeap.Insert(4);
            Assert.IsTrue(maxHeap.CheckValid());
            Assert.AreEqual(4, maxHeap.Peek());

            // Add a smaller element & check state.
            maxHeap.Insert(2);
            Assert.IsTrue(maxHeap.CheckValid());
            Assert.AreEqual(4, maxHeap.Peek());
            CollectionAssert.AreEqual(new List<int> { default, 4, 2 }, maxHeap.GetHeap());

            // Add a larger element & check state.
            maxHeap.Insert(7);
            Assert.IsTrue(maxHeap.CheckValid());
            Assert.AreEqual(7, maxHeap.Peek());
            CollectionAssert.AreEqual(new List<int> { default, 7, 2, 4 }, maxHeap.GetHeap());

            // Extract the max and check state.
            Assert.AreEqual(7, maxHeap.Extract());
            Assert.IsTrue(maxHeap.CheckValid());
            CollectionAssert.AreEqual(new List<int> { default, 4, 2 }, maxHeap.GetHeap());

            // Note: Remaining extracts are redundant with other tests.
        }

        /// <summary>
        ///  Check that a max-heap with four elements works correctly.
        /// </summary>
        [TestMethod]
        public void MaxHeapTestFourElements()
        {
            // Create and add.
            var maxHeap = new MaxHeap();
            maxHeap.Insert(4);
            Assert.IsTrue(maxHeap.CheckValid());
            Assert.AreEqual(4, maxHeap.Peek());
            CollectionAssert.AreEqual(new List<int> { default, 4 }, maxHeap.GetHeap());

            // Add Larger.
            maxHeap.Insert(5);
            Assert.IsTrue(maxHeap.CheckValid());
            Assert.AreEqual(5, maxHeap.Peek());
            CollectionAssert.AreEqual(new List<int> { default, 5, 4 }, maxHeap.GetHeap());

            maxHeap.Insert(3);
            Assert.IsTrue(maxHeap.CheckValid());
            Assert.AreEqual(5, maxHeap.Peek());
            CollectionAssert.AreEqual(new List<int> { default, 5, 4, 3 }, maxHeap.GetHeap());

            maxHeap.Insert(2);
            Assert.IsTrue(maxHeap.CheckValid());
            Assert.AreEqual(5, maxHeap.Peek());
            CollectionAssert.AreEqual(new List<int> { default, 5, 4, 3, 2 }, maxHeap.GetHeap());

            // Extract.
            Assert.AreEqual(5, maxHeap.Extract());
            Assert.IsTrue(maxHeap.CheckValid());
            CollectionAssert.AreEqual(new List<int> { default, 4, 2, 3 }, maxHeap.GetHeap());

            // Extract.
            Assert.AreEqual(4, maxHeap.Extract());
            Assert.IsTrue(maxHeap.CheckValid());
            CollectionAssert.AreEqual(new List<int> { default, 3, 2 }, maxHeap.GetHeap());

            // Extract.
            Assert.AreEqual(3, maxHeap.Extract());
            Assert.IsTrue(maxHeap.CheckValid());
            CollectionAssert.AreEqual(new List<int> { default, 2 }, maxHeap.GetHeap());

            // Extract.
            Assert.AreEqual(2, maxHeap.Extract());
            Assert.IsTrue(maxHeap.CheckValid());
            CollectionAssert.AreEqual(new List<int> { default }, maxHeap.GetHeap());
        }

        /// <summary>
        ///  Error Tests (Extract)
        /// </summary>
        [TestMethod]
        public void MaxHeapTestErrorExtractWithNoElements()
        {
            // Create and add a single element.
            var maxHeap = new MaxHeap();
            try
            {
                maxHeap.Extract();
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {
                Assert.IsTrue(true);
            }
        }

        /// <summary>
        ///  Error Tests (Peek)
        /// </summary>
        [TestMethod]
        public void MaxHeapTestErrorPeekWithNoElements()
        {
            // Create and add a single element.
            var maxHeap = new MaxHeap();
            try
            {
                maxHeap.Peek();
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {
                Assert.IsTrue(true);
            }
        }
    }
}
