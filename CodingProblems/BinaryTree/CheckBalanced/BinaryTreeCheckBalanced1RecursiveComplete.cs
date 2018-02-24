using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodingProblems.BinaryTree.GetHeight;
using CodingProblems.BinaryTree.Node;

namespace CodingProblems.BinaryTree.CheckBalanced
{
    /// <summary>
    /// Functionality for checking whether a binary tree is balanced.
    /// </summary>
    public static class BinaryTreeCheckBalanced1RecursiveComplete
    {
        /// <summary>
        ///  Checks whether the specified binary tree is balanced.
        /// </summary>
        /// <typeparam name="T">The node type.</typeparam>
        /// <param name="node">The root node for the tree being checked.</param>
        /// <returns>True if the true is balanced, false otherwise.</returns>
        public static bool CheckBalanced1RecursiveComplete<T>(BinaryTreeNode<T> node)
        {
            // Base case.
            if (node == null)
                return true;

            // Check the difference in height.
            var heightDiff = BinaryTreeGetHeight1RecursiveComplete.GetHeight1RecursiveComplete(node.Left) - BinaryTreeGetHeight1RecursiveComplete.GetHeight1RecursiveComplete(node.Right);
            if (Math.Abs(heightDiff) > 1)
                return false;
            // If successful, check sub-trees.
            else
                return CheckBalanced1RecursiveComplete(node.Left) && CheckBalanced1RecursiveComplete(node.Right);
        }
    }
}
