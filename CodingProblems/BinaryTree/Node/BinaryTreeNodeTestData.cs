using System.Collections.Generic;

#pragma warning disable SA1600
#pragma warning disable 1591
#pragma warning disable SA1516 // Elements must be separated by blank line
namespace CodingProblems.BinaryTree.Node
{
    /// <summary>
    /// Binary tree instances for testing.
    /// </summary>
    public class BinaryTreeNodeTestData
    {
        public string DisplayName { get; set; }

        public int Height { get; set; }

        public bool IsBST { get; set; }
        public bool Balanced { get; set; }
        public bool Complete { get; set; }
        public bool Full { get; set; }
        public bool Perfect { get; set; }

        public BinaryTreeNode<int> Root { get; set; }
        public List<int> PreOrder { get; set; }
        public List<int> InOrder { get; set; }
        public List<int> PostOrder { get; set; }
    }
}
#pragma warning restore 1591
#pragma warning restore SA1600
#pragma warning restore SA1516 // Elements must be separated by blank line
