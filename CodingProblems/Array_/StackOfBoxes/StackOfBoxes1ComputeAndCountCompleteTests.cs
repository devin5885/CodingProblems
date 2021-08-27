using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodingProblems.Array_.StackOfBoxes
{
    /// <summary>
    /// Tests StackOfBoxes1Complete.GetMaxHeight
    /// </summary>
    [TestClass]
    public class StackOfBoxes1ComputeAndCountCompleteTests
    {
        /// <summary>
        /// Test an array with no boxes.
        /// </summary>
        [TestMethod]
        public void StackOfBoxes1CompleteTest1NoBoxes()
        {
            var stack = new List<Box>();
            Assert.AreEqual(0, StackOfBoxes1ComputeAndCountComplete.GetMaxHeight(stack));
        }

        /// <summary>
        /// Test an array with a single boxes.
        /// </summary>
        [TestMethod]
        public void StackOfBoxes1CompleteTest2SingleBox()
        {
            // ReSharper disable once UseObjectOrCollectionInitializer
            var stack = new List<Box> { new Box(2, 2, 2) };
            Assert.AreEqual(2, StackOfBoxes1ComputeAndCountComplete.GetMaxHeight(stack));
        }

        /// <summary>
        /// Test an array with a two boxes that can be stacked.
        /// </summary>
        [TestMethod]
        public void StackOfBoxes1CompleteTest3TwoBoxesCanStack()
        {
            // ReSharper disable once UseObjectOrCollectionInitializer
            var stack = new List<Box>
            {
                new Box(1, 1, 1),
                new Box(2, 2, 2)
            };
            Assert.AreEqual(3, StackOfBoxes1ComputeAndCountComplete.GetMaxHeight(stack));
        }

        /// <summary>
        /// Test an array with a two boxes that cannot be stacked.
        /// </summary>
        [TestMethod]
        public void StackOfBoxes1CompleteTest4TwoBoxesCantStack()
        {
            // ReSharper disable once UseObjectOrCollectionInitializer
            var stack = new List<Box>
            {
                new Box(1, 3, 3),
                new Box(2, 2, 2)
            };
            Assert.AreEqual(3, StackOfBoxes1ComputeAndCountComplete.GetMaxHeight(stack));
        }

        /// <summary>
        /// Test a null array.
        /// </summary>
        [TestMethod]
        public void StackOfBoxes1CompleteTest5NullList()
        {
            try
            {
                StackOfBoxes1ComputeAndCountComplete.GetMaxHeight(null);
            }
            catch (ArgumentException)
            {
                Assert.IsTrue(true);
                return;
            }
            Assert.Fail();
        }
    }
}