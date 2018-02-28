using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodingProblems.IsUnique.String
{
    /// <summary>
    /// Test class for IsUnique.
    /// </summary>
    [TestClass]
    public class IsUniqueString5BitArrayCompleteTests
    {
        /// <summary>
        /// Tests IsUnique with a null string.
        /// </summary>
        [TestMethod]
        public void IsUniqueString5BitArrayCompleteNull()
        {
            Assert.IsTrue(IsUniqueString5BitArrayComplete.IsUnique(null));
        }

        /// <summary>
        /// Tests IsUnique with an empty string.
        /// </summary>
        [TestMethod]
        public void IsUniqueString5BitArrayCompleteEmpty()
        {
            Assert.IsTrue(IsUniqueString5BitArrayComplete.IsUnique(string.Empty));
        }

        /// <summary>
        /// Tests IsUnique with a single character string.
        /// </summary>
        [TestMethod]
        public void IsUniqueString5BitArrayCompleteSingleChar()
        {
            Assert.IsTrue(IsUniqueString5BitArrayComplete.IsUnique("a"));
        }

        /// <summary>
        /// Tests IsUnique with a two character string.
        /// </summary>
        [TestMethod]
        public void IsUniqueString5BitArrayComplete2CharsUnique()
        {
            Assert.IsTrue(IsUniqueString5BitArrayComplete.IsUnique("ab"));
        }

        /// <summary>
        /// Tests IsUnique with a three character string.
        /// </summary>
        [TestMethod]
        public void IsUniqueString5BitArrayComplete3CharsUnique()
        {
            Assert.IsTrue(IsUniqueString5BitArrayComplete.IsUnique("abc"));
        }

        /// <summary>
        /// Tests IsUnique with a three character string with a repeating character.
        /// </summary>
        [TestMethod]
        public void IsUniqueString5BitArrayComplete3CharsNonUnique()
        {
            Assert.IsFalse(IsUniqueString5BitArrayComplete.IsUnique("aba"));
        }

        /// <summary>
        /// Tests IsUnique with a string that is bigger than 8K.
        /// </summary>
        [TestMethod]
        public void IsUniqueString5BitArrayCompleteMaxChars()
        {
            // Determine max # of chars.
            // (64K)
            int maxChars = (int)Math.Pow(2, sizeof(char) * 8);

            // Build a string bigger than it.
            Assert.IsFalse(IsUniqueString5BitArrayComplete.IsUnique(new string('a', maxChars + 1)));
        }
    }
}
