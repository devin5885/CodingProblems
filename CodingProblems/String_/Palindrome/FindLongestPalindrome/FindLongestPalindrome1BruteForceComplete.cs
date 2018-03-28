using System;

namespace CodingProblems.String_.Palindrome.FindLongestPalindrome
{
    /// <summary>
    /// Implements FindLongestPalidrome.
    /// </summary>
    public static class FindLongestPalindrome1BruteForceComplete
    {
        /// <summary>
        /// Gets the longest Palindrome from the string.
        /// </summary>
        /// <param name="input">The input string.</param>
        /// <returns>The resulting palindrome.</returns>
        public static string FindLongestPalindrome(string input)
        {
            // Error handling.
            if (input == null)
                throw new ArgumentException();

            // Check strings of length input, then strings of length - 1, length - 2 etc.
            for (var len = input.Length; len > 0; len--)
                for (var startindex = 0; startindex < len - startindex; startindex++)
                {
                    // Get the string & see if it is a palindrome.
                    var toCheck = input.Substring(startindex, len - startindex);
                    if (IsPalindrome(toCheck))
                        return toCheck;
                }

            // No palindrome found.
            return string.Empty;
        }

        /// <summary>
        /// Helper function that checks whether the input item is a palindrome.
        /// </summary>
        /// <param name="input">The input string.</param>
        /// <returns>True if the specified string is a Palindrome.</returns>
        private static bool IsPalindrome(string input)
        {
            // Error handling.
            if (input == null)
                throw new ArgumentException();

            // Initialize refs.
            var left = 0;
            var right = input.Length - 1;

            // See if strings match.
            while (left <= right)
            {
                // Strings don't match.
                if (input[left++] != input[right--])
                    return false;
            }

            // Match.
            return true;
        }
    }
}
