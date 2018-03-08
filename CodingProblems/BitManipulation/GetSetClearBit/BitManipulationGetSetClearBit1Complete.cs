namespace CodingProblems.BitManipulation.GetSetClearBit
{
    /// <summary>
    /// Implements GetBit, SetClearBit
    /// </summary>
    public static class BitManipulationGetSetClearBit1Complete
    {
        /// <summary>
        /// Gets the value of the specified bit.
        /// </summary>
        /// <param name="num">The number to check.</param>
        /// <param name="index">The index of the bit to check.</param>
        /// <returns>True if the bit is set, false otherwise.</returns>
        public static bool GetBit(int num, int index)
        {
            // Build the mask.
            // Note: Don't use mask helpers here as they might use this
            // method.
            var mask = 1 << index;

            // Do the operation.
            return (num & mask) != 0;
        }

        /// <summary>
        /// Sets or clears the specified bit in the specified signed integer.
        /// </summary>
        /// <param name="num">The signed integer to update.</param>
        /// <param name="index">The index of the bit to set or clear.</param>
        /// <param name="set">Whether to set or clear the bit.</param>
        /// <returns>The updated unsigned integer.</returns>
        public static int SetClearBit(int num, int index, bool set = true)
        {
            // Build the mask.
            // Note: Don't use mask helpers here as they might use this
            // method.
            var mask = 1 << index;

            // Do the operation.
            if (set)
                return num | mask;
            else
                return num & ~mask;
        }
    }
}