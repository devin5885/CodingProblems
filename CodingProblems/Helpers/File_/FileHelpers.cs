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
        /// <param name="bufferSizeMaxInts">The maximum buffer size in integers. (16 MB default)</param>
        /// <param name="minValue">The minimum value to put in the file.</param>
        /// <param name="maxValue">The maximum value to put in the file.</param>
        /// <param name="exclusionValue">The value to be excluded from the file.</param>
        /// <param name="randomize">Whether the randomize the buffer.</param>
        /// <param name="fileName">The file name.</param>
        /// <returns>The resulting file name.</returns>
        public static string WriteFileOfInts(long fileSizeInts, int bufferSizeMaxInts = 1024 * 1024 * 16 / 4, int minValue = 0, int maxValue = int.MaxValue, int? exclusionValue = null, bool randomize = true, string fileName = null)
        {
            // Use temp name if not specified.
            if (string.IsNullOrEmpty(fileName))
                fileName = Path.GetTempFileName();

            // Delete the file.
            File.Delete(fileName);

            // Determine increment information.
            var buffersTotal = (fileSizeInts / bufferSizeMaxInts) + 1;
            var lastBufferSizeInts = (int)(fileSizeInts % bufferSizeMaxInts);

            // Initialize start value.
            var startValue = minValue;

            // Write all increments.
            for (var bufferIndex = 1; bufferIndex <= buffersTotal; bufferIndex++)
            {
                // Get buffer size.
                var bufferSizeInts = bufferIndex == buffersTotal ? lastBufferSizeInts : bufferSizeMaxInts;

                // Skip empty buffer.
                if (bufferSizeInts == 0)
                    continue;

                // Initialize the buffer.
                var buffer = InitBuffer(bufferSizeInts, out var endValue, startValue, minValue, maxValue, exclusionValue, randomize);

                // Write entire buffer.
                AppendBufferToFile(buffer, fileName);

                // Update start value.
                // Note: InitBuffer will handle startValue == maxValue.
                startValue = endValue + 1;
            }

            // Return filename.
            return fileName;
        }

        /// <summary>
        /// Helper that reads an existing file into a buffer.
        /// </summary>
        /// <param name="fileName">The file name.</param>
        /// <param name="offsetInts">The offset in integers.</param>
        /// <param name="bufferSizeMaxInts">The maximum buffer size in integers. (16 MB default)</param>
        /// <returns>The buffer.</returns>
        public static int[] ReadIntBufferFromFile(string fileName, long offsetInts = 0, int bufferSizeMaxInts = 1024 * 1024 * 16 / 4)
        {
            // Get the file size.
            var fileSizeInts = new FileInfo(fileName).Length / 4;

            // Determine buffer size.
            var bufferSizeInts = Math.Min(fileSizeInts - offsetInts, bufferSizeMaxInts);

            // Initialize buffer.
            var buffer = new int[bufferSizeInts];

            // Read the file and check contents.
            using (var binReader = new BinaryReader(File.Open(fileName, FileMode.Open)))
            {
                // Seek if appropriate.
                if (offsetInts > 0)
                    binReader.BaseStream.Seek(offsetInts * 4, SeekOrigin.Begin);

                // Read values in file.
                for (long i = 0; i < bufferSizeInts; i++)
                {
                    // Read.
                    buffer[i] = binReader.ReadInt32();
                }
            }

            // Return buffer.
            return buffer;
        }

        /// <summary>
        /// Helper that creates and initializes a buffer.
        /// </summary>
        /// <param name="bufferSizeInts">The size of the file (in 32-bit integers).</param>
        /// <param name="endValue">The end value is returned via this parameter.</param>
        /// <param name="startValue">The start value.</param>
        /// <param name="minValue">The minimum value to put in the file.</param>
        /// <param name="maxValue">The maximum value to put in the file.</param>
        /// <param name="exclusionValue">The value to be excluded from the file.</param>
        /// <param name="randomize">Whether the randomize the buffer.</param>
        /// <returns>The buffer.</returns>
        private static int[] InitBuffer(int bufferSizeInts, out int endValue, int startValue, int minValue = 0, int maxValue = int.MaxValue - 1, int? exclusionValue = null, bool randomize = true)
        {
            // Initialize randomizer.
            var rnd = new Random();

            // Start at start value.
            var value = startValue;

            // Create buffer.
            var buffer = new int[bufferSizeInts];
            for (var i = 0; i < bufferSizeInts;)
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
                for (var i = 0; i < bufferSizeInts - 1; i++)
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
