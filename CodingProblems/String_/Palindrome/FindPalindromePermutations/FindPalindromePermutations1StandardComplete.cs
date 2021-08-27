using System;
using System.Collections.Generic;
using System.Linq;
using CodingProblems.String_.Palindrome.IsPalindrome;
using CodingProblems.String_.Permutations;

namespace CodingProblems.String_.Palindrome.FindPalindromePermutations
{
    /// <summary>
    /// Implements FindPalindromePermutations
    /// </summary>
    public static class FindPalindromePermutations1StandardComplete
    {
        /// <summary>
        /// Finds Palindrome permutations.
        /// Note that the input string must be a Palindrome.
        /// </summary>
        /// <param name="input">The input string.</param>
        /// <returns>The resulting palindrome permutations.</returns>
        public static List<string> FindPalindromePermutations(string input)
        {
            // Error Checking.
            if (input == null)
                throw new ArgumentException("Input string must be non-null.");

            if (!IsPalindrome1StandardComplete.IsPalindrome(input))
                throw new ArgumentException("Input string must be a palindrome.");

            // Initialize result.
            var result = new List<string>();

            // No other results if less than 4.
            if (input.Length < 4)
            {
                // String itself is a palindrome.
                result.Add(input);
                return result;
            }

            // Split the string.
            var halflen = input.Length / 2;
            var left = input.Substring(0, halflen);

            // Get permutations for first half of string.
            var permutations = GetPermutations2UseDictionaryComplete.GetPermutations(left);

            // Build resulting strings.
            foreach (var permutation in permutations)
            {
                // Reverse the permutation.
                var permutationReversed = string.Concat(permutation.Reverse());

                // Add resulting string.
                result.Add(permutation + (input.Length % 2 == 1 ? input[halflen].ToString() : string.Empty) + permutationReversed);
            }

            // Return result.
            return result;
        }
    }
}
