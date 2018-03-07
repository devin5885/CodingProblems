namespace CodingProblems.BitManipulation.Helpers
{
    /// <summary>
    /// Helpers for bitwise operations.
    /// </summary>
    public static class BitManipulationHelpers
    {
        /// <summary>
        /// Clears the specified bit in the specified unsigned integer.
        /// </summary>
        /// <param name="num">The unsigned integer to update.</param>
        /// <param name="i">The bit to clear.</param>
        /// <returns>The updated unsigned integer.</returns>
        public static uint ClearBit(this uint num, int i)
        {
            int mask = ~(1 << i);
            return num & (uint)mask;
        }

        /// <summary>
        /// Sets the specified bit in the specified unsigned integer.
        /// </summary>
        /// <param name="num">The unsigned integer to update.</param>
        /// <param name="i">The bit to set.</param>
        /// <returns>The updated unsigned integer.</returns>
        public static uint SetBit(this uint num, int i)
        {
            return num | (uint)(1 << i);
        }
    }
}
