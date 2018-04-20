using System;
using System.IO;

namespace CodingProblems.Helpers.File_
{
    /// <summary>
    /// File helpers.
    /// </summary>
    internal static class FileHelpers
    {
        /// <summary>
        /// Writes the specified buffer to the specified file.
        /// </summary>
        /// <param name="buffer">The buffer to write.</param>
        /// <param name="fileName">The filename (and path)</param>
        /// <returns>The resulting file name (and path)</returns>
        public static string WriteFileFromBuffer(int[] buffer, string fileName = null)
        {
            // Use temp name if not specified.
            if (string.IsNullOrEmpty(fileName))
                fileName = Path.GetTempFileName();

            // Write buffer.
            using (var binWriter = new BinaryWriter(File.Open(fileName, FileMode.Create)))
            {
                foreach (var value in buffer)
                    binWriter.Write(value);
            }

            // Return result.
            return fileName;
        }

        /// <summary>
        /// Writes a file of integers with a maximum size of int.Max - 1.
        /// </summary>
        /// <param name="fileSizeInts">The size of the file (in 32-bit integers).</param>
        /// <param name="minValue">The minimum value to put in the file.</param>
        /// <param name="maxValue">The maximum value to put in the file.</param>
        /// <param name="exclusionValue">The value to be excluded from the file.</param>
        /// <param name="randomize">Whether the randomize the buffer.</param>
        /// <param name="fileName">The file name.</param>
        /// <returns>The resulting file name.</returns>
        public static string WriteFileOfInts(int fileSizeInts, int minValue = 0, int maxValue = int.MaxValue - 1, int? exclusionValue = null, bool randomize = true, string fileName = null)
        {
            // Initialize randomizer.
            var rnd = new Random();

            // Use temp name if not specified.
            if (string.IsNullOrEmpty(fileName))
                fileName = Path.GetTempFileName();

            // Start at minimum value.
            int value = minValue;

            // Create buffer.
            var buffer = new int[fileSizeInts];
            for (int i = minValue; i < fileSizeInts;)
            {
                // Write to buffer.
                if (exclusionValue == null || exclusionValue != value)
                    buffer[i++] = value;

                // Keep updating start value to get values throughout the range but
                // don't go over the maximum value.
                if (value == maxValue)
                    value = minValue;
                else
                    value++;
            }

            // Randomize the buffer.
            if (randomize)
                for (int i = 0; i < fileSizeInts - 1; i++)
                {
                    // Find the index to swap.
                    var rndIndex = rnd.Next(i + 1, fileSizeInts - 1);

                    // Swap the values.
                    var temp = buffer[i];
                    buffer[i] = buffer[rndIndex];
                    buffer[rndIndex] = temp;
                }

            // Write entire buffer.
            using (BinaryWriter binWriter = new BinaryWriter(File.Open(fileName, FileMode.Create)))
            {
                for (int i = 0; i < buffer.Length; i++)
                    binWriter.Write(buffer[i]);
            }

            // Return file name.
            return fileName;
        }
    }
}
