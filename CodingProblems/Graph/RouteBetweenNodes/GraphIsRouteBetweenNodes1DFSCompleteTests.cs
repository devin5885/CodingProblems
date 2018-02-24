using CodingProblems.Graph.Graph;
using CodingProblems.Graph.Node;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodingProblems.Graph.RouteBetweenNodes
{
    /// <summary>
    /// Tests for GraphIsRouteBetweenNodes1DFSComplete.IsRouteBetweenNodes1DFSComplete
    /// </summary>
    [TestClass]
    public class GraphIsRouteBetweenNodes1DFSCompleteTests
    {
        /// <summary>
        /// Tests the case in which there is a path between nodes.
        /// </summary>
        [TestMethod]
        public void GraphRouteBetweenNodes1CompleteTest1RouteFound()
        {
            // Init nodes & make a path between 1 & 3 via 2.
            var node3 = new GraphNode<int>(3);

            var node2 = new GraphNode<int>(2);
            node2.Children.Add(node3);

            var node1 = new GraphNode<int>(1);
            node1.Children.Add(node2);

            Assert.IsTrue(GraphIsRouteBetweenNodes1DFSComplete.IsRouteBetweenNodes1DFSComplete(node1, node3));
        }

        /// <summary>
        /// Tests the case in which the same node is specified for start and end.
        /// </summary>
        [TestMethod]
        public void GraphRouteBetweenNodes1CompleteTest2RouteFoundSameNode()
        {
            // Init nodes & make a path between 1 & 3 via 2.
            var node1 = new GraphNode<int>(1);

            // Init graph.
            var graph = new GraphGraph<int>();
            graph.Nodes.Add(node1);

            Assert.IsTrue(GraphIsRouteBetweenNodes1DFSComplete.IsRouteBetweenNodes1DFSComplete(node1, node1));
        }

        /// <summary>
        /// Tests that case where there is no route between nodes.
        /// </summary>
        [TestMethod]
        public void GraphRouteBetweenNodes1CompleteTest3NoRouteFound()
        {
            // Init nodes.
            var node3 = new GraphNode<int>(3);

            var node2 = new GraphNode<int>(2);

            var node1 = new GraphNode<int>(1);
            node1.Children.Add(node2);

            Assert.IsFalse(GraphIsRouteBetweenNodes1DFSComplete.IsRouteBetweenNodes1DFSComplete(node1, node3));
        }

        /// <summary>
        /// Test the case in which there is a route between nodes and there is a cycle.
        /// </summary>
        [TestMethod]
        public void GraphRouteBetweenNodes1CompleteTest1RouteFoundCycle()
        {
            // Init nodes & make a path between 1 & 4.
            var node4 = new GraphNode<int>(4);

            var node3 = new GraphNode<int>(3);
            node3.Children.Add(node4);

            var node2 = new GraphNode<int>(2);
            node2.Children.Add(node3);
            node2.Children.Add(node4);

            var node1 = new GraphNode<int>(1);
            node1.Children.Add(node2);

            node3.Children.Add(node1);

            Assert.IsTrue(GraphIsRouteBetweenNodes1DFSComplete.IsRouteBetweenNodes1DFSComplete(node1, node4));
        }

        /// <summary>
        /// Test the case in which there is a route between nodes and there is no cycle.
        /// </summary>
        [TestMethod]
        public void GraphRouteBetweenNodes1CompleteTest1NoRouteFoundCycle()
        {
            // Init nodes & make a path between 1 & 4.
            var node4 = new GraphNode<int>(4);

            var node3 = new GraphNode<int>(3);

            var node2 = new GraphNode<int>(2);
            node2.Children.Add(node3);

            var node1 = new GraphNode<int>(1);
            node1.Children.Add(node2);

            node3.Children.Add(node1);

            Assert.IsFalse(GraphIsRouteBetweenNodes1DFSComplete.IsRouteBetweenNodes1DFSComplete(node1, node4));
        }
    }
}
