using System;
using System.Collections.Generic;

namespace CodingProblems.String_.Permutations
{
    /// <summary>
    /// Implements GetPermutations
    /// </summary>
    public static class GetPermutations2UseDictionaryComplete
    {
        /// <summary>
        /// Generates and returns a list of permutations. Note that the
        /// generated permutations must use all characters from the input
        /// string.
        /// </summary>
        /// <param name="input">The string to parse.</param>
        /// <returns>The list of permutations.</returns>
        public static List<string> GetPermutations(string input)
        {
            // Error checking.
            if (input == null)
                throw new ArgumentException("input string must be non-null");

            // Build the dictionary of characters and counts.
            var charCountDict = BuildCharCountDict(input);

            // Generate the permutations.
            var result = new List<string>();
            GetPermutationsHelper(result, string.Empty, charCountDict);
            return result;
        }

        /// <summary>
        /// Helper method that takes a dictionary of permutations a current
        /// string and a dictionary of remaining characters. If out of
        /// characters adds the resulting permutation to the list, otherwise
        /// recursively calls the method for each remaining character to
        /// generate and add additional permutations using that letter.
        /// </summary>
        /// <param name="result">The result list of permutations.</param>
        /// <param name="current">The current string.</param>
        /// <param name="charCountDict">The dictionary of character counts.</param>
        private static void GetPermutationsHelper(List<string> result, string current, Dictionary<char, int> charCountDict)
        {
            // Error checking.
            if (result == null || current == null || charCountDict == null)
                throw new ArgumentException("Parameters must be non-null.");

            // If out of chars just add the resulting permutation to the result and return.
            if (charCountDict.Count == 0)
            {
                // Only add non-empty.
                if (!string.IsNullOrEmpty(current))
                    result.Add(current);

                return;
            }

            // Process remaining characters in dictionary.
            foreach (var ch in charCountDict)
            {
                // Build the updated dictionary (with this char deleted)
                // Note that since this dictionary has a max of 26 entries, creating
                // a new dictionary should not be all that expensive.
                var charCountDictNew = new Dictionary<char, int>(charCountDict);
                ConsumeCharFromCharCountDict(charCountDictNew, ch.Key);

                // Make recursive call to build additional permutations based
                // on the current string and the new character.
                GetPermutationsHelper(result, current + ch.Key, charCountDictNew);
            }
        }

        /// <summary>
        /// Helper that builds a dictionary of characters in the string and the
        /// counts of those characters.
        /// </summary>
        /// <param name="input">The input string.</param>
        /// <returns>The resulting dictionary.</returns>
        private static Dictionary<char, int> BuildCharCountDict(string input)
        {
            // Error checking.
            if (input == null)
                throw new ArgumentException("input string must be non-null");

            // Build result.
            var result = new Dictionary<char, int>();

            // Process all characters in string.
            foreach (var ch in input)
            {
                // Get the count, if found, increment.
                if (result.TryGetValue(ch, out var count))
                {
                    result[ch] = ++count;
                }
                // Otherwise add.
                else
                    result.Add(ch, 1);
            }

            // Return result.
            return result;
        }

        /// <summary>
        /// Helper that gets the count of an existing character in the
        /// character count dictionary, if the count is one the character
        /// is deleted from the dictionary, otherwise the count is
        /// reduced by one.
        /// </summary>
        /// <param name="charCountDict">The existing dictionary of character
        /// counts.</param>
        /// <param name="ch">The character to process.</param>
        private static void ConsumeCharFromCharCountDict(Dictionary<char, int> charCountDict, char ch)
        {
            // Error checking.
            if (charCountDict == null)
                throw new ArgumentException("Dictionary must be non-null");

            // Note: Assume that ch is in charCountDict, allow exception to be
            // thrown if this is not the case.

            // Get the count.
            var count = charCountDict[ch];

            // If count is greater than one reduce.
            if (count > 1)
                charCountDict[ch] = --count;
            // Remove when count will be at zero.
            else
                charCountDict.Remove(ch);
        }
    }
}
