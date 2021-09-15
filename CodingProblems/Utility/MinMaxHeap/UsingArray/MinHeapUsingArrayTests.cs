using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodingProblems.Utility.MinMaxHeap.UsingArray
{
    /// <summary>
    ///  Tests for MinHeap.
    /// </summary>
    [TestClass]
    public class MinHeapUsingArrayTests
    {
        /// <summary>
        ///  Check that a min heap with a single element works correctly.
        /// </summary>
        [TestMethod]
        public void MinHeapTestNoElement()
        {
            // Create and add a single element.
            var minHeap = new MinHeap();
            Assert.AreEqual(0, minHeap.Count());
            Assert.IsTrue(minHeap.CheckValid());
            CollectionAssert.AreEqual(new List<int> { default }, minHeap.GetHeap());
        }

        /// <summary>
        ///  Check that a min heap with a single element works correctly.
        /// </summary>
        [TestMethod]
        public void MinHeapTestOneElement()
        {
            // Create and add a single element.
            var minHeap = new MinHeap();
            minHeap.Insert(4);
            Assert.AreEqual(1, minHeap.Count());
            Assert.IsTrue(minHeap.CheckValid());
            CollectionAssert.AreEqual(new List<int> { default, 4 }, minHeap.GetHeap());

            // Extract and check the extraction.
            Assert.AreEqual(4, minHeap.Peek());
            Assert.AreEqual(4, minHeap.Extract());
            Assert.AreEqual(0, minHeap.Count());
            Assert.IsTrue(minHeap.CheckValid());
            CollectionAssert.AreEqual(new List<int> { default }, minHeap.GetHeap());
        }

        /// <summary>
        ///  Check that a min heap with a two elements works correctly when the second element is larger.
        /// </summary>
        [TestMethod]
        public void MinHeapTestTwoElementsAddLarger()
        {
            // Create and add a single element.
            var minHeap = new MinHeap();
            minHeap.Insert(4);
            Assert.AreEqual(1, minHeap.Count());
            Assert.IsTrue(minHeap.CheckValid());
            Assert.AreEqual(4, minHeap.Peek());

            // Add a larger element & check state.
            minHeap.Insert(7);
            Assert.IsTrue(minHeap.CheckValid());
            Assert.AreEqual(2, minHeap.Count());
            Assert.AreEqual(4, minHeap.Peek());
            CollectionAssert.AreEqual(new List<int> { default, 4, 7 }, minHeap.GetHeap());

            // Extract the min and check state.
            Assert.AreEqual(4, minHeap.Extract());
            Assert.AreEqual(1, minHeap.Count());
            Assert.IsTrue(minHeap.CheckValid());
            CollectionAssert.AreEqual(new List<int> { default, 7 }, minHeap.GetHeap());

            // Extract the min and check state.
            Assert.AreEqual(7, minHeap.Extract());
            Assert.AreEqual(0, minHeap.Count());
            Assert.IsTrue(minHeap.CheckValid());
            CollectionAssert.AreEqual(new List<int> { default }, minHeap.GetHeap());
        }

        /// <summary>
        ///  Check that a min heap with a two elements works correctly when the second element is larger.
        /// </summary>
        [TestMethod]
        public void MinHeapTestTwoElementsAddSmaller()
        {
            // Create and add a single element.
            var minHeap = new MinHeap();
            minHeap.Insert(4);
            Assert.AreEqual(1, minHeap.Count());
            Assert.IsTrue(minHeap.CheckValid());
            Assert.AreEqual(4, minHeap.Peek());

            // Add a larger element & check state.
            minHeap.Insert(2);
            Assert.AreEqual(2, minHeap.Count());
            Assert.IsTrue(minHeap.CheckValid());
            Assert.AreEqual(2, minHeap.Peek());
            CollectionAssert.AreEqual(new List<int> { default, 2, 4 }, minHeap.GetHeap());

            // Extract the min and check state.
            Assert.AreEqual(2, minHeap.Extract());
            Assert.AreEqual(1, minHeap.Count());
            Assert.IsTrue(minHeap.CheckValid());
            CollectionAssert.AreEqual(new List<int> { default, 4 }, minHeap.GetHeap());

            // Extract the min and check state.
            Assert.AreEqual(4, minHeap.Extract());
            Assert.AreEqual(0, minHeap.Count());
            Assert.IsTrue(minHeap.CheckValid());
            CollectionAssert.AreEqual(new List<int> { default }, minHeap.GetHeap());
        }

        /// <summary>
        ///  Check that a min heap with a three elements works correctly when a larger followed by a smaller is inserted.
        /// </summary>
        [TestMethod]
        public void MinHeapTestThreeElementsAddLargerThenSmaller()
        {
            // Create and add a single element.
            var minHeap = new MinHeap();
            minHeap.Insert(4);
            Assert.AreEqual(1, minHeap.Count());
            Assert.IsTrue(minHeap.CheckValid());
            Assert.AreEqual(4, minHeap.Peek());

            // Add a larger element & check state.
            minHeap.Insert(7);
            Assert.IsTrue(minHeap.CheckValid());
            Assert.AreEqual(2, minHeap.Count());
            Assert.AreEqual(4, minHeap.Peek());
            CollectionAssert.AreEqual(new List<int> { default, 4, 7 }, minHeap.GetHeap());

            // Add a smaller element & check state.
            minHeap.Insert(2);
            Assert.AreEqual(3, minHeap.Count());
            Assert.IsTrue(minHeap.CheckValid());
            Assert.AreEqual(2, minHeap.Peek());
            CollectionAssert.AreEqual(new List<int> { default, 2, 7, 4 }, minHeap.GetHeap());

            // Extract the min and check state.
            Assert.AreEqual(2, minHeap.Extract());
            Assert.AreEqual(2, minHeap.Count());
            Assert.IsTrue(minHeap.CheckValid());
            CollectionAssert.AreEqual(new List<int> { default, 4, 7 }, minHeap.GetHeap());

            // Note: Remaining extracts are redundant with other tests.
        }

        /// <summary>
        ///  Check that a min heap with a three elements works correctly when a smaller followed by a larger is inserted.
        /// </summary>
        [TestMethod]
        public void MinHeapTestThreeElementsAddSmallerThenLarger()
        {
            // Create and add a single element.
            var minHeap = new MinHeap();
            minHeap.Insert(4);
            Assert.AreEqual(1, minHeap.Count());
            Assert.IsTrue(minHeap.CheckValid());
            Assert.AreEqual(4, minHeap.Peek());

            // Add a smaller element & check state.
            minHeap.Insert(2);
            Assert.AreEqual(2, minHeap.Count());
            Assert.IsTrue(minHeap.CheckValid());
            Assert.AreEqual(2, minHeap.Peek());
            CollectionAssert.AreEqual(new List<int> { default, 2, 4 }, minHeap.GetHeap());

            // Add a larger element & check state.
            minHeap.Insert(7);
            Assert.AreEqual(3, minHeap.Count());
            Assert.IsTrue(minHeap.CheckValid());
            Assert.AreEqual(2, minHeap.Peek());
            CollectionAssert.AreEqual(new List<int> { default, 2, 4, 7 }, minHeap.GetHeap());

            // Extract the min and check state.
            Assert.AreEqual(2, minHeap.Extract());
            Assert.AreEqual(2, minHeap.Count());
            Assert.IsTrue(minHeap.CheckValid());
            CollectionAssert.AreEqual(new List<int> { default, 4, 7 }, minHeap.GetHeap());

            // Note: Remaining extracts are redundant with other tests.
        }

        /// <summary>
        ///  Check that a min-heap with three elements works correctly.
        /// </summary>
        [TestMethod]
        public void MinHeapTestFourElements()
        {
            // Create and add.
            var minHeap = new MinHeap();
            minHeap.Insert(4);
            Assert.AreEqual(1, minHeap.Count());
            Assert.IsTrue(minHeap.CheckValid());
            Assert.AreEqual(4, minHeap.Peek());
            CollectionAssert.AreEqual(new List<int> { default, 4 }, minHeap.GetHeap());

            // Add Larger.
            minHeap.Insert(5);
            Assert.AreEqual(2, minHeap.Count());
            Assert.IsTrue(minHeap.CheckValid());
            Assert.AreEqual(4, minHeap.Peek());
            CollectionAssert.AreEqual(new List<int> { default, 4, 5 }, minHeap.GetHeap());

            minHeap.Insert(3);
            Assert.AreEqual(3, minHeap.Count());
            Assert.IsTrue(minHeap.CheckValid());
            Assert.AreEqual(3, minHeap.Peek());
            CollectionAssert.AreEqual(new List<int> { default, 3, 5, 4 }, minHeap.GetHeap());

            minHeap.Insert(2);
            Assert.AreEqual(4, minHeap.Count());
            Assert.IsTrue(minHeap.CheckValid());
            Assert.AreEqual(2, minHeap.Peek());
            CollectionAssert.AreEqual(new List<int> { default, 2, 3, 4, 5 }, minHeap.GetHeap());

            // Extract.
            Assert.AreEqual(2, minHeap.Extract());
            Assert.AreEqual(3, minHeap.Count());
            Assert.IsTrue(minHeap.CheckValid());
            CollectionAssert.AreEqual(new List<int> { default, 3, 5, 4 }, minHeap.GetHeap());

            // Extract.
            Assert.AreEqual(3, minHeap.Extract());
            Assert.AreEqual(2, minHeap.Count());
            Assert.IsTrue(minHeap.CheckValid());
            CollectionAssert.AreEqual(new List<int> { default, 4, 5 }, minHeap.GetHeap());

            // Extract.
            Assert.AreEqual(4, minHeap.Extract());
            Assert.AreEqual(1, minHeap.Count());
            Assert.IsTrue(minHeap.CheckValid());
            CollectionAssert.AreEqual(new List<int> { default, 5 }, minHeap.GetHeap());

            // Extract.
            Assert.AreEqual(5, minHeap.Extract());
            Assert.AreEqual(0, minHeap.Count());
            Assert.IsTrue(minHeap.CheckValid());
            CollectionAssert.AreEqual(new List<int> { default }, minHeap.GetHeap());
        }

        /// <summary>
        ///  Tests that extract works correctly when a larger left child is found
        /// during the heapify operation. (Smaller child should move up).
        /// </summary>
        [TestMethod]
        public void MinHeapTestValidAfterExtractLeftChildLarger()
        {
            // Create and add elements so that the larger child is on the right.
            // Note that we need to add enough elements so that there are still
            // two children after the extract.
            var minHeap = new MinHeap();
            minHeap.Insert(2);
            minHeap.Insert(4);
            minHeap.Insert(3);
            minHeap.Insert(5);
            Assert.IsTrue(minHeap.CheckValid());

            minHeap.Extract();
            Assert.IsTrue(minHeap.CheckValid());
        }

        /// <summary>
        ///  Tests that extract works correctly when a larger left child is found
        /// during the heapify operation. (Smaller child should move up).
        /// </summary>
        [TestMethod]
        public void MinHeapTestValidAfterExtractRightChildLarger()
        {
            // Create and add elements so that the larger child is on the left.
            // Note that we need to add enough elements so that there are still
            // two children after the extract.
            var minHeap = new MinHeap();
            minHeap.Insert(2);
            minHeap.Insert(3);
            minHeap.Insert(4);
            minHeap.Insert(5);
            Assert.IsTrue(minHeap.CheckValid());

            minHeap.Extract();
            Assert.IsTrue(minHeap.CheckValid());
        }

        /// <summary>
        ///  Error Test (Extract).
        /// </summary>
        [TestMethod]
        public void MinHeapTestErrorExtractWithNoElements()
        {
            // Create and add a single element.
            var minHeap = new MinHeap();
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
        public void MinHeapTestErrorPeekWithNoElements()
        {
            // Create and add a single element.
            var minHeap = new MinHeap();
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
