using System;

namespace CodingProblems.Array_.SearchSortedNoSize
{
    /// <summary>
    /// Implements Merge
    /// </summary>
    public static class ArraySearchSortedNoSize3BinarySearchNoSizeComplete
    {
        /// <summary>
        /// Search for value in listNoSize.
        /// </summary>
        /// <param name="listNoSize">The list.</param>
        /// <param name="value">The value to find.</param>
        /// <returns>The index of the value or -1 if not found.</returns>
        public static int Search(ListNoSize listNoSize, int value)
        {
            // Error checking.
            if (listNoSize == null)
                throw new ArgumentException("Both arrays must be non-null");

            // Error checking.
            if (value < 0)
                throw new ArgumentException("Value must be positive.");

            // Note: Important that index starts at zero to handle case where
            // matching element is first element in array.
            var indexPrev = 0;
            var index = 0;
            int? indexLast = null;

            // Outer loop, unknown length binary search.
            // Note: End point is
            // indexPrev == indexLast (First element is element we are looking for)
            // or indexPrev == indexLast - 1 (Element not found).
            while (indexLast == null || (indexPrev < indexLast - 1))
            {
                // Start increment at 1.
                var indexIncrement = 1;

                // Get current element.
                var element = listNoSize.ElementAt(index);

                // Inner loop find element or outside of array bounds.
                while (element != -1 && element < value)
                {
                    // Store previous index.
                    indexPrev = index;

                    // Update the index and element.
                    index += indexIncrement;
                    element = listNoSize.ElementAt(index);

                    // Update the increment.
                    indexIncrement *= 2;
                }

                // Found element.
                if (element == value)
                    return index;

                // Store last index.
                indexLast = index;

                // Reset starting location.
                index = indexPrev;
            }

            // Not found.
            return -1;
        }
    }
}
