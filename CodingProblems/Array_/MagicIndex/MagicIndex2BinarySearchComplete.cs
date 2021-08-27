using System;
using System.Linq;

namespace CodingProblems.Array_.MagicIndex
{
    /// <summary>
    /// Implements MagicIndex2BinarySearchComplete.FindMagicIndex
    /// </summary>
    public static class MagicIndex2BinarySearchComplete
    {
        /// <summary>
        /// Finds and returns the index for which the array contents matches
        /// the index.
        /// </summary>
        /// <param name="array">The array.</param>
        /// <returns>The magic index or -1 if not found.</returns>
        public static int FindMagicIndex(int[] array)
        {
            // Error checking.
            if (array == null)
                throw new ArgumentException("Invalid array.");

            // Error checking.
            if (array.Distinct().Count() != array.Length)
                throw new ArgumentException("Array must not have duplicate elements.");

            // Call helper method.
            return FindMagicIndexHelper(array, 0, array.Length - 1);
        }

        /// <summary>
        /// Helper for FindMagicIndex
        /// </summary>
        /// <param name="array">The array.</param>
        /// <param name="startIndex">The current start index.</param>
        /// <param name="endIndex">The current end index.</param>
        /// <returns>The magic index or -1 if not found.</returns>
        public static int FindMagicIndexHelper(int[] array, int startIndex, int endIndex)
        {
            // Not found.
            if (endIndex < startIndex)
                return -1;

            // Compute mid/Get midValue.
            var midIndex = (endIndex + startIndex) / 2;
            var midValue = array[midIndex];

            // Found result.
            if (midValue == midIndex)
                return midIndex;

            // Go left.
            if (midValue > midIndex)
                return FindMagicIndexHelper(array, startIndex, midIndex - 1);
            // Go right.
            // ReSharper disable once RedundantIfElseBlock
            else
                return FindMagicIndexHelper(array, midIndex + 1, endIndex);
        }
    }
}