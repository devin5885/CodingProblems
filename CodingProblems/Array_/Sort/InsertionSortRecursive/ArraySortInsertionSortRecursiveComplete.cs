using System;
using System.Collections.Generic;

// ReSharper disable once CheckNamespace
namespace CodingProblems.Array_.Sort
{
    /// <summary>
    /// Implements Sort.
    /// </summary>
    public static class ArraySortInsertionSortRecursiveComplete
    {
        /// <summary>
        /// Sorts the array using recursive insertion Sort.
        /// </summary>
        /// <param name="input">The input array.</param>
        /// <param name="length">The length indicating the part of the array to sort.</param>
        public static void Sort(List<int> input, int length = -1)
        {
            // Error handling.
            if (input == null)
                throw new ArgumentException("Input array must not be null.");

            // Default case.
            if (length == -1)
                length = input.Count;

            // Trivial sort.
            if (length <= 1)
                return;

            // Recursive call.
            Sort(input, length - 1);

            // Store element being sorted.
            // input[length - 1] is now open.
            var temp = input[length - 1];

            // Find insertion point in sorted part of array, start at length - 2 and go left
            // As we walk the array move each element from input[inner] to input[inner + 1] to free up input[inner].
            // inner points to element that may be shifted.
            // input[inner] > temp and we are not past the end of the array, a shift is needed.
            var inner = length - 2;
            for (; inner >= 0 && input[inner] > temp; inner--)
            {
                // Move each element right one until insertion point is found.
                input[inner + 1] = input[inner];
            }

            // inner + 1 now points to where to put temp (Remember it was decremented during the last iteration).
            // Add back element being sorted.
            input[inner + 1] = temp;
        }
    }
}
