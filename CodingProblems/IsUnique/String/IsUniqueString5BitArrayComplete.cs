using System;
using System.Collections;

namespace CodingProblems.IsUnique.String
{
    /// <summary>
    /// Class that implements IsUnique.
    /// </summary>
    public static class IsUniqueString5BitArrayComplete
    {
        /// <summary>
        /// Determines whether the input string contains duplicate characters.
        /// </summary>
        /// <param name="input">The input string.</param>
        /// <returns>False if the string is contains duplicate characters, true otherwise.</returns>
        public static bool IsUnique(string input)
        {
            // If null, return.
            if (input == null)
                return true;

            // Determine max # of chars.
            // (64K)
            var maxChars = (int)Math.Pow(2, sizeof(char) * 8);

            // If too many chars, fail.
            if (input.Length > maxChars)
                return false;

            // Allocate & initialize array.
            var arr = new BitArray(maxChars, false);

            // Check each.
            foreach (var c in input)
            {
                // Fail if there.
                if (arr[c])
                    return false;
                // Add.
                else
                    arr[c] = true;
            }

            return true;
        }
    }
}
