using System;
using System.Collections.Generic;
using System.Reflection;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodingProblems.BinaryTree.Node
{
    /// <summary>
    ///  Attribute for traversal test data.
    /// </summary>
    public class BinaryTreeDataSourceAttribute : Attribute, ITestDataSource
    {
        /// <summary>
        /// Gets the test data for tree related tests.
        /// </summary>
        /// <param name="methodInfo">The method Info.</param>
        /// <returns>The test data.</returns>
        public IEnumerable<object[]> GetData(MethodInfo methodInfo)
        {
            yield return new object[] { BinaryTreeNodeTestDataHolder.NullTree };
            yield return new object[] { BinaryTreeNodeTestDataHolder.Tree1 };
            yield return new object[] { BinaryTreeNodeTestDataHolder.Tree2 };
            yield return new object[] { BinaryTreeNodeTestDataHolder.Tree3 };
            yield return new object[] { BinaryTreeNodeTestDataHolder.Tree4 };
            yield return new object[] { BinaryTreeNodeTestDataHolder.Tree5 };
            yield return new object[] { BinaryTreeNodeTestDataHolder.Tree6 };
            yield return new object[] { BinaryTreeNodeTestDataHolder.Tree7 };
            yield return new object[] { BinaryTreeNodeTestDataHolder.Tree8 };
            yield return new object[] { BinaryTreeNodeTestDataHolder.Tree9 };
            yield return new object[] { BinaryTreeNodeTestDataHolder.Tree10 };
            yield return new object[] { BinaryTreeNodeTestDataHolder.Tree11 };
            yield return new object[] { BinaryTreeNodeTestDataHolder.Tree12 };
            yield return new object[] { BinaryTreeNodeTestDataHolder.Tree13 };
            yield return new object[] { BinaryTreeNodeTestDataHolder.Tree14 };
            yield return new object[] { BinaryTreeNodeTestDataHolder.Tree15 };
            yield return new object[] { BinaryTreeNodeTestDataHolder.Tree16 };

            yield return new object[] { BinaryTreeNodeTestDataHolder.FromSampleData1 };
            yield return new object[] { BinaryTreeNodeTestDataHolder.FromSampleData2 };
        }

        /// <summary>
        ///  Get the display name.
        /// </summary>
        /// <param name="methodInfo">The method info.</param>
        /// <param name="data">The data.</param>
        /// <returns>The display name.</returns>
        public string GetDisplayName(MethodInfo methodInfo, object[] data)
        {
            return (data?[0] as BinaryTreeNodeTestData)?.DisplayName;
        }
    }
}
