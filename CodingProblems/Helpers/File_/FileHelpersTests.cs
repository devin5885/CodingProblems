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
        public void TestWriteFileOfIntsDefaultFileName()
        {
            // Write test data to file.
            var size = 10;
            var fileName = FileHelpers.WriteFileOfInts(size, 0, 9);

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
        /// Test FileHelpers.WriteFileOfInts with a manually specified file name.
        /// </summary>
        [TestMethod]
        public void TestWriteFileOfIntsSpecifyFileName()
        {
            // Build file name.
            var fileName = Path.GetTempFileName();

            // Write test data to file.
            var size = 10;
            FileHelpers.WriteFileOfInts(size, 0, 9, fileName);

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
        /// Test FileHelpers.WriteFileOfInts with a custom minValue and maxValue and a file size larger than the maxValue.
        /// </summary>
        [TestMethod]
        public void TestWriteFileOfIntsDoubleSize()
        {
            TestWriteFileOfIntsHelper(25, 1, 9);
        }

        /// <summary>
        /// Test FileHelpers.WriteFileOfInts with a file size of ~ 1GB.
        /// </summary>
        [TestMethod]
        public void TestWriteFileOfIntsLargeSize()
        {
            TestWriteFileOfIntsHelper(int.MaxValue / 8, 0, int.MaxValue);
        }

        /// <summary>
        /// Helper for testing WriteFileOfInts
        /// </summary>
        /// <param name="fileSizeInts">fileSize</param>
        /// <param name="minValue">Minimum value</param>
        /// <param name="maxValue">Maximum value</param>
        public void TestWriteFileOfIntsHelper(int fileSizeInts, int minValue, int maxValue)
        {
            // Write test data to file.
            var fileName = FileHelpers.WriteFileOfInts(fileSizeInts, minValue, maxValue);

            // Read the file and check contents.
            using (var br = new BinaryReader(File.Open(fileName, FileMode.Open)))
            {
                // Initialize expected value.
                var valueExpected = 0;

                // Check values in file.
                for (var i = minValue; i < fileSizeInts; i++)
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
            }

            // Delete test file.
            File.Delete(fileName);
            Assert.IsFalse(File.Exists(fileName));
        }
    }
}
