using System;
using System.Collections.Generic;

namespace CodingProblems.String_.FindFirstNonRepeatedCharIndex
{
    /// <summary>
    /// Implements FindFirstNonRepeatedCharIndex
    /// </summary>
    public static class FindFirstNonRepeatedCharIndex2UseHashSetComplete
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

            // Initialize hash set to store already found chars.
            var found = new HashSet<char>();

            // Check each char in the string.
            for (var i = 0; i < str.Length; i++)
            {
                // Skip if already in hash set.
                if (found.Contains(str[i]))
                    continue;

                // See if this char is somewhere else in the string.
                // If so, go to the next char.
                var repeated = false;
                for (var j = i + 1; j < str.Length && !repeated; j++)
                {
                    if (str[i] == str[j])
                        repeated = true;
                }
                if (!repeated)
                    return i;

                // Add to found hash-set.
                found.Add(str[i]);
            }

            // No non-repeated found.
            return -1;
        }
    }
}
