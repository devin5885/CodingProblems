using System;
using System.Collections.Generic;

// ReSharper disable once CheckNamespace
namespace CodingProblems.Array_.Sort
{
    /// <summary>
    /// Implements Selection Sort.
    /// </summary>
    public static class ArraySortSelectionSortComplete
    {
        /// <summary>
        /// Sorts the array using Selection Sort.
        /// </summary>
        /// <param name="input">The input array.</param>
        public static void Sort(List<int> input)
        {
            // Error handling.
            if (input == null)
                throw new ArgumentException("Input array must not be null.");

            // Outer loop, sort entire list, loop through list n times left to right.
            for (var unsortedIndex = 0; unsortedIndex < input.Count; unsortedIndex++)
            {
                // Inner loop, find the index of the element with the least value.
                var minIndex = unsortedIndex;
                for (var currentIndex = unsortedIndex; currentIndex < input.Count; currentIndex++)
                {
                    if (input[currentIndex] < input[minIndex])
                        minIndex = currentIndex;
                }

                // Swap.
                Swap(input, minIndex, unsortedIndex);
            }
        }

        /// <summary>
        /// Helper that swaps firstIndex and secondIndex in the input array.
        /// </summary>
        /// <param name="input">The input array.</param>
        /// <param name="firstIndex">The first index.</param>
        /// <param name="secondIndex">The second index.</param>
        public static void Swap(List<int> input, int firstIndex, int secondIndex)
        {
            var temp = input[firstIndex];
            input[firstIndex] = input[secondIndex];
            input[secondIndex] = temp;
        }
    }
}
