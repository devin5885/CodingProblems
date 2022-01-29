using System;
using CodingProblems.BinaryTree.Node;

namespace CodingProblems.BinaryTree.Traverse.Helpers
{
    /// <summary>
    ///  Node data used in the iterative traversal.
    /// </summary>
    /// <typeparam name="T">The node type.</typeparam>
    public class TraversalNodeData<T>
        where T : IComparable
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TraversalNodeData{T}"/> class.
        /// </summary>
        /// <param name="node">The node.</param>
        /// <param name="nodeState">The node state.</param>
        public TraversalNodeData(BinaryTreeNode<T> node, TraversalNodeState nodeState)
        {
            Node = node;
            NodeState = nodeState;
        }

        /// <summary>
        ///  Gets or sets the node.
        /// </summary>
        /// <value>
        ///  The node.
        /// </value>
        public BinaryTreeNode<T> Node { get; set; }

        /// <summary>
        ///  Gets or sets the state of the node.
        /// </summary>
        /// <value>
        ///  The state of the node.
        /// </value>
        public TraversalNodeState NodeState { get; set; }
    }
}
