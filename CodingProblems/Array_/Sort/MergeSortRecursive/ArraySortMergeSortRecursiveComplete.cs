using System;
using System.Collections.Generic;

// ReSharper disable once CheckNamespace
namespace CodingProblems.Array_.Sort
{
    /// <summary>
    /// Implements Sort.
    /// </summary>
    public static class ArraySortMergeSortRecursiveComplete
    {
        /// <summary>
        /// Sorts the array using merge sort.
        /// </summary>
        /// <param name="input">The input array.</param>
        public static void Sort(List<int> input)
        {
            // Error handling.
            if (input == null)
                throw new ArgumentException("Input array must not be null.");

            SortHelper(input, 0, input.Count - 1);
        }

        /// <summary>
        /// Recursive helper for merge sort.
        /// </summary>
        /// <param name="input">The input array.</param>
        /// <param name="startIndex">The start index of the input array.</param>
        /// <param name="endIndex">The end index of the input array.</param>
        public static void SortHelper(List<int> input, int startIndex = 0, int? endIndex = null)
        {
            // Error handling.
            if (input == null)
                throw new ArgumentException("Input array must not be null.");

            // Default case.
            if (endIndex == null)
                endIndex = input.Count - 1;

            // Done.
            if (startIndex >= endIndex)
                return;

            var midIndex = (startIndex + (int)endIndex) / 2;
            SortHelper(input, startIndex, midIndex);
            SortHelper(input, midIndex + 1, endIndex);

            MergeSortedSubArrays(input, startIndex, midIndex, (int)endIndex);
        }

        /// <summary>
        /// Merges the right and left sub-arrays within input which are each assumed to be sorted.
        /// </summary>
        /// <param name="input">The input array.</param>
        /// <param name="startIndex">The start index of the left sub-array.</param>
        /// <param name="midIndex">The middle index. Defines the end index of the left sub-array.
        /// midIndex + 1 defines the first index of the right sub-array.</param>
        /// <param name="endIndex">The end index of the right sub-array.</param>
        private static void MergeSortedSubArrays(List<int> input, int startIndex, int midIndex, int endIndex)
        {
            // Init source indexes.
            var currIndexLeft = startIndex;
            var currIndexRight = midIndex + 1;

            // Init target array and index.
            var aux = new List<int>();

            // Copy until we run out of elements in left or right.
            while (currIndexLeft <= midIndex && currIndexRight <= endIndex)
            {
                // ReSharper disable once ConvertIfStatementToConditionalTernaryExpression
                if (input[currIndexLeft] > input[currIndexRight])
                    aux.Add(input[currIndexRight++]);
                else
                    aux.Add(input[currIndexLeft++]);
            }

            // Copy remaining.
            while (currIndexLeft <= midIndex)
                aux.Add(input[currIndexLeft++]);

            while (currIndexRight <= endIndex)
                aux.Add(input[currIndexRight++]);

            // Copy back.
            for (var i = 0; i < aux.Count; i++)
                input[i + startIndex] = aux[i];
        }
    }
}
