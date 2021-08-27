namespace CodingProblems.Matrix.Helpers
{
    /// <summary>
    /// Matrix helper methods.
    /// </summary>
    public static class MatrixHelpers
    {
        /// <summary>
        /// Compares two matrices and returns true if the matrices match.
        /// Matrices match if all elements have the same value.
        /// </summary>
        /// <param name="matrix1">The first matrix to compare.</param>
        /// <param name="matrix2">The second matrix to compare.</param>
        /// <returns>True if the matrices match, false otherwise.</returns>
        public static bool Compare(int[,] matrix1, int[,] matrix2)
        {
            // Get length, check match.
            var length = matrix1.GetLength(0);
            if (matrix2.GetLength(0) != length)
                return false;

            // Check matrix.
            for (var i = 0; i < length; i++)
                for (var j = 0; j < length; j++)
                {
                    if (matrix1[i, j] != matrix2[i, j])
                        return false;
                }

            // Match.
            return true;
        }
    }
}
