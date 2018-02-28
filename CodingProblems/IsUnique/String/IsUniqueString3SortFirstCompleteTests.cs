using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodingProblems.IsUnique.String
{
    /// <summary>
    /// Test class for IsUnique.
    /// </summary>
    [TestClass]
    public class IsUniqueString3SortFirstCompleteTests
    {
        /// <summary>
        /// Tests IsUnique with a null string.
        /// </summary>
        [TestMethod]
        public void IsUniqueString3SortFirstCompleteNull()
        {
            Assert.IsTrue(IsUniqueString3SortFirstComplete.IsUnique(null));
        }

        /// <summary>
        /// Tests IsUnique with an empty string.
        /// </summary>
        [TestMethod]
        public void IsUniqueString3SortFirstCompleteEmpty()
        {
            Assert.IsTrue(IsUniqueString3SortFirstComplete.IsUnique(string.Empty));
        }

        /// <summary>
        /// Tests IsUnique with a single character string.
        /// </summary>
        [TestMethod]
        public void IsUniqueString3SortFirstCompleteSingleChar()
        {
            Assert.IsTrue(IsUniqueString3SortFirstComplete.IsUnique("a"));
        }

        /// <summary>
        /// Tests IsUnique with a two character string.
        /// </summary>
        [TestMethod]
        public void IsUniqueString3SortFirstComplete2CharsUnique()
        {
            Assert.IsTrue(IsUniqueString3SortFirstComplete.IsUnique("ab"));
        }

        /// <summary>
        /// Tests IsUnique with a three character string.
        /// </summary>
        [TestMethod]
        public void IsUniqueString3SortFirstComplete3CharsUnique()
        {
            Assert.IsTrue(IsUniqueString3SortFirstComplete.IsUnique("abc"));
        }

        /// <summary>
        /// Tests IsUnique with a three character string with a repeating character.
        /// </summary>
        [TestMethod]
        public void IsUniqueString3SortFirstComplete3CharsNonUnique()
        {
            Assert.IsFalse(IsUniqueString3SortFirstComplete.IsUnique("aba"));
        }
    }
}
