using System;
using System.Collections.Generic;

namespace CodingProblems.Palindrome.IsPalindromePermutation
{
    /// <summary>
    /// Class that implements IsPalidromePermutation
    /// </summary>
    public static class PalindromeIsPalindromePermutation1SimpleComplete
    {
        /// <summary>
        /// Method that determines whether a string is a palindrome permutation.
        /// </summary>
        /// <param name="input">The input string.</param>
        /// <returns>True if the string is a palindrome permutation, false otherwise.</returns>
        public static bool IsPalindromePermutation(string input)
        {
            if (input == null)
                throw new ArgumentException("Null string");

            // Strategy: Use a dictionary to store chars and a boolean indicator:
            // true - Even # of instances.
            // false - Odd # of instances.
            var dict = new Dictionary<char, bool>();
            foreach (var c in input)
            {
                // Toggle if found.
                if (dict.TryGetValue(c, out bool result))
                    dict[c] = !result;
                // Add as odd # of instances.
                else
                    dict[c] = false;
            }

            // Now check the dictionary.
            // Make sure there is only one odd # of instances.
            var oddFound = false;
            foreach (var kvp in dict)
            {
                if (!kvp.Value)
                {
                    if (oddFound)
                        return false;
                    else
                        oddFound = true;
                }
            }

            // Valid.
            return true;
        }
    }
}
