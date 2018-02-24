using System.Collections.Generic;
using CodingProblems.Graph.Node;

namespace CodingProblems.Graph.Graph
{
    /// <summary>
    /// Represents a graph.
    /// </summary>
    /// <typeparam name="T">The type for nodes in the graph.</typeparam>
    public class GraphGraph<T>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GraphGraph{T}"/> class.
        /// </summary>
        public GraphGraph()
        {
            Nodes = new List<GraphNode<T>>();
        }

        /// <summary>
        /// Gets or sets the nodes of the graph.
        /// </summary>
        /// <value>The nodes of the graph.
        /// </value>
        public List<GraphNode<T>> Nodes { get; set; }
    }
}