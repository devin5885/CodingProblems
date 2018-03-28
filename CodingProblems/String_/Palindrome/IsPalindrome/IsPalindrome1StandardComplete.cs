using System;

namespace CodingProblems.String_.Palindrome.IsPalindrome
{
    /// <summary>
    /// Implements IsPalindrome.
    /// </summary>
    public static class IsPalindrome1StandardComplete
    {
        /// <summary>
        /// Checks whether the input string is a palindrome.
        /// </summary>
        /// <param name="input">The input string.</param>
        /// <returns>True if the input string is a palindrome.</returns>
        public static bool IsPalindrome(string input)
        {
            // Error handling.
            if (input == null)
                throw new ArgumentException();

            // Initialize references.
            var left = 0;
            var right = input.Length - 1;

            // See if strings match.
            while (left < right)
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
