using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodingProblems.Array_.FindMatches
{
    [TestClass]
    public class FindMatches1BruteForceCompleteTests
    {
        [TestMethod]
        public void ArrayFindMatches2CompleteTest1()
        {
            var a = new List<int> { 1, 2, 4, 7, 8, 3 };
            var b = new List<int> { 3, 4, 6, 4, 3 };
            var expected = new List<int> { 4, 3 };

            var res = FindMatches1BruteForceComplete.FindMatches(a, b);

            CollectionAssert.AreEqual(expected, res);
        }
    }
}
