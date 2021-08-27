using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodingProblems.Array_.SearchSortedNoSize
{
    /// <summary>
    /// This class tests Search
    /// </summary>
    [TestClass]
    public class ArraySearchSortedNoSize2BinarySearchCompleteTests
    {
        /// <summary>
        /// Tests the value to find is within the array.
        /// </summary>
        [TestMethod]
        public void ArraySearchSortedNoSize2BinarySearchCompleteTestValueFound1()
        {
            var listNoSize = new ListNoSize(new[] { 3, 5, 7, 7, 8, 23, 38, 56 });
            Assert.AreEqual(4, ArraySearchSortedNoSize2BinarySearchComplete.Search(listNoSize, 8));
        }

        /// <summary>
        /// Tests the value to find is within the array.
        /// </summary>
        [TestMethod]
        public void ArraySearchSortedNoSize2BinarySearchCompleteTestValueFound2()
        {
            var listNoSize = new ListNoSize(new[] { 3, 5, 7, 7, 8, 23, 38, 56 });
            Assert.AreEqual(5, ArraySearchSortedNoSize2BinarySearchComplete.Search(listNoSize, 23));
        }

        /// <summary>
        /// Tests the value to find is not in the array.
        /// </summary>
        [TestMethod]
        public void ArraySearchSortedNoSize2BinarySearchCompleteTestValueNotFound()
        {
            var listNoSize = new ListNoSize(new[] { 3, 5, 7, 7, 8, 23, 38, 56 });
            Assert.AreEqual(-1, ArraySearchSortedNoSize2BinarySearchComplete.Search(listNoSize, 100));
        }

        /// <summary>
        /// Tests an array with one element found.
        /// </summary>
        [TestMethod]
        public void ArraySearchSortedNoSize2BinarySearchCompleteTestOneElementFound()
        {
            var listNoSize = new ListNoSize(new[] { 3 });
            Assert.AreEqual(0, ArraySearchSortedNoSize2BinarySearchComplete.Search(listNoSize, 3));
        }

        /// <summary>
        /// Tests an array with one element not found.
        /// </summary>
        [TestMethod]
        public void ArraySearchSortedNoSize2BinarySearchCompleteTestOneElementNotFound()
        {
            var listNoSize = new ListNoSize(new[] { 3 });
            Assert.AreEqual(-1, ArraySearchSortedNoSize2BinarySearchComplete.Search(listNoSize, 23));
        }

        /// <summary>
        /// Tests an empty list.
        /// </summary>
        [TestMethod]
        public void ArraySearchSortedNoSize2BinarySearchCompleteTestEmptyLists()
        {
            var listNoSize = new ListNoSize(Array.Empty<int>());
            Assert.AreEqual(-1, ArraySearchSortedNoSize2BinarySearchComplete.Search(listNoSize, 23));
        }

        /// <summary>
        /// Tests a null array.
        /// </summary>
        [TestMethod]
        public void ArraySearchSortedNoSize2BinarySearchCompleteTestNullArray()
        {
            try
            {
                ArraySearchSortedNoSize2BinarySearchComplete.Search(null, 23);
            }
            catch (ArgumentException)
            {
                Assert.IsTrue(true);
                return;
            }
            Assert.Fail();
        }

        /// <summary>
        /// Tests a negative index.
        /// </summary>
        [TestMethod]
        public void ArraySearchSortedNoSize2BinarySearchCompleteTestNegativeIndex()
        {
            try
            {
                var noSize = new ListNoSize(new[] { 3, 5, 7, 7, 8, 23, 38, 56 });
                ArraySearchSortedNoSize2BinarySearchComplete.Search(noSize, -2);
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
