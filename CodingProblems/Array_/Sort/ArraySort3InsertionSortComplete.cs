using System;
using System.Collections.Generic;

namespace CodingProblems.Array_.Sort
{
    /// <summary>
    /// Implements Sort.
    /// </summary>
    public static class ArraySort3InsertionSortComplete
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

            // Outer loop walks unsorted part of list.
            // At start of loop outer points to last unsorted, at end first sorted.
            // Skip first element since already sorted.
            for (var outerIndex = 1; outerIndex < input.Count; outerIndex++)
            {
                // Store element being moved.
                //  We can now use outer.
                var temp = input[outerIndex];

                // Find insertion point, start at outer go downward.
                // inner points to hole that element can be moved to.
                // inner - 1 points to element to be moved.
                // If element at inner - 1 is < than temp then no move is needed.
                var innerIndex = outerIndex;
                while (innerIndex > 0 && temp < input[innerIndex - 1])
                {
                    // Move each element up one until insertion point is found.
                    input[innerIndex] = input[innerIndex - 1];
                    innerIndex--;
                }

                // Inner now points to where to put temp.
                // Add back element being moved.
                input[innerIndex] = temp;
            }
        }
    }
}
