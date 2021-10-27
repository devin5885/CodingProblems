using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodingProblems.MaxHeap
{
    /// <summary>
    ///  Tests for MaxHeap.
    /// </summary>
    [TestClass]
    public class MaxHeapCompleteTests
    {
        /// <summary>
        ///  Check that a max heap with a single element works correctly.
        /// </summary>
        [TestMethod]
        public void MaxHeapTestOneElement()
        {
            // Create and add a single element.
            var maxHeap = new MaxHeapComplete();
            maxHeap.Insert(4);
            Assert.AreEqual(1, maxHeap.Count());
            Assert.IsTrue(maxHeap.CheckValid());
            CollectionAssert.AreEqual(new List<int> { default, 4 }, maxHeap.GetHeap());

            // Extract and check the extraction.
            Assert.AreEqual(4, maxHeap.Peek());
            Assert.AreEqual(4, maxHeap.Extract());
            Assert.AreEqual(0, maxHeap.Count());
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
            var maxHeap = new MaxHeapComplete();
            maxHeap.Insert(4);
            Assert.AreEqual(1, maxHeap.Count());
            Assert.IsTrue(maxHeap.CheckValid());
            Assert.AreEqual(4, maxHeap.Peek());

            // Add a larger element & check state.
            maxHeap.Insert(7);
            Assert.AreEqual(2, maxHeap.Count());
            Assert.IsTrue(maxHeap.CheckValid());
            Assert.AreEqual(7, maxHeap.Peek());
            CollectionAssert.AreEqual(new List<int> { default, 7, 4 }, maxHeap.GetHeap());

            // Extract the max and check state.
            Assert.AreEqual(7, maxHeap.Extract());
            Assert.AreEqual(1, maxHeap.Count());
            Assert.IsTrue(maxHeap.CheckValid());
            CollectionAssert.AreEqual(new List<int> { default, 4 }, maxHeap.GetHeap());

            // Extract the max and check state.
            Assert.AreEqual(4, maxHeap.Extract());
            Assert.AreEqual(0, maxHeap.Count());
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
            var maxHeap = new MaxHeapComplete();
            maxHeap.Insert(4);
            Assert.AreEqual(1, maxHeap.Count());
            Assert.IsTrue(maxHeap.CheckValid());
            Assert.AreEqual(4, maxHeap.Peek());

            // Add a smaller element & check state.
            maxHeap.Insert(2);
            Assert.AreEqual(2, maxHeap.Count());
            Assert.IsTrue(maxHeap.CheckValid());
            Assert.AreEqual(4, maxHeap.Peek());
            CollectionAssert.AreEqual(new List<int> { default, 4, 2 }, maxHeap.GetHeap());

            // Extract the max and check state.
            Assert.AreEqual(4, maxHeap.Extract());
            Assert.AreEqual(1, maxHeap.Count());
            Assert.IsTrue(maxHeap.CheckValid());
            CollectionAssert.AreEqual(new List<int> { default, 2 }, maxHeap.GetHeap());

            // Extract the max and check state.
            Assert.AreEqual(2, maxHeap.Extract());
            Assert.AreEqual(0, maxHeap.Count());
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
            var maxHeap = new MaxHeapComplete();
            maxHeap.Insert(4);
            Assert.AreEqual(1, maxHeap.Count());
            Assert.IsTrue(maxHeap.CheckValid());
            Assert.AreEqual(4, maxHeap.Peek());

            // Add a larger element & check state.
            maxHeap.Insert(7);
            Assert.AreEqual(2, maxHeap.Count());
            Assert.IsTrue(maxHeap.CheckValid());
            Assert.AreEqual(7, maxHeap.Peek());
            CollectionAssert.AreEqual(new List<int> { default, 7, 4 }, maxHeap.GetHeap());

            // Add a smaller element & check state.
            maxHeap.Insert(2);
            Assert.AreEqual(3, maxHeap.Count());
            Assert.IsTrue(maxHeap.CheckValid());
            Assert.AreEqual(7, maxHeap.Peek());
            CollectionAssert.AreEqual(new List<int> { default, 7, 4, 2 }, maxHeap.GetHeap());

            // Extract the max and check state.
            Assert.AreEqual(7, maxHeap.Extract());
            Assert.AreEqual(2, maxHeap.Count());
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
            var maxHeap = new MaxHeapComplete();
            maxHeap.Insert(4);
            Assert.AreEqual(1, maxHeap.Count());
            Assert.IsTrue(maxHeap.CheckValid());
            Assert.AreEqual(4, maxHeap.Peek());

            // Add a smaller element & check state.
            maxHeap.Insert(2);
            Assert.AreEqual(2, maxHeap.Count());
            Assert.IsTrue(maxHeap.CheckValid());
            Assert.AreEqual(4, maxHeap.Peek());
            CollectionAssert.AreEqual(new List<int> { default, 4, 2 }, maxHeap.GetHeap());

            // Add a larger element & check state.
            maxHeap.Insert(7);
            Assert.AreEqual(3, maxHeap.Count());
            Assert.IsTrue(maxHeap.CheckValid());
            Assert.AreEqual(7, maxHeap.Peek());
            CollectionAssert.AreEqual(new List<int> { default, 7, 2, 4 }, maxHeap.GetHeap());

            // Extract the max and check state.
            Assert.AreEqual(7, maxHeap.Extract());
            Assert.AreEqual(2, maxHeap.Count());
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
            var maxHeap = new MaxHeapComplete();
            maxHeap.Insert(4);
            Assert.AreEqual(1, maxHeap.Count());
            Assert.IsTrue(maxHeap.CheckValid());
            Assert.AreEqual(4, maxHeap.Peek());
            CollectionAssert.AreEqual(new List<int> { default, 4 }, maxHeap.GetHeap());

            // Add Larger.
            maxHeap.Insert(5);
            Assert.AreEqual(2, maxHeap.Count());
            Assert.IsTrue(maxHeap.CheckValid());
            Assert.AreEqual(5, maxHeap.Peek());
            CollectionAssert.AreEqual(new List<int> { default, 5, 4 }, maxHeap.GetHeap());

            maxHeap.Insert(3);
            Assert.AreEqual(3, maxHeap.Count());
            Assert.IsTrue(maxHeap.CheckValid());
            Assert.AreEqual(5, maxHeap.Peek());
            CollectionAssert.AreEqual(new List<int> { default, 5, 4, 3 }, maxHeap.GetHeap());

            maxHeap.Insert(2);
            Assert.AreEqual(4, maxHeap.Count());
            Assert.IsTrue(maxHeap.CheckValid());
            Assert.AreEqual(5, maxHeap.Peek());
            CollectionAssert.AreEqual(new List<int> { default, 5, 4, 3, 2 }, maxHeap.GetHeap());

            // Extract.
            Assert.AreEqual(5, maxHeap.Extract());
            Assert.AreEqual(3, maxHeap.Count());
            Assert.IsTrue(maxHeap.CheckValid());
            CollectionAssert.AreEqual(new List<int> { default, 4, 2, 3 }, maxHeap.GetHeap());

            // Extract.
            Assert.AreEqual(4, maxHeap.Extract());
            Assert.AreEqual(2, maxHeap.Count());
            Assert.IsTrue(maxHeap.CheckValid());
            CollectionAssert.AreEqual(new List<int> { default, 3, 2 }, maxHeap.GetHeap());

            // Extract.
            Assert.AreEqual(3, maxHeap.Extract());
            Assert.AreEqual(1, maxHeap.Count());
            Assert.IsTrue(maxHeap.CheckValid());
            CollectionAssert.AreEqual(new List<int> { default, 2 }, maxHeap.GetHeap());

            // Extract.
            Assert.AreEqual(2, maxHeap.Extract());
            Assert.AreEqual(0, maxHeap.Count());
            Assert.IsTrue(maxHeap.CheckValid());
            CollectionAssert.AreEqual(new List<int> { default }, maxHeap.GetHeap());
        }

        /// <summary>
        ///  Tests that extract works correctly when a larger left child is found
        /// during the heapify operation. (Larger child should move up).
        /// </summary>
        [TestMethod]
        public void MaxHeapTestValidAfterExtractLeftChildLarger()
        {
            // Create and add elements so that the larger child is on the right.
            // Note that we need to add enough elements so that there are still
            // two children after the extract.
            var maxHeap = new MaxHeapComplete();
            maxHeap.Insert(5);
            maxHeap.Insert(4);
            maxHeap.Insert(3);
            maxHeap.Insert(2);
            Assert.AreEqual(4, maxHeap.Count());
            Assert.IsTrue(maxHeap.CheckValid());

            maxHeap.Extract();
            Assert.AreEqual(3, maxHeap.Count());
            Assert.IsTrue(maxHeap.CheckValid());
        }

        /// <summary>
        ///  Tests that extract works correctly when a larger left child is found
        /// during the heapify operation. (Larger child should move up).
        /// </summary>
        [TestMethod]
        public void MaxHeapTestValidAfterExtractRightChildLarger()
        {
            // Create and add elements so that the larger child is on the left.
            // Note that we need to add enough elements so that there are still
            // two children after the extract.
            var maxHeap = new MaxHeapComplete();
            maxHeap.Insert(5);
            maxHeap.Insert(3);
            maxHeap.Insert(4);
            maxHeap.Insert(2);
            Assert.AreEqual(4, maxHeap.Count());
            Assert.IsTrue(maxHeap.CheckValid());

            maxHeap.Extract();
            Assert.AreEqual(3, maxHeap.Count());
            Assert.IsTrue(maxHeap.CheckValid());
        }

        /// <summary>
        ///  Error Tests (Extract)
        /// </summary>
        [TestMethod]
        public void MaxHeapTestErrorExtractWithNoElements()
        {
            // Create and add a single element.
            var maxHeap = new MaxHeapComplete();
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
            var maxHeap = new MaxHeapComplete();
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
