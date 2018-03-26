using System;

namespace CodingProblems.String_.FindFirstNonRepeatedCharIndex
{
    /// <summary>
    /// Implements FindFirstNonRepeatedCharIndex
    /// </summary>
    public static class FindFirstNonRepeatedCharIndex1BruteForceComplete
    {
        /// <summary>
        /// Find the index of the first non-repeated character.
        /// </summary>
        /// <param name="str">String to search.</param>
        /// <returns>The index of the first non-repeated character.</returns>
        public static int FindFirstNonRepeatedCharIndex(string str)
        {
            // Error checking.
            if (str == null)
                throw new ArgumentException("A non-null string must be specified.");

            // Check each char in the string.
            for (var i = 0; i < str.Length; i++)
            {
                // See if this char is somewhere else in the string.
                // If so, go to the next char.
                // Note: Be sure to start at the beginning of the
                // string each time so that we don't get false
                // positives.
                var repeated = false;
                for (var j = 0; j < str.Length && !repeated; j++)
                {
                    // If found, end.
                    if (i != j && str[i] == str[j])
                        repeated = true;
                }

                // Non-repeated return.
                if (!repeated)
                    return i;
            }

            // No non-repeated found.
            return -1;
        }
    }
}
