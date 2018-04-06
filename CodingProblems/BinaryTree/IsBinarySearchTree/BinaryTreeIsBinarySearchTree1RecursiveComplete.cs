using System;
using CodingProblems.BinaryTree.Node;

namespace CodingProblems.BinaryTree.IsBinarySearchTree
{
    /// <summary>
    /// Implements IsBinarySearchTree
    /// </summary>
    public static class BinaryTreeIsBinarySearchTree1RecursiveComplete
    {
        /// <summary>
        /// Determine if a binary tree is a binary search tree.
        /// </summary>
        /// <param name="binaryTree">The tree</param>
        /// <returns>True if the tree is a binary search tree, false otherwise.</returns>
        public static bool IsBinarySearchTree(BinaryTreeNode<int> binaryTree)
        {
            // Check for null.
            if (binaryTree == null)
                return true;

            // Check left binaryTree.
            if (binaryTree.Left != null)
            {
                // Check left node against root.
                if (binaryTree.Left.Value > binaryTree.Value)
                    return false;

                // Check left children.
                if (!IsBinarySearchTree(binaryTree.Left))
                    return false;
            }

            // Check right binaryTree.
            if (binaryTree.Right != null)
            {
                // Check right node against root.
                if (binaryTree.Right.Value < binaryTree.Value)
                    return false;

                // Check right children.
                if (!IsBinarySearchTree(binaryTree.Right))
                    return false;
            }

            // Is a BST.
            return true;
        }
    }
}
