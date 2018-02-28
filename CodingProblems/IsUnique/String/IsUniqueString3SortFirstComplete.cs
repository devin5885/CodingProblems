using System.Linq;

namespace CodingProblems.IsUnique.String
{
    /// <summary>
    /// Class that implements IsUnique.
    /// </summary>
    public static class IsUniqueString3SortFirstComplete
    {
        /// <summary>
        /// Determines whether the input string contains duplicate characters.
        /// </summary>
        /// <param name="input">The input string.</param>
        /// <returns>False if the string is contains duplicate characters, true otherwise.</returns>
        public static bool IsUnique(string input)
        {
            // Null check.
            if (input == null)
                return true;

            // Sort the string.
            var sorted = string.Concat(input.OrderBy(c => c));

            // Check & add.
            for (int i = 0; i < sorted.Length - 2; i++)
            {
                // If a duplicate is found, we are done.
                if (sorted[i] == sorted[i + 1])
                    return false;
            }

            // No duplicates found.
            return true;
        }
    }
}
