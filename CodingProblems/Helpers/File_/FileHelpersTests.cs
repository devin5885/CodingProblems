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
        public void TestWriteFileFromBufferDefaultFileName()
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
        public void TestWriteFileFromBufferSpecifyFileName()
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

        /// <summary>
        /// Test FileHelpers.WriteFileOfInts with a randomly generated file name.
        /// </summary>
        [TestMethod]
        public void TestWriteFileOfIntsVerySmallDefaultFileName()
        {
            TestWriteFileOfIntsHelper(10, 0, 9, null, false, null, 4);
        }

        /// <summary>
        /// Test FileHelpers.WriteFileOfInts with a manually specified file name.
        /// </summary>
        [TestMethod]
        public void TestWriteFileOfIntsVerySmallSpecifyFileName()
        {
            // Build file name.
            var fileName = Path.GetTempFileName();
            TestWriteFileOfIntsHelper(10, 0, 9, null, false, fileName, 4);
        }

        /// <summary>
        /// Test FileHelpers.WriteFileOfInts with a custom minValue and maxValue and a file size larger than the maxValue.
        /// </summary>
        [TestMethod]
        public void TestWriteFileOfIntsSmall()
        {
            TestWriteFileOfIntsHelper(50, 0, 8, null, false, null, 4);
        }

        /// <summary>
        /// Test FileHelpers.WriteFileOfInts with a custom minValue and maxValue and randomization.
        /// </summary>
        [TestMethod]
        public void TestWriteFileOfIntsSmallRandomize()
        {
            TestWriteFileOfIntsHelper(50, 1, 9, null, true, null, 4);
        }

        /// <summary>
        /// Test FileHelpers.WriteFileOfInts with an exclusion value.
        /// </summary>
        [TestMethod]
        public void TestWriteFileOfIntsSmallWithExclusionValue()
        {
            for (int exclusionValue = 0;  exclusionValue < 10; exclusionValue++)
                TestWriteFileOfIntsHelper(50, 1, 9, exclusionValue, false, null, 4);
        }

        /// <summary>
        /// Test FileHelpers.WriteFileOfInts with a file size of ~ 1GB.
        /// </summary>
        [TestMethod]
        public void TestWriteFileOfIntsLarge()
        {
            var bufferSizeMaxInts = 1024 * 1024 * 16 / 4; // 16 GB buffer.
            TestWriteFileOfIntsHelper(int.MaxValue / 8, 0, int.MaxValue, null, false, null, bufferSizeMaxInts);
        }

        /// <summary>
        /// Test FileHelpers.WriteFileOfInts with a file size of ~ 1GB and randomization.
        /// </summary>
        [TestMethod]
        public void TestWriteFileOfIntsLargeRandomize()
        {
            var bufferSizeMaxInts = 1024 * 1024 * 16 / 4; // 16 GB buffer.
            TestWriteFileOfIntsHelper(int.MaxValue / 8, 0, int.MaxValue, null, true, null, bufferSizeMaxInts);
        }

        /// <summary>
        /// Test FileHelpers.WriteFileOfInts with a file size of ~ 1GB and an exclusion value.
        /// </summary>
        [TestMethod]
        public void TestWriteFileOfIntsLargeWithExclusionValue()
        {
            var bufferSizeMaxInts = 1024 * 1024 * 16 / 4; // 16 GB buffer.
            TestWriteFileOfIntsHelper(int.MaxValue / 8, 0, int.MaxValue, 234567, false, null, bufferSizeMaxInts);
        }

        /// <summary>
        /// Test FileHelpers.WriteFileOfInts with a file size of ~ 4 GB.
        /// </summary>
        [TestMethod]
        public void TestWriteFileOfIntsVeryLarge()
        {
            var fileSizeInts = 1024 * 1024 * 1024; // 4 GB (~ 1 billion integers).
            var bufferSizeMaxInts = 1024 * 1024 * 16 / 4; // 16 GB buffer.
            TestWriteFileOfIntsHelper(fileSizeInts, 0, int.MaxValue, null, false, null, bufferSizeMaxInts);
        }

        /// <summary>
        /// Test FileHelpers.WriteFileOfInts with a file size of ~ 16 GB.
        /// </summary>
        [TestMethod]
        public void TestWriteFileOfIntsVeryVeryLarge()
        {
            long fileSizeInts = 1024L * 1024 * 1024 * 4; // 16 GB (~ 4 billion integers).
            var bufferSizeMaxInts = 1024 * 1024 * 16 / 4; // 16 GB buffer.
            TestWriteFileOfIntsHelper(fileSizeInts, 0, int.MaxValue, null, false, null, bufferSizeMaxInts);
        }

        /// <summary>
        /// Helper for testing WriteFileOfInts
        /// </summary>
        /// <param name="fileSizeInts">fileSize</param>
        /// <param name="minValue">Minimum value</param>
        /// <param name="maxValue">Maximum value</param>
        /// <param name="exclusionValue">The exclusion value</param>
        /// <param name="randomize">Whether to randomize.</param>
        /// <param name="fileName">The file name</param>
        /// <param name="bufferSizeMaxInts">The maximum buffer size in integers</param>
        public void TestWriteFileOfIntsHelper(long fileSizeInts, int minValue, int maxValue, int? exclusionValue, bool randomize, string fileName, int bufferSizeMaxInts)
        {
            // Write test data to file.
            fileName = FileHelpers.WriteFileOfInts(fileSizeInts, bufferSizeMaxInts, minValue, maxValue, exclusionValue, randomize, fileName);

            // Check the file size.
            Assert.AreEqual(fileSizeInts * 4, new FileInfo(fileName).Length);

            // Store start value.
            var startValue = minValue;

            // For randomized file we can't check this.
            if (!randomize)
            {
                // Initialize expected value.
                var valueExpected = startValue;
                long offset = 0;

                for (var fileSizeLeftInts = fileSizeInts; fileSizeLeftInts > 0;)
                {
                    // Read the file.
                    var buffer = FileHelpers.ReadIntBufferFromFile(fileName, offset, bufferSizeMaxInts);

                    // Subtract this part.
                    fileSizeLeftInts -= buffer.Length;

                    // Check values in buffer.
                    for (long i = 0; i < buffer.Length;)
                    {
                        // Skip exclusion value.
                        if (exclusionValue == null || exclusionValue != valueExpected)
                        {
                            // Do test.
                            Assert.AreEqual(valueExpected, buffer[i++]);
                        }

                        // Reset to min value.
                        if (valueExpected == maxValue)
                            valueExpected = startValue;
                        else
                            // Update expected value.
                            valueExpected++;
                    }

                    // Update the offset.
                    offset += buffer.Length;
                }
            }

            // Delete test file.
            File.Delete(fileName);
            Assert.IsFalse(File.Exists(fileName));
        }
    }
}
