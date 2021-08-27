using System;

namespace CodingProblems.Array_.SearchSortedNoSize
{
    /// <summary>
    /// Implements Merge
    /// </summary>
    public static class ArraySearchSortedNoSize1BruteForceComplete
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

            var index = 0;
            var element = listNoSize.ElementAt(index);

            while (element < value && element != -1)
            {
                index++;
                element = listNoSize.ElementAt(index);
            }

            if (element == -1)
                return -1;
            else
                return index;
        }
    }
}
