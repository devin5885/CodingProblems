using System.Collections.Generic;

namespace CodingProblems.IsUnique.String
{
    /// <summary>
    /// Class that implements IsUnique.
    /// </summary>
    public static class IsUniqueString1HashSetComplete
    {
        /// <summary>
        /// Determines whether the input string contains duplicate characters.
        /// </summary>
        /// <param name="input">The input string.</param>
        /// <returns>False if the string is contains duplicate characters, true otherwise.</returns>
        public static bool IsUnique(string input)
        {
            // Create hash set.
            var data = new HashSet<char>();

            // Check & add.
            if (input != null)
                foreach (var c in input)
                {
                    // If a duplicate is found, we are done.
                    if (data.Contains(c))
                        return false;
                    else
                        data.Add(c);
                }

            // No duplicates found.
            return true;
        }
    }
}
