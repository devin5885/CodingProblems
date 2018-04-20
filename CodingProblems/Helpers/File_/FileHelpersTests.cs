using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodingProblems.Helpers.File_
{
    /// <summary>
    /// Tests for FileHelpers
    /// </summary>
    [TestClass]
    public class FileHelpersTests
    {
        /// <summary>
        /// Test FileHelpers.WriteFileFromBuffer with a randomly generated file name.
        /// </summary>
        [TestMethod]
        public void TestWriteFileFromBufferSimpleDefaultFileName()
        {
            // Initialize test data.
            var size = 11;
            var buffer = new int[size];
            for (var i = 0; i < size; i++)
                buffer[i] = i;

            // Write test data to file.
            var fileName = FileHelpers.WriteFileFromBuffer(buffer);

            // Read the file and check contents.
            using (var br = new BinaryReader(File.Open(fileName, FileMode.Open)))
            {
                for (var i = 0; i < size; i++)
                {
                    int value = br.ReadInt32();
                    Assert.AreEqual(i, value);
                }
            }

            // Delete test file.
            File.Delete(fileName);
            Assert.IsFalse(File.Exists(fileName));
        }

        /// <summary>
        /// Test FileHelpers.WriteFileFromBuffer with a file name specified.
        /// </summary>
        [TestMethod]
        public void TestWriteFileFromBufferSimpleSpecifyFileName()
        {
            // Initialize test data.
            var size = 11;
            var buffer = new int[size];
            for (var i = 0; i < size; i++)
                buffer[i] = i;

            // Build file name.
            var fileName = Path.GetTempFileName();

            // Write test data to file.
            FileHelpers.WriteFileFromBuffer(buffer, fileName);

            // Read the file and check contents.
            using (var br = new BinaryReader(File.Open(fileName, FileMode.Open)))
            {
                for (var i = 0; i < size; i++)
                {
                    int value = br.ReadInt32();
                    Assert.AreEqual(i, value);
                }
            }

            // Delete test file.
            File.Delete(fileName);
            Assert.IsFalse(File.Exists(fileName));
        }
    }
}
