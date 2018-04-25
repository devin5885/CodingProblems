using System;
using System.IO;

namespace CodingProblems.Array_.MissingInt
{
    /// <summary>
    /// Implements FindMissingInt
    /// </summary>
    public static class ArrayFindMissingInt1Complete
    {
        /// <summary>
        /// Finds the first missing int in the specified file.
        /// </summary>
        /// <param name="fileName">The file.</param>
        /// <param name="bufferSizeAvailableBytes">The max size of the buffer in bytes.</param>
        /// <param name="minValue">The minimum value allowed in the file.</param>
        /// <param name="maxValue">The maximum value allowed in the file.</param>
        /// <returns>The first missing int or -1 if no int in the range is missing.</returns>
        public static int FindMissingInt(string fileName, int bufferSizeAvailableBytes, int minValue = 0, int maxValue = int.MaxValue)
        {
            // Get count of values (This must be a long to avoid overflow).
            long valueCount = (long)maxValue - minValue + 1;

            // Determine if we need to check only partial bits on the last byte.
            int checkPartialBits = (int)(valueCount % 8);

            // Determine the size of the byte array needed to represent these values.
            var bufferSizeBytes = (valueCount / 8) + (checkPartialBits != 0 ? 1 : 0);

            // For this case, we must have enough buffer space for all possible values.
            if (bufferSizeBytes > bufferSizeAvailableBytes)
                throw new ArgumentException($"Buffer not large enough. A buffer of {bufferSizeBytes} bytes is required.");

            // Initialize the byte array.
            // Note that we would like to use a BitArray, unfortunately we need to support int.MaxValue + 1 entries and a
            // bit array only supports int.MaxValue.
            var values = new byte[bufferSizeBytes];

            // Get the file size.
            long fileSizeInts = new FileInfo(fileName).Length / 4;

            // Read the file and update the byte array.
            using (var br = new BinaryReader(File.Open(fileName, FileMode.Open)))
            {
                for (long i = 0; i < fileSizeInts; i++)
                {
                    // Read the value.
                    int value = br.ReadInt32();

                    // Set the appropriate bit to 1.
                    values[value / 8] |= (byte)(1 << (value % 8));
                }
            }

            // Find first missing & return.
            for (int i = 0; i < values.Length; i++)
            {
                // Determine the bits to check for this value.
                var bitMax = 8;
                if (i == values.Length - 1)
                {
                    if (checkPartialBits != 0)
                        bitMax = checkPartialBits;
                }

                // Check them.
                for (int j = 0; j < bitMax; j++)
                {
                    // Check if the appropriate bit is set, if not return the
                    // corresponding value.
                    if ((values[i] & (1 << j)) == 0)
                        return (i * 8) + j;
                }
            }

            // Not found.
            return -1;
        }
    }
}
