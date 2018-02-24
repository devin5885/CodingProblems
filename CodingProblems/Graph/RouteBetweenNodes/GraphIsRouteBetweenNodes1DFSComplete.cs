using System;
using System.Collections.Generic;
using CodingProblems.Graph.Node;

namespace CodingProblems.Graph.RouteBetweenNodes
{
    /// <summary>
    /// Functionality for checking whether there is a route between nodes.
    /// </summary>
    public static class GraphIsRouteBetweenNodes1DFSComplete
    {
        /// <summary>
        /// Determines if there is a route between start and end.
        /// </summary>
        /// <typeparam name="T">The node type.</typeparam>
        /// <param name="start">The start node.</param>
        /// <param name="end">The end node.</param>
        /// <returns>True if there is a route between nodes, false otherwise </returns>
        public static bool IsRouteBetweenNodes1DFSComplete<T>(GraphNode<T> start, GraphNode<T> end)
        {
            // Error checking.
            if (start == null || end == null)
                throw new ArgumentException("Null nodes specified.");

            // Check for same node.
            if (start == end)
                return true;

            // Init list of nodes that we need to visit children of.
            var nodesToVisitChildren = new Queue<GraphNode<T>>();

            // Init map of nodes that were already added (visited).
            var nodesAdded = new HashSet<GraphNode<T>>();

            // Visit first nodes children.
            nodesToVisitChildren.Enqueue(start);

            // Add to list of added nodes.
            nodesAdded.Add(start);

            // Continue while we have nodes to visit children.
            while (nodesToVisitChildren.Count != 0)
            {
                // Get node to visit children of.
                var nodeToVisitChildren = nodesToVisitChildren.Dequeue();

                // Visit children.
                foreach (var nodeChild in nodeToVisitChildren.Children)
                {
                    // See if we need to visit this child.
                    if (!nodesAdded.Contains(nodeChild))
                    {
                        // If we found the end we are done.
                        if (nodeChild == end)
                            return true;
                        else
                        {
                            // We need to visit the children of this node.
                            nodesToVisitChildren.Enqueue(nodeChild);

                            // Now this node has been added.
                            nodesAdded.Add(nodeChild);
                        }
                    }
                }
            }

            // No path found.
            return false;
        }
    }
}
