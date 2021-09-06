using System;
using System.Collections.Generic;

// ReSharper disable once CheckNamespace
namespace CodingProblems.Array_.Sort
{
    /// <summary>
    /// Implements Sort.
    /// </summary>
    public static class ArraySortBubbleSortComplete
    {
        /// <summary>
        /// Sorts the array using Bubble Sort.
        /// </summary>
        /// <param name="input">The input array.</param>
        public static void Sort(List<int> input)
        {
            // Error handling.
            if (input == null)
                throw new ArgumentException("Input array must not be null.");

            // Outer loop:
            // Loop left to right sorting one element per iteration.
            // Start at beginning of list, end at last element.
            for (var unsortedIndex = 0; unsortedIndex < input.Count; unsortedIndex++)
            {
                // Inner loop
                // Loop through unsorted part of list right to left, swapping elements as needed.
                //  Start at last element of array, end at last unsorted element + 1.
                for (var currentIndex = input.Count - 1; currentIndex >= unsortedIndex + 1; currentIndex--)
                {
                    // Swap if <.
                    if (input[currentIndex] < input[currentIndex - 1])
                    {
                        // Swap.
                        Swap(input, currentIndex, currentIndex - 1);
                    }
                }
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
