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

        /// <summary>
        /// Test FileHelpers.WriteFileOfInts with a randomly generated file name.
        /// </summary>
        [TestMethod]
        public void TestWriteFileOfIntsSmallDefaultFileName()
        {
            TestWriteFileOfIntsHelper(10, 0, 9, null, null);
        }

        /// <summary>
        /// Test FileHelpers.WriteFileOfInts with a manually specified file name.
        /// </summary>
        [TestMethod]
        public void TestWriteFileOfIntsSmallSpecifyFileName()
        {
            // Build file name.
            var fileName = Path.GetTempFileName();
            TestWriteFileOfIntsHelper(10, 0, 9, null, fileName);
        }

        /// <summary>
        /// Test FileHelpers.WriteFileOfInts with a custom minValue and maxValue and a file size larger than the maxValue.
        /// </summary>
        [TestMethod]
        public void TestWriteFileOfIntsSmallDoubleSize()
        {
            TestWriteFileOfIntsHelper(25, 1, 9, null, null);
        }

        /// <summary>
        /// Test FileHelpers.WriteFileOfInts with an exclusion value.
        /// </summary>
        [TestMethod]
        public void TestWriteFileOfIntsSmallWithExclusionValue()
        {
            TestWriteFileOfIntsHelper(25, 1, 9, 5, null);
        }

        /// <summary>
        /// Test FileHelpers.WriteFileOfInts with a file size of ~ 1GB.
        /// </summary>
        [TestMethod]
        public void TestWriteFileOfIntsLargeSize()
        {
            TestWriteFileOfIntsHelper(int.MaxValue / 8, 0, int.MaxValue, null, null);
        }

        /// <summary>
        /// Test FileHelpers.WriteFileOfInts with a file size of ~ 1GB and an exclusion value.
        /// </summary>
        [TestMethod]
        public void TestWriteFileOfIntsLargeSizeWithExclusionValue()
        {
            TestWriteFileOfIntsHelper(int.MaxValue / 8, 0, int.MaxValue, 234567, null);
        }

        /// <summary>
        /// Helper for testing WriteFileOfInts
        /// </summary>
        /// <param name="fileSizeInts">fileSize</param>
        /// <param name="minValue">Minimum value</param>
        /// <param name="maxValue">Maximum value</param>
        /// <param name="exclusionValue">The exclusion value</param>
        /// <param name="fileName">The file name</param>
        public void TestWriteFileOfIntsHelper(int fileSizeInts, int minValue, int maxValue, int? exclusionValue, string fileName)
        {
            // Write test data to file.
            fileName = FileHelpers.WriteFileOfInts(fileSizeInts, minValue, maxValue, exclusionValue, fileName);

            // Read the file and check contents.
            using (var br = new BinaryReader(File.Open(fileName, FileMode.Open)))
            {
                // Initialize expected value.
                var valueExpected = 0;

                // Check values in file.
                for (var i = minValue; i < fileSizeInts; i++)
                {
                    // Skip exclusion value.
                    if (exclusionValue == null || exclusionValue != valueExpected)
                    {
                        // Read.
                        int value = br.ReadInt32();

                        // Do test.
                        Assert.AreEqual(valueExpected, value);

                        // Reset to min value.
                        if (valueExpected == maxValue)
                            valueExpected = minValue;
                        else
                            // Update expected value.
                            valueExpected++;
                    }
                    else
                        // Update expected value.
                        valueExpected++;
                }
            }

            // Delete test file.
            File.Delete(fileName);
            Assert.IsFalse(File.Exists(fileName));
        }
    }
}
