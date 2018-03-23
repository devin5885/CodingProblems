## Solution 1 - Use GetHeight Recursive

## Requirements
- Recursion is allowed.
- The GetHeight helper method (implemented in another problem) should not be used.

## Implementation

Instead of using GetHeight this solution uses an internal helper method, CheckHeight
this helper method returns the height difference of the sub-trees of the node
passed to it or -1 if the difference between sub-trees is > 1 (i.e.) the sub-trees
are unbalanced.

The CheckHeight method does a recursive post-order traversal of the nodes of the
tree, thus when processing a node it has already processed the right & left
child nodes of the node and thus has the height of both sub-trees of the node &
can determine if the node is balanced. When processing a node if the node is
balanced the method returns the height difference otherwise it returns -1.
When -1 is returned this causes the recursion to stop and -1 to be returned
up the recursive call stack & eventually returned from CheckHeight. In this way
the method eventually checks all nodes or finds an unbalanced node & stops.

Since it only checks each node once, this method has a time complexity of O(n).

### CheckBalanced

Note: n = # of items in tree.

Steps:

1. Call CheckHeight to get the height difference of the top node if balanced or
-1 if any part of the tree is unbalanced, return false if -1 is returned true
otherwise.

Time Complexity: O(n)  
Space Complexity: O(n)  

### CheckHeight

Parameters: The top node of the tree (Can be a sub-tree).

Steps:

1. Check whether the current node is null, if so return 0 since this subtree
is balanced.
2. Check the height of the right & left subtree of the current node, if the
difference is greater than 1 return false.
3. Recursively check the height of the sub-trees of the right & left child
nodes, continue for all child nodes.

Returns: The difference in heights of the right & left sub-tree of the specified
node or -1 if the right & left sub-trees are unbalanced.

Time Complexity: O(n)  
Space Complexity: O(n)  

## Notes
