using System;

namespace CodingProblems.Array_.SearchSortedNoSize
{
    /// <summary>
    /// Implements Merge
    /// </summary>
    public static class ArraySearchSortedNoSize2BinarySearchComplete
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

            // Find starting index.
            var index = 1;
            var element = listNoSize.ElementAt(index);

            while (element != -1 && element < value)
            {
                index *= 2;
                element = listNoSize.ElementAt(index);
            }

            // Initialize indexes.
            var indexStart = index / 2;
            var indexEnd = index;

            // At this point we know that value is between indexStart and indexEnd.
            // Do a standard binary search.
            while (indexEnd >= indexStart)
            {
                // Get middle element.
                var middle = ((indexEnd - indexStart) / 2) + indexStart;
                element = listNoSize.ElementAt(middle);

                // Go left.
                if (element == -1 || value < element)
                {
                    indexEnd = middle - 1;
                }
                else if (value > element)
                // Go right.
                {
                    indexStart = middle + 1;
                }
                // Match.
                else
                    return middle;
            }

            // Not found.
            return -1;
        }
    }
}
