using System;

namespace CodingProblems.Array_.SearchSortedNoSize
{
    /// <summary>
    /// Implements Merge
    /// </summary>
    public static class ArraySearchSortedNoSize1BruteForceComplete
    {
        /// <summary>
        /// Search for value in listy.
        /// </summary>
        /// <param name="listy">The list.</param>
        /// <param name="value">The value to find.</param>
        /// <returns>The index of the value or -1 if not found.</returns>
        public static int Search(Listy listy, int value)
        {
            // Error checking.
            if (listy == null)
                throw new ArgumentException("Both arrays must be non-null");

            // Error checking.
            if (value < 0)
                throw new ArgumentException("Value must be positive.");

            var index = 0;
            var element = listy.ElementAt(index);

            while (element < value && element != -1)
            {
                index++;
                element = listy.ElementAt(index);
            }

            if (element == -1)
                return -1;
            else
                return index;
        }
    }
}
