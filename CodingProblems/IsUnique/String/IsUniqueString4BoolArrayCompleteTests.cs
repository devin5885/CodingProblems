using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodingProblems.IsUnique.String
{
    /// <summary>
    /// Test class for IsUnique.
    /// </summary>
    [TestClass]
    public class IsUniqueString4BoolArrayCompleteTests
    {
        /// <summary>
        /// Tests IsUnique with a null string.
        /// </summary>
        [TestMethod]
        public void IsUniqueString4BoolArrayCompleteNull()
        {
            Assert.IsTrue(IsUniqueString4BoolArrayComplete.IsUnique(null));
        }

        /// <summary>
        /// Tests IsUnique with an empty string.
        /// </summary>
        [TestMethod]
        public void IsUniqueString4BoolArrayCompleteEmpty()
        {
            Assert.IsTrue(IsUniqueString4BoolArrayComplete.IsUnique(string.Empty));
        }

        /// <summary>
        /// Tests IsUnique with a single character string.
        /// </summary>
        [TestMethod]
        public void IsUniqueString4BoolArrayCompleteSingleChar()
        {
            Assert.IsTrue(IsUniqueString4BoolArrayComplete.IsUnique("a"));
        }

        /// <summary>
        /// Tests IsUnique with a two character string.
        /// </summary>
        [TestMethod]
        public void IsUniqueString4BoolArrayComplete2CharsUnique()
        {
            Assert.IsTrue(IsUniqueString4BoolArrayComplete.IsUnique("ab"));
        }

        /// <summary>
        /// Tests IsUnique with a three character string.
        /// </summary>
        [TestMethod]
        public void IsUniqueString4BoolArrayComplete3CharsUnique()
        {
            Assert.IsTrue(IsUniqueString4BoolArrayComplete.IsUnique("abc"));
        }

        /// <summary>
        /// Tests IsUnique with a three character string with a repeating character.
        /// </summary>
        [TestMethod]
        public void IsUniqueString4BoolArrayComplete3CharsNonUnique()
        {
            Assert.IsFalse(IsUniqueString4BoolArrayComplete.IsUnique("aba"));
        }

        /// <summary>
        /// Tests IsUnique with a string that is bigger than 64K.
        /// </summary>
        [TestMethod]
        public void IsUniqueString4BoolArrayCompleteMaxChars()
        {
            // Determine max # of chars.
            // (64K)
            var maxChars = (int)Math.Pow(2, sizeof(char) * 8);

            // Build a string bigger than it.
            Assert.IsFalse(IsUniqueString4BoolArrayComplete.IsUnique(new string('a', maxChars + 1)));
        }

        // TODO: Build a string with all chars.
    }
}
