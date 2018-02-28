using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodingProblems.IsUnique.String
{
    /// <summary>
    /// Test class for IsUnique.
    /// </summary>
    [TestClass]
    public class IsUniqueString2NoAdditionalDSCompleteTests
    {
        /// <summary>
        /// Tests IsUnique with a null string.
        /// </summary>
        [TestMethod]
        public void IsUniqueString2NoAdditionalCompleteNull()
        {
            Assert.IsTrue(IsUniqueString2NoAdditionalDSComplete.IsUnique(null));
        }

        /// <summary>
        /// Tests IsUnique with an empty string.
        /// </summary>
        [TestMethod]
        public void IsUniqueString2NoAdditionalCompleteEmpty()
        {
            Assert.IsTrue(IsUniqueString2NoAdditionalDSComplete.IsUnique(string.Empty));
        }

        /// <summary>
        /// Tests IsUnique with a single character string.
        /// </summary>
        [TestMethod]
        public void IsUniqueString2NoAdditionalCompleteSingleChar()
        {
            Assert.IsTrue(IsUniqueString2NoAdditionalDSComplete.IsUnique("a"));
        }

        /// <summary>
        /// Tests IsUnique with a two character string.
        /// </summary>
        [TestMethod]
        public void IsUniqueString2NoAdditionalComplete2CharsUnique()
        {
            Assert.IsTrue(IsUniqueString2NoAdditionalDSComplete.IsUnique("ab"));
        }

        /// <summary>
        /// Tests IsUnique with a three character string.
        /// </summary>
        [TestMethod]
        public void IsUniqueString2NoAdditionalComplete3CharsUnique()
        {
            Assert.IsTrue(IsUniqueString2NoAdditionalDSComplete.IsUnique("abc"));
        }

        /// <summary>
        /// Tests IsUnique with a three character string with a repeating character.
        /// </summary>
        [TestMethod]
        public void IsUniqueString2NoAdditionalComplete3CharsNonUnique()
        {
            Assert.IsFalse(IsUniqueString2NoAdditionalDSComplete.IsUnique("aba"));
        }
    }
}
