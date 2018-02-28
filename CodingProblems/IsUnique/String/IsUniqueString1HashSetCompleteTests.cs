using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodingProblems.IsUnique.String
{
    /// <summary>
    /// Test class for IsUnique.
    /// </summary>
    [TestClass]
    public class IsUniqueString1HashSetCompleteTests
    {
        /// <summary>
        /// Tests IsUnique with a null string.
        /// </summary>
        [TestMethod]
        public void IsUniqueString1HashSetCompleteNull()
        {
            Assert.IsTrue(IsUniqueString1HashSetComplete.IsUnique(null));
        }

        /// <summary>
        /// Tests IsUnique with an empty string.
        /// </summary>
        [TestMethod]
        public void IsUniqueString1HashSetCompleteEmpty()
        {
            Assert.IsTrue(IsUniqueString1HashSetComplete.IsUnique(string.Empty));
        }

        /// <summary>
        /// Tests IsUnique with a single character string.
        /// </summary>
        [TestMethod]
        public void IsUniqueString1HashSetCompleteSingleChar()
        {
            Assert.IsTrue(IsUniqueString1HashSetComplete.IsUnique("a"));
        }

        /// <summary>
        /// Tests IsUnique with a two character string.
        /// </summary>
        [TestMethod]
        public void IsUniqueString1HashSetComplete2CharsUnique()
        {
            Assert.IsTrue(IsUniqueString1HashSetComplete.IsUnique("ab"));
        }

        /// <summary>
        /// Tests IsUnique with a three character string.
        /// </summary>
        [TestMethod]
        public void IsUniqueString1HashSetComplete3CharsUnique()
        {
            Assert.IsTrue(IsUniqueString1HashSetComplete.IsUnique("abc"));
        }

        /// <summary>
        /// Tests IsUnique with a three character string with a repeating character.
        /// </summary>
        [TestMethod]
        public void IsUniqueString1HashSetComplete3CharsNonUnique()
        {
            Assert.IsFalse(IsUniqueString1HashSetComplete.IsUnique("aba"));
        }
    }
}
