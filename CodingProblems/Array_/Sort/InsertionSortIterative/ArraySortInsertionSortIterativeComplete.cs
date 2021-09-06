using System;
using System.Collections.Generic;

// ReSharper disable once CheckNamespace
namespace CodingProblems.Array_.Sort
{
    /// <summary>
    /// Implements Sort.
    /// </summary>
    public static class ArraySortInsertionSortIterativeComplete
    {
        /// <summary>
        /// Sorts the array using Insertion Sort.
        /// </summary>
        /// <param name="input">The input array.</param>
        public static void Sort(List<int> input)
        {
            // Error handling.
            if (input == null)
                throw new ArgumentException("Input array must not be null.");

            for (var length = 2; length < input.Count + 1; length++)
            {
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
}
