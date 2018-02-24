## Route Between Nodes

### Problem
Given a directed graph, design an algorithm to fid out whether there is a route
between two nodes.

### Notes
- From Cracking the Coding Interview, Interview Questions 4.1
- If either node is null, an exception should be thrown.
- Nodes are not mutable.
- We can use additional data structures.
 
### Solutions:
1. Simple Iterative DFS
2. Simple Recursive BFS (TODO)

### Solution 1 - Simple Iterative DFS

#### Solution Specific Assumptions

##### Overview
Starting with the start node, check all children of the node & it's children
etc. for a path to the end node. Use a queue to keep track of the current list
of children to check. Use a dictionary to keep track of nodes that have already been added.

#### Alg
1. The algorithm takes two params, the start & end node.
2. Check whether either node is null, if so return false.
3. Check that whether the start & end node match, if so return true.
4. Build a queue of nodes whose children we need to check. Use a queue
because it is easy to add/remove nodes from beginning/end.
5. Build a hash set of nodes that have already been added to the queue. (to prevent
cycles). Use a dictionary for quick lookup.
6. Add the start node to both the queue and dictionary.
7. For each element in the queue of nodes to check get it's chilren.
8. For each child node see if the node is in the added list, if not, check whether this is the end node, if so return true.
If not add the node to the queue of nodes to check & add it to the dictionary as added.
9. If the loop ends, return false as there is no path.

#### Big O
n = Node count (Nodes connected to start).
v = vertices count (Vertices for nodes above).
Time - O(n + v)
Space - O(n) = O(2n) Queue & Hash Set.  

#### Notes
- We use a dictionary to store the added nodes for quick lookup.
- Improvements over the book algorithm:
1. We do not assume that the node class has a mutable state variable, thus we don't have
to initialize anything & and our algorithm doesn't need to graph itself, just the start & end.
2. Instead of a 3 state variable, we simply use a dictionary to indicate whether the node has
been visited or not.
3. We do not check for null nodes in the alg, the node check occurs at the beginning & throws an exception.