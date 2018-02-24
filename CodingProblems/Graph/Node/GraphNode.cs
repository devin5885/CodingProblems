using System.Collections.Generic;

namespace CodingProblems.Graph.Node
{
    /// <summary>
    /// Node for a graph.
    /// </summary>
    /// <typeparam name="T">The type of data stored by the node.</typeparam>
    public class GraphNode<T>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GraphNode{T}"/> class.
        /// </summary>
        /// <param name="value">The value for the node.</param>
        public GraphNode(T value)
        {
            Value = value;
            Children = new List<GraphNode<T>>();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GraphNode{T}"/> class.
        /// </summary>
        public GraphNode()
        {
            Children = new List<GraphNode<T>>();
        }

        /// <summary>
        /// Gets or sets the value for the graph node.
        /// </summary>
        /// <value>The graph node data.</value>
        public T Value { get; set; }

        /// <summary>
        /// Gets or sets the children of the graph node.
        /// </summary>
        /// <value>The graph node children.</value>
        public List<GraphNode<T>> Children { get; set; }
    }
}
