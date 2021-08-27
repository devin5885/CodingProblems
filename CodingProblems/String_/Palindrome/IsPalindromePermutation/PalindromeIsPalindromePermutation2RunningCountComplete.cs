using System;
using System.Collections.Generic;

namespace CodingProblems.String_.Palindrome.IsPalindromePermutation
{
    /// <summary>
    /// Class that implements IsPalindromePermutation
    /// </summary>
    public static class PalindromeIsPalindromePermutation2RunningCountComplete
    {
        /// <summary>
        /// Method that determines whether a string is a palindrome permutation.
        /// </summary>
        /// <param name="input">The input string.</param>
        /// <returns>True if the string is a palindrome permutation, false otherwise.</returns>
        public static bool IsPalindromePermutation(string input)
        {
            // Error checking.
            if (input == null)
                throw new ArgumentException("Null string");

            // Start with valid.
            var countOdd = 0;

            // Strategy: Use a dictionary to store chars and a boolean indicator:
            // true - Even # of instances.
            // false - Odd # of instances.
            var dict = new Dictionary<char, bool>();
            foreach (var c in input)
            {
                // Toggle if found.
                if (dict.TryGetValue(c, out var result))
                {
                    // Changing back to odd.
                    if (result)
                        countOdd++;
                    else
                        countOdd--;

                    dict[c] = result;
                }
                // Add as odd # of instances.
                else
                {
                    dict[c] = false;

                    // Adding as odd.
                    countOdd++;
                }
            }

            // Valid.
            return countOdd <= 1;
        }
    }
}
