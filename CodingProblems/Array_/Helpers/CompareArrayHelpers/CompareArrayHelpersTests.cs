using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodingProblems.Array_.Helpers.CompareArrayHelpers
{
    /// <summary>
    ///  Tests for CompareArrayHelpers
    /// </summary>
    [TestClass]
    public class CompareArrayHelpersTests
    {
        // CompareArrays Simple Array.

        /// <summary>
        /// Array matching same order.
        /// </summary>
        [TestMethod]
        public void CompareArrayHelpersTestArrayMatchSameOrder_ShouldReturnTrue()
        {
            var array1 = new List<int> { 1, 2, 3 };
            var array2 = new List<int> { 1, 2, 3 };
            Assert.IsTrue(CompareArrayHelpers.CompareArrays(array1, array2));
        }

        /// <summary>
        /// Array matching different order.
        /// </summary>
        [TestMethod]
        public void CompareArrayHelpersTestArrayMatchDifferentOrder_ShouldReturnTrue()
        {
            var array1 = new List<int> { 1, 2, 3 };
            var array2 = new List<int> { 3, 2, 1 };
            Assert.IsTrue(CompareArrayHelpers.CompareArrays(array1, array2));
        }

        /// <summary>
        /// Array no match.
        /// </summary>
        [TestMethod]
        public void CompareArrayHelpersTestCompareArraysNonMatch_ShouldReturnFalse()
        {
            var array1 = new List<int> { 1, 2, 3 };
            var array2 = new List<int> { 1, 2, 4 };
            Assert.IsFalse(CompareArrayHelpers.CompareArrays(array1, array2));
        }

        /// <summary>
        /// Array no match, different # of elements (1).
        /// </summary>
        [TestMethod]
        public void CompareArrayHelpersTestCompareArraysNonMatchNumberOfElements1_ShouldReturnFalse()
        {
            var array1 = new List<int> { 1, 2 };
            var array2 = new List<int> { 1, 2, 4 };
            Assert.IsFalse(CompareArrayHelpers.CompareArrays(array1, array2));
        }

        /// <summary>
        /// Array no match, different # of elements (2).
        /// </summary>
        [TestMethod]
        public void CompareArrayHelpersTestCompareArraysNonMatchNumberOfElements2_ShouldReturnFalse()
        {
            var array1 = new List<int> { 1, 2, 4 };
            var array2 = new List<int> { 1, 2 };
            Assert.IsFalse(CompareArrayHelpers.CompareArrays(array1, array2));
        }

        // ContainsArray.

        /// <summary>
        /// ContainsArray, Array found.
        /// </summary>
        [TestMethod]
        public void CompareArrayHelpersTestContainsArrayFound_ShouldReturnTrue()
        {
            var arrayToFind = new List<int> { 3, 4 };
            var arrayOfArraysToSearch = new List<List<int>>
            {
                new List<int> { 1, 2, 8, 20 },
                new List<int> { 3, 4 },
                new List<int> { 5, 6, 7 }
            };
            Assert.IsTrue(CompareArrayHelpers.ContainsArray(arrayToFind, arrayOfArraysToSearch));
        }

        /// <summary>
        /// ContainsArray, Array not found.
        /// </summary>
        [TestMethod]
        public void CompareArrayHelpersTestContainsArrayNotFound_ShouldReturnFalse()
        {
            var arrayToFind = new List<int> { 1, 2 };
            var arrayOfArraysToSearch = new List<List<int>>
            {
                new List<int> { 1, 2, 8, 20 },
                new List<int> { 3, 4 },
                new List<int> { 5, 6, 7 }
            };
            Assert.IsFalse(CompareArrayHelpers.ContainsArray(arrayToFind, arrayOfArraysToSearch));
        }

        /// <summary>
        /// Array of arrays matching test - Single element.
        /// </summary>
        [TestMethod]
        public void CompareArrayHelpersTestArrayOfArraysMatchSingleElement_ShouldReturnTrue()
        {
            var array1 = new List<List<int>>
            {
                new List<int> { 1 }
            };
            var array2 = new List<List<int>>
            {
                new List<int> { 1 }
            };
            Assert.IsTrue(CompareArrayHelpers.CompareArrays(array1, array2));
        }

        /// <summary>
        /// Array of arrays no-match test - Single element.
        /// </summary>
        [TestMethod]
        public void CompareArrayHelpersTestArrayOfArraysNoMatchSingleElement_ShouldReturnFalse()
        {
            var array1 = new List<List<int>>
            {
                new List<int> { 1 }
            };
            var array2 = new List<List<int>>
            {
                new List<int> { 2 }
            };
            Assert.IsFalse(CompareArrayHelpers.CompareArrays(array1, array2));
        }

        /// <summary>
        /// Array of arrays matching test - Multiple elements.
        /// </summary>
        [TestMethod]
        public void CompareArrayHelpersTestArrayOfArraysMatchMultipleElements_ShouldReturnTrue()
        {
            var array1 = new List<List<int>>
            {
                new List<int> { 1, 2, 3 }
            };
            var array2 = new List<List<int>>
            {
                new List<int> { 1, 2, 3 }
            };
            Assert.IsTrue(CompareArrayHelpers.CompareArrays(array1, array2));
        }

        /// <summary>
        /// Array of arrays matching test - Multiple elements, multiple arrays.
        /// </summary>
        [TestMethod]
        public void CompareArrayHelpersTestArrayOfArraysMatchMultipleElementsMultipleArrays_ShouldReturnTrue()
        {
            var array1 = new List<List<int>>
            {
                new List<int> { 1, 2, 8, 20 },
                new List<int> { 3, 4 },
                new List<int> { 5, 6, 7 }
            };
            var array2 = new List<List<int>>
            {
                new List<int> { 1, 2, 8, 20 },
                new List<int> { 3, 4 },
                new List<int> { 5, 6, 7 }
            };
            Assert.IsTrue(CompareArrayHelpers.CompareArrays(array1, array2));
        }

        /// <summary>
        /// Array of arrays no-match test - Single element.
        /// </summary>
        [TestMethod]
        public void CompareArrayHelpersTestArrayOfArraysNoMatchMultipleElements_ShouldReturnFalse()
        {
            var array1 = new List<List<int>>
            {
                new List<int> { 1, 2, 4 }
            };
            var array2 = new List<List<int>>
            {
                new List<int> { 1, 2, 3 }
            };
            Assert.IsFalse(CompareArrayHelpers.CompareArrays(array1, array2));
        }

        /// <summary>
        /// Array of arrays no match - Multiple elements, multiple arrays.
        /// </summary>
        [TestMethod]
        public void CompareArrayHelpersTestArrayOfArraysNoMatchMultipleElementsMultipleArrays_ShouldReturnFalse()
        {
            var array1 = new List<List<int>>
            {
                new List<int> { 1, 2, 8, 20 },
                new List<int> { 3, 4 },
                new List<int> { 5, 6, 7, 8 }
            };
            var array2 = new List<List<int>>
            {
                new List<int> { 1, 2, 8, 20 },
                new List<int> { 3, 4 },
                new List<int> { 5, 6, 7 }
            };
            Assert.IsFalse(CompareArrayHelpers.CompareArrays(array1, array2));
        }
    }
}
