using System;
using System.IO;
using CodingProblems.Helpers.File_;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodingProblems.Array_.MissingInt
{
    // ReSharper disable HeuristicUnreachableCode

    /// <summary>
    /// This class tests ArrayFindMissingInt1Complete
    /// </summary>
    [TestClass]
    public class ArrayFindMissingInt1CompleteTests
    {
        /// <summary>
        /// Test large file case (16 GB file)
        /// Note: This is the case specified by CtCI.
        /// </summary>
        [TestMethod]
        public void TestFindMissingIntMissingFoundVeryLargeFile()
        {
            // Warning: Running this test will create a 16 GB file on your system during the test.
            // Disable the next line to enable the test.
            Assert.Inconclusive();

            // Warning: Enabling this line will create a 16 GB file.
            const long fileSizeInts = 1024L * 1024 * 1024 * 4; // 16 GB (~4 billion integers)

            // Initialize test values.
            const int exclusionNumber = 15465;
            const int bufferSizeBytes = 1024 * 1024 * 1024; // Maximum 1 GB of space.

            // Write the file.
            var fileName = FileHelpers.WriteFileOfInts(fileSizeInts, exclusionValue: exclusionNumber, fileName: @"C:\Temp\VeryLarge.bin");

            // Do test.
            try
            {
                Assert.AreEqual(exclusionNumber, ArrayFindMissingInt1Complete.FindMissingInt(fileName, bufferSizeBytes));
            }
            finally
            {
                // Delete the file.
                File.Delete(fileName);
            }
        }

        /// <summary>
        /// Test simple case with a missing int and buffer matches range, and the # of values % 8 = 0.
        /// </summary>
        [TestMethod]
        public void TestFindMissingIntMissingFoundBufferMatchEvenBytes()
        {
            // Initialize test data.
            var test = new[] { 0, 2, 3, 7, 6, 4, 1, 1 };

            // Write the file.
            var fileName = FileHelpers.WriteFileFromBuffer(test);

            // Do test.
            Assert.AreEqual(5, ArrayFindMissingInt1Complete.FindMissingInt(fileName, 1, 0, 7));

            // Delete the file.
            File.Delete(fileName);
        }

        /// <summary>
        /// Test simple case with a missing int and buffer is larger than range, and the # of values % 8 = 0.
        /// </summary>
        [TestMethod]
        public void TestFindMissingIntMissingFoundBufferLargerEvenBytes()
        {
            // Initialize test data.
            var test = new[] { 0, 2, 3, 7, 6, 4, 1, 1 };

            // Write the file.
            var fileName = FileHelpers.WriteFileFromBuffer(test);

            // Do test.
            Assert.AreEqual(5, ArrayFindMissingInt1Complete.FindMissingInt(fileName, 2, 0, 7));

            // Delete the file.
            File.Delete(fileName);
        }

        /// <summary>
        /// Test simple case with no missing int and buffer matches range, and the # of values % 8 = 0.
        /// </summary>
        [TestMethod]
        public void TestFindMissingIntMissingNotFoundBufferMatchEvenBytes()
        {
            // Initialize test data.
            var test = new[] { 0, 2, 3, 7, 6, 4, 1, 5 };

            // Write the file.
            var fileName = FileHelpers.WriteFileFromBuffer(test);

            // Do test.
            Assert.AreEqual(-1, ArrayFindMissingInt1Complete.FindMissingInt(fileName, 1, 0, 7));

            // Delete the file.
            File.Delete(fileName);
        }

        /// <summary>
        /// Test simple case with no missing int and buffer matches range, and the # of values % 8 != 0.
        /// </summary>
        [TestMethod]
        public void TestFindMissingIntMissingNotFoundBufferMatchNonEvenBytes()
        {
            // Initialize test data.
            var test = new[] { 0, 2, 3, 7, 6, 4, 1, 5, 8, 9 };

            // Write the file.
            var fileName = FileHelpers.WriteFileFromBuffer(test);

            // Do test.
            Assert.AreEqual(-1, ArrayFindMissingInt1Complete.FindMissingInt(fileName, 2, 0, 9));

            // Delete the file.
            File.Delete(fileName);
        }

        /// <summary>
        /// Test simple case with no missing int and buffer is larger than range, and the # of values % 8 = 0.
        /// </summary>
        [TestMethod]
        public void TestFindMissingIntMissingNotFoundBufferLargerEvenBytes()
        {
            // Initialize test data.
            var test = new[] { 0, 2, 3, 7, 6, 4, 1, 5 };

            // Write the file.
            var fileName = FileHelpers.WriteFileFromBuffer(test);

            // Do test.
            Assert.AreEqual(-1, ArrayFindMissingInt1Complete.FindMissingInt(fileName, 2, 0, 7));

            // Delete the file.
            File.Delete(fileName);
        }

        /// <summary>
        /// Test case where the buffer is too small.
        /// </summary>
        [TestMethod]
        public void TestFindMissingIntErrorBufferTooSmall()
        {
            // Initialize test data.
            var test = new[] { 0, 2, 3, 7, 6, 4, 1, 5, 8, 9 };

            // Write the file.
            var fileName = FileHelpers.WriteFileFromBuffer(test);

            // Do test.
            try
            {
                ArrayFindMissingInt1Complete.FindMissingInt(fileName, 1, 0, 9);
            }
            catch (ArgumentException)
            {
                Assert.IsTrue(true);
                return;
            }
            finally
            {
                // Delete the file.
                File.Delete(fileName);
            }

            Assert.Fail();
        }

        /// <summary>
        /// Test medium file case. (4MB file)
        /// </summary>
        [TestMethod]
        public void TestFindMissingIntMissingFoundMediumFile()
        {
            // Initialize test values.
            const int exclusionNumber = 15465;
            const int fileSizeInts = 1024 * 1024 * 4; // 16 MB (~ 4 million integers).
            const int bufferSizeBytes = 1024 * 1024; // 1 MB

            // Write the file.
            var fileName = FileHelpers.WriteFileOfInts(fileSizeInts, exclusionValue: exclusionNumber, maxValue: int.MaxValue / 1024);

            // Do test.
            Assert.AreEqual(exclusionNumber, ArrayFindMissingInt1Complete.FindMissingInt(fileName, bufferSizeBytes, 0, int.MaxValue / 1024));

            // Delete the file.
            File.Delete(fileName);
        }

        /// <summary>
        /// Test medium file case with no missing value. (4MB file)
        /// </summary>
        [TestMethod]
        public void TestFindMissingIntMissingNotFoundMediumFile()
        {
            // Initialize test values.
            const int fileSizeInts = 1024 * 1024 * 4; // 16 MB (~ 4 million integers).
            const int bufferSizeBytes = 1024 * 1024; // 1 MB

            // Write the file.
            var fileName = FileHelpers.WriteFileOfInts(fileSizeInts, maxValue: int.MaxValue / 1024);

            // Do test.
            Assert.AreEqual(-1, ArrayFindMissingInt1Complete.FindMissingInt(fileName, bufferSizeBytes, 0, int.MaxValue / 1024));

            // Delete the file.
            File.Delete(fileName);
        }

        /// <summary>
        /// Test large file case (4GB file)
        /// </summary>
        [TestMethod]
        public void TestFindMissingIntMissingFoundLargeFile()
        {
            // Warning: Running this test will create a 4 GB file on your system during the test.
            // Disable the next line to enable the test.
            Assert.Inconclusive();

            // Initialize file size.
            // This is larger than the maximum number of possible positive integers so is a reasonable
            // test of a large file.
            const long fileSizeInts = 1024 * 1024 * 1024; // 4 GB (~1 billion integers)

            // Initialize test values.
            const int exclusionNumber = 15465;
            const int bufferSizeBytes = 1024 * 1024 * 1024; // Maximum 1 GB of space.

            // Write the file.
            var fileName = FileHelpers.WriteFileOfInts(fileSizeInts, exclusionValue: exclusionNumber);

            // Do test.
            try
            {
                Assert.AreEqual(exclusionNumber, ArrayFindMissingInt1Complete.FindMissingInt(fileName, bufferSizeBytes));
            }
            finally
            {
                // Delete the file.
                File.Delete(fileName);
            }
        }
    }
}