using System;
using System.Collections.Generic;

namespace CodingProblems.String_.Permutations
{
    /// <summary>
    /// Implements GetPermutations
    /// </summary>
    public static class GetPermutations1NoDuplicatesByCharComplete
    {
        /// <summary>
        /// Generates and returns a list of permutations.
        /// </summary>
        /// <param name="str">The string to parse.</param>
        /// <returns>The list of permutations.</returns>
        public static List<string> GetPermutations(string str)
        {
            // Initialize result.
            var result = new List<string>();

            // For null, return empty set.
            if (str == null)
                return result;

            // Add initial string.
            if (str.Length > 0)
                result.Add(new string(str[0], 1));

            // Process each character.
            for (var i = 1; i < str.Length; i++)
            {
                // Generate strings.
                var resultCurr = new List<string>();

                // Generate perms with this string.
                foreach (var strCurr in result)
                {
                    for (var charIndex = 0; charIndex <= strCurr.Length; charIndex++)
                    {
                        // Generate pre + post strings.
                        var strPre = string.Empty;
                        var strPost = string.Empty;

                        if (charIndex > 0)
                            strPre = strCurr.Substring(0, charIndex);

                        if (charIndex < strCurr.Length)
                            strPost = strCurr.Substring(charIndex, strCurr.Length - charIndex);

                        // Build and add resulting string.
                        var strNew = strPre + str[i] + strPost;
                        resultCurr.Add(strNew);
                    }
                }

                // Add to results.
                result = resultCurr;
            }

            // Return result.
            return result;
        }
    }
}