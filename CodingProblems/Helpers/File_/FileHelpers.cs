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
    }
}
