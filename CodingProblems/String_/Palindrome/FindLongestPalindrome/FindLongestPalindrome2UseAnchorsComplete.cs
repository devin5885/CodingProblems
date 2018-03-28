using System;

namespace CodingProblems.String_.Palindrome.FindLongestPalindrome
{
    /// <summary>
    /// Implements FindLongestPalidrome.
    /// </summary>
    public static class FindLongestPalindrome2UseAnchorsComplete
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

            // Initialize result.
            var result = string.Empty;

            // Try all anchor indexes.
            for (var anchorIndex = 0; anchorIndex < input.Length; anchorIndex++)
            {
                // Iterate twice:
                // i is 0, Check all strings with anchor character as center character
                // of string (Strings with odd number of characters).
                // i is 1, Check all strings with anchor character between the two
                // center characters (Strings with even number of characters).
                for (int i = 0; i <= 1; i++)
                {
                    // Compute initial indexes.
                    var indexLeft = anchorIndex;
                    var indexRight = anchorIndex + (i == 1 ? 1 : 0);

                    // Initialize best index for this iteration, these are the
                    // best indexes that create a palindrome string during this
                    // iteration.
                    int? indexLeftBest = null;
                    int? indexRightBest = null;

                    // Keep checking while there are indexes to check & strings match.
                    while (indexLeft >= 0 && indexRight < input.Length)
                    {
                        // If match update best indexes.
                        if (input[indexLeft] == input[indexRight])
                        {
                            indexLeftBest = indexLeft;
                            indexRightBest = indexRight;
                        }
                        // Otherwise we are done with these indexes.
                        // (i.e.) we can't form an palindrome longer than
                        // the current palindrome (if any).
                        else
                            break;

                        // Try next longer palindrome.
                        indexLeft--;
                        indexRight++;
                    }

                    // Now see if this string is better than the current string.
                    if (indexLeftBest != null && indexRightBest != null)
                    {
                        // Calculate the length of this palindrome.
                        var newLength = indexRightBest - indexLeftBest + 1;

                        // If longer then new result.
                        if (newLength > result.Length)
                            result = input.Substring((int)indexLeftBest, (int)newLength);
                    }
                }
            }

            // Return result.
            return result;
        }
    }
}
