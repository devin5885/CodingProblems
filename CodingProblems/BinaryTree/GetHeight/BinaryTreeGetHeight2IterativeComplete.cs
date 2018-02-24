using System.Collections.Generic;
using CodingProblems.BinaryTree.Node;

namespace CodingProblems.BinaryTree.GetHeight
{
    /// <summary>
    /// Functionality for checking whether a binary tree is balanced.
    /// </summary>
    public static class BinaryTreeGetHeight2IterativeComplete
    {
        /// <summary>
        /// Get the height of the tree.
        /// </summary>
        /// <typeparam name="T">The node type.</typeparam>
        /// <param name="node">The top node of the tree</param>
        /// <returns>The height as an int.</returns>
        public static int GetHeight2IterativeComplete<T>(BinaryTreeNode<T> node)
        {
            // Init nodes list for first call.
            var nodes = new List<BinaryTreeNode<T>>
            {
                node
            };

            // Start at 0.
            var height = 0;

            // Continue while there are nodes.
            while (nodes.Count != 0)
            {
                // Init nodes list for next call.
                var nodesNext = new List<BinaryTreeNode<T>>();

                // Processs all ndoes at this level.
                foreach (var nodeCurr in nodes)
                {
                    // Add child nodes of this node.
                    if (nodeCurr.Left != null)
                        nodesNext.Add(nodeCurr.Left);

                    if (nodeCurr.Right != null)
                        nodesNext.Add(nodeCurr.Right);
                }

                // Do next level.
                nodes = nodesNext;

                // New level.
                height++;
            }

            // Return result.
            return height;
        }
    }
}
