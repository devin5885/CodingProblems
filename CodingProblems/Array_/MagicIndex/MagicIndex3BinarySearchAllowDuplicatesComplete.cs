using System;

namespace CodingProblems.Array_.MagicIndex
{
    /// <summary>
    /// Implements MagicIndex3BinarySearchAllowDuplicatesComplete.FindMagicIndex
    /// </summary>
    public static class MagicIndex3BinarySearchAllowDuplicatesComplete
    {
        /// <summary>
        /// Finds and returns the index for which the array contents matches the index.
        /// </summary>
        /// <param name="array">The array.</param>
        /// <returns>The magic index or -1 if not found.</returns>
        public static int FindMagicIndex(int[] array)
        {
            // Error checking.
            if (array == null)
                throw new ArgumentException("Invalid array.");

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

            // Search left.
            var leftIndex = Math.Min(midIndex - 1, midValue);
            var leftValue = FindMagicIndexHelper(array, startIndex, leftIndex);
            if (leftValue >= 0)
                return leftValue;

            // Search right.
            var rightIndex = Math.Max(midIndex + 1, midValue);
            return FindMagicIndexHelper(array, rightIndex, endIndex);
        }
    }
}