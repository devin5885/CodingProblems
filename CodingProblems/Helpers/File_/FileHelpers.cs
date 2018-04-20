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

            // Delete the file.
            File.Delete(fileName);

            // Write buffer.
            AppendBufferToFile(buffer, fileName);

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
            // Use temp name if not specified.
            if (string.IsNullOrEmpty(fileName))
                fileName = Path.GetTempFileName();

            // Delete the file.
            File.Delete(fileName);

            // Determine increment information.
            var incrementSizeMax = 1024 * 1024 * 16; // Write in 16 MB increments.
            var incrementsTotal = (fileSizeInts / incrementSizeMax) + 1;
            var lastIncrementSize = fileSizeInts % incrementSizeMax;

            // Write all increments.
            for (var incrementIndex = 1; incrementIndex <= incrementsTotal; incrementIndex++)
            {
                // Initialize the buffer.
                var buffer = InitBuffer(incrementIndex == incrementsTotal ? lastIncrementSize : incrementSizeMax, out int endValue, minValue, maxValue, exclusionValue, randomize);

                // Update start value.
                minValue = endValue + 1;

                // Make sure we didn't cross.
                if (minValue > maxValue)
                    minValue = 0;

                // Write entire buffer.
                AppendBufferToFile(buffer, fileName);
            }

            // Return filename.
            return fileName;
        }

        /// <summary>
        /// Helper that creates and initializes a buffer.
        /// </summary>
        /// <param name="bufferSizeInts">The size of the file (in 32-bit integers).</param>
        /// <param name="endValue">The end value is returned via this parameter.</param>
        /// <param name="minValue">The minimum value to put in the file.</param>
        /// <param name="maxValue">The maximum value to put in the file.</param>
        /// <param name="exclusionValue">The value to be excluded from the file.</param>
        /// <param name="randomize">Whether the randomize the buffer.</param>
        /// <returns>The buffer.</returns>
        private static int[] InitBuffer(int bufferSizeInts, out int endValue, int minValue = 0, int maxValue = int.MaxValue - 1, int? exclusionValue = null, bool randomize = true)
        {
            // Initialize randomizer.
            var rnd = new Random();

            // Start at minimum value.
            int value = minValue;

            // Create buffer.
            var buffer = new int[bufferSizeInts];
            for (int i = 0; i < bufferSizeInts;)
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
                for (int i = 0; i < bufferSizeInts - 1; i++)
                {
                    // Find the index to swap.
                    var rndIndex = rnd.Next(i + 1, bufferSizeInts - 1);

                    // Swap the values.
                    var temp = buffer[i];
                    buffer[i] = buffer[rndIndex];
                    buffer[rndIndex] = temp;
                }

            endValue = value - 1;
            return buffer;
        }

        /// <summary>
        /// Helper that appends a buffer to an existing file.
        /// </summary>
        /// <param name="buffer">The buffer.</param>
        /// <param name="fileName">The file name.</param>
        private static void AppendBufferToFile(int[] buffer, string fileName)
        {
            using (var binWriter = new BinaryWriter(File.Open(fileName, FileMode.Append)))
            {
                foreach (var value in buffer)
                    binWriter.Write(value);
            }
        }
    }
}
