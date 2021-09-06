using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodingProblems.MinHeap
{
    /// <summary>
    ///  Tests for MinHeapComplete.
    /// </summary>
    [TestClass]
    public class MinHeapCompleteTests
    {
        /// <summary>
        ///  Check that a min heap with a single element works correctly.
        /// </summary>
        [TestMethod]
        public void MinHeapCompleteTestOneElement()
        {
            // Create and add a single element.
            var minHeap = new MinHeapComplete();
            minHeap.Insert(4);
            Assert.IsTrue(minHeap.CheckValid());
            CollectionAssert.AreEqual(new List<int> { default, 4 }, minHeap.GetHeap());

            // Extract and check the extraction.
            Assert.AreEqual(4, minHeap.Peek());
            Assert.AreEqual(4, minHeap.Extract());
            Assert.IsTrue(minHeap.CheckValid());
            CollectionAssert.AreEqual(new List<int> { default }, minHeap.GetHeap());
        }

        /// <summary>
        ///  Check that a min heap with a two elements works correctly when the second element is larger.
        /// </summary>
        [TestMethod]
        public void MinHeapCompleteTestTwoElementsAddLarger()
        {
            // Create and add a single element.
            var minHeap = new MinHeapComplete();
            minHeap.Insert(4);
            Assert.IsTrue(minHeap.CheckValid());
            Assert.AreEqual(4, minHeap.Peek());

            // Add a larger element & check state.
            minHeap.Insert(7);
            Assert.IsTrue(minHeap.CheckValid());
            Assert.AreEqual(4, minHeap.Peek());
            CollectionAssert.AreEqual(new List<int> { default, 4, 7 }, minHeap.GetHeap());

            // Extract the min and check state.
            Assert.AreEqual(4, minHeap.Extract());
            Assert.IsTrue(minHeap.CheckValid());
            CollectionAssert.AreEqual(new List<int> { default, 7 }, minHeap.GetHeap());

            // Extract the min and check state.
            Assert.AreEqual(7, minHeap.Extract());
            Assert.IsTrue(minHeap.CheckValid());
            CollectionAssert.AreEqual(new List<int> { default }, minHeap.GetHeap());
        }

        /// <summary>
        ///  Check that a min heap with a two elements works correctly when the second element is larger.
        /// </summary>
        [TestMethod]
        public void MinHeapCompleteTestTwoElementsAddSmaller()
        {
            // Create and add a single element.
            var minHeap = new MinHeapComplete();
            minHeap.Insert(4);
            Assert.IsTrue(minHeap.CheckValid());
            Assert.AreEqual(4, minHeap.Peek());

            // Add a larger element & check state.
            minHeap.Insert(2);
            Assert.IsTrue(minHeap.CheckValid());
            Assert.AreEqual(2, minHeap.Peek());
            CollectionAssert.AreEqual(new List<int> { default, 2, 4 }, minHeap.GetHeap());

            // Extract the min and check state.
            Assert.AreEqual(2, minHeap.Extract());
            Assert.IsTrue(minHeap.CheckValid());
            CollectionAssert.AreEqual(new List<int> { default, 4 }, minHeap.GetHeap());

            // Extract the min and check state.
            Assert.AreEqual(4, minHeap.Extract());
            Assert.IsTrue(minHeap.CheckValid());
            CollectionAssert.AreEqual(new List<int> { default }, minHeap.GetHeap());
        }

        /// <summary>
        ///  Check that a min heap with a three elements works correctly when a larger followed by a smaller is inserted.
        /// </summary>
        [TestMethod]
        public void MinHeapCompleteTestThreeElementsAddLargerThenSmaller()
        {
            // Create and add a single element.
            var minHeap = new MinHeapComplete();
            minHeap.Insert(4);
            Assert.IsTrue(minHeap.CheckValid());
            Assert.AreEqual(4, minHeap.Peek());

            // Add a larger element & check state.
            minHeap.Insert(7);
            Assert.IsTrue(minHeap.CheckValid());
            Assert.AreEqual(4, minHeap.Peek());
            CollectionAssert.AreEqual(new List<int> { default, 4, 7 }, minHeap.GetHeap());

            // Add a smaller element & check state.
            minHeap.Insert(2);
            Assert.IsTrue(minHeap.CheckValid());
            Assert.AreEqual(2, minHeap.Peek());
            CollectionAssert.AreEqual(new List<int> { default, 2, 7, 4 }, minHeap.GetHeap());

            // Extract the min and check state.
            Assert.AreEqual(2, minHeap.Extract());
            Assert.IsTrue(minHeap.CheckValid());
            CollectionAssert.AreEqual(new List<int> { default, 4, 7 }, minHeap.GetHeap());

            // Note: Remaining extracts are redundant with other tests.
        }

        /// <summary>
        ///  Check that a min heap with a three elements works correctly when a smaller followed by a larger is inserted.
        /// </summary>
        [TestMethod]
        public void MinHeapCompleteTestThreeElementsAddSmallerThenLarger()
        {
            // Create and add a single element.
            var minHeap = new MinHeapComplete();
            minHeap.Insert(4);
            Assert.IsTrue(minHeap.CheckValid());
            Assert.AreEqual(4, minHeap.Peek());

            // Add a smaller element & check state.
            minHeap.Insert(2);
            Assert.IsTrue(minHeap.CheckValid());
            Assert.AreEqual(2, minHeap.Peek());
            CollectionAssert.AreEqual(new List<int> { default, 2, 4 }, minHeap.GetHeap());

            // Add a larger element & check state.
            minHeap.Insert(7);
            Assert.IsTrue(minHeap.CheckValid());
            Assert.AreEqual(2, minHeap.Peek());
            CollectionAssert.AreEqual(new List<int> { default, 2, 4, 7 }, minHeap.GetHeap());

            // Extract the min and check state.
            Assert.AreEqual(2, minHeap.Extract());
            Assert.IsTrue(minHeap.CheckValid());
            CollectionAssert.AreEqual(new List<int> { default, 4, 7 }, minHeap.GetHeap());

            // Note: Remaining extracts are redundant with other tests.
        }

        /// <summary>
        ///  Check that a min heap with three elements works correctly.
        /// </summary>
        [TestMethod]
        public void MinHeapCompleteTestFourElements()
        {
            // Create and add.
            var minHeap = new MinHeapComplete();
            minHeap.Insert(4);
            Assert.IsTrue(minHeap.CheckValid());
            Assert.AreEqual(4, minHeap.Peek());
            CollectionAssert.AreEqual(new List<int> { default, 4 }, minHeap.GetHeap());

            // Add Larger.
            minHeap.Insert(5);
            Assert.IsTrue(minHeap.CheckValid());
            Assert.AreEqual(4, minHeap.Peek());
            CollectionAssert.AreEqual(new List<int> { default, 4, 5 }, minHeap.GetHeap());

            minHeap.Insert(3);
            Assert.IsTrue(minHeap.CheckValid());
            Assert.AreEqual(3, minHeap.Peek());
            CollectionAssert.AreEqual(new List<int> { default, 3, 5, 4 }, minHeap.GetHeap());

            minHeap.Insert(2);
            Assert.IsTrue(minHeap.CheckValid());
            Assert.AreEqual(2, minHeap.Peek());
            CollectionAssert.AreEqual(new List<int> { default, 2, 3, 4, 5 }, minHeap.GetHeap());

            // Extract.
            Assert.AreEqual(2, minHeap.Extract());
            Assert.IsTrue(minHeap.CheckValid());
            CollectionAssert.AreEqual(new List<int> { default, 3, 5, 4 }, minHeap.GetHeap());

            // Extract.
            Assert.AreEqual(3, minHeap.Extract());
            Assert.IsTrue(minHeap.CheckValid());
            CollectionAssert.AreEqual(new List<int> { default, 4, 5 }, minHeap.GetHeap());

            // Extract.
            Assert.AreEqual(4, minHeap.Extract());
            Assert.IsTrue(minHeap.CheckValid());
            CollectionAssert.AreEqual(new List<int> { default, 5 }, minHeap.GetHeap());

            // Extract.
            Assert.AreEqual(5, minHeap.Extract());
            Assert.IsTrue(minHeap.CheckValid());
            CollectionAssert.AreEqual(new List<int> { default }, minHeap.GetHeap());
        }

        /// <summary>
        ///  Error Test (Extract).
        /// </summary>
        [TestMethod]
        public void MinHeapCompleteTestErrorExtractWithNoElements()
        {
            // Create and add a single element.
            var minHeap = new MinHeapComplete();
            try
            {
                minHeap.Extract();
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {
                Assert.IsTrue(true);
            }
        }

        /// <summary>
        ///  Error Test (Peek).
        /// </summary>
        [TestMethod]
        public void MinHeapCompleteTestErrorPeekWithNoElements()
        {
            // Create and add a single element.
            var minHeap = new MinHeapComplete();
            try
            {
                minHeap.Peek();
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {
                Assert.IsTrue(true);
            }
        }
    }
}
