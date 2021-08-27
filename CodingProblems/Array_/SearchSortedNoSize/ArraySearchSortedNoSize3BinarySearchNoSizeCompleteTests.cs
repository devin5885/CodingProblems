using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodingProblems.Array_.SearchSortedNoSize
{
    /// <summary>
    /// This class tests Search
    /// </summary>
    [TestClass]
    public class ArraySearchSortedNoSize3BinarySearchNoSizeCompleteTests
    {
        /// <summary>
        /// Tests the value to find is within the array.
        /// </summary>
        [TestMethod]
        public void ArraySearchSortedNoSize3BinarySearchNoSizeCompleteTestValueFound1()
        {
            var listNoSize = new ListNoSize(new[] { 3, 5, 7, 7, 8, 23, 38, 56 });
            Assert.AreEqual(4, ArraySearchSortedNoSize3BinarySearchNoSizeComplete.Search(listNoSize, 8));
        }

        /// <summary>
        /// Tests the value to find is within the array.
        /// </summary>
        [TestMethod]
        public void ArraySearchSortedNoSize3BinarySearchNoSizeCompleteTestValueFound2()
        {
            var listNoSize = new ListNoSize(new[] { 3, 5, 7, 7, 8, 23, 38, 56 });
            Assert.AreEqual(5, ArraySearchSortedNoSize3BinarySearchNoSizeComplete.Search(listNoSize, 23));
        }

        /// <summary>
        /// Tests the value to find is not in the array.
        /// </summary>
        [TestMethod]
        public void ArraySearchSortedNoSize3BinarySearchNoSizeCompleteTestValueNotFound()
        {
            var listNoSize = new ListNoSize(new[] { 3, 5, 7, 7, 8, 23, 38, 56 });
            Assert.AreEqual(-1, ArraySearchSortedNoSize3BinarySearchNoSizeComplete.Search(listNoSize, 100));
        }

        /// <summary>
        /// Tests an array with one element found.
        /// </summary>
        [TestMethod]
        public void ArraySearchSortedNoSize3BinarySearchNoSizeCompleteTestOneElementFound()
        {
            var listNoSize = new ListNoSize(new[] { 3 });
            Assert.AreEqual(0, ArraySearchSortedNoSize3BinarySearchNoSizeComplete.Search(listNoSize, 3));
        }

        /// <summary>
        /// Tests an array with one element not found.
        /// </summary>
        [TestMethod]
        public void ArraySearchSortedNoSize3BinarySearchNoSizeCompleteTestOneElementNotFound()
        {
            var listNoSize = new ListNoSize(new[] { 3 });
            Assert.AreEqual(-1, ArraySearchSortedNoSize3BinarySearchNoSizeComplete.Search(listNoSize, 23));
        }

        /// <summary>
        /// Tests an empty list.
        /// </summary>
        [TestMethod]
        public void ArraySearchSortedNoSize3BinarySearchNoSizeCompleteTestEmptyLists()
        {
            var listNoSize = new ListNoSize(Array.Empty<int>());
            Assert.AreEqual(-1, ArraySearchSortedNoSize3BinarySearchNoSizeComplete.Search(listNoSize, 23));
        }

        /// <summary>
        /// Tests a null array.
        /// </summary>
        [TestMethod]
        public void ArraySearchSortedNoSize3BinarySearchNoSizeCompleteTestNullArray()
        {
            try
            {
                ArraySearchSortedNoSize3BinarySearchNoSizeComplete.Search(null, 23);
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
        public void ArraySearchSortedNoSize3BinarySearchNoSizeCompleteTestNegativeIndex()
        {
            try
            {
                var listNoSize = new ListNoSize(new[] { 3, 5, 7, 7, 8, 23, 38, 56 });
                ArraySearchSortedNoSize3BinarySearchNoSizeComplete.Search(listNoSize, -2);
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
