namespace CodingProblems.IsUnique.String
{
    /// <summary>
    /// Class that implements IsUnique.
    /// </summary>
    public static class IsUniqueString2NoAdditionalDataStructuresComplete
    {
        /// <summary>
        /// Determines whether the input string contains duplicate characters.
        /// </summary>
        /// <param name="input">The input string.</param>
        /// <returns>False if the string is contains duplicate characters, true otherwise.</returns>
        public static bool IsUnique(string input)
        {
            // Check & add.
            if (input != null)
                for (var i = 0; i < input.Length; i++)
                {
                    for (var j = i + 1; j < input.Length; j++)
                    {
                        // If a duplicate is found we are done.
                        if (input[i] == input[j])
                            return false;
                    }
                }

            // No duplicates found.
            return true;
        }
    }
}
