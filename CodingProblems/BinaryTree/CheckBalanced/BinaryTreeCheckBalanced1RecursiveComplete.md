## Solution 1 - Use GetHeight Recursive

## Requirements
- Recursion is allowed.
- The GetHeight helper method (implemented in another problem) can be used.

## Implementation

Note: n = # of items in tree.

Steps:
1. Check whether the current node is null, if so return true since the sub-tree
of this node is balanced.
2. Call GetHeight to check the height of the right & left subtree of the current
node, if the difference is greater than 1 return false.
3. Otherwise, recursively call this method to check the height of the right & left
sub-nodes of this node. Return true if both are balanced, false otherwise. Note
that the recursive calls will continue eventually checking the sub-trees of all nodes.

Notes:
- To get the height of a sub-tree GetHeight must get the height of the sub-trees
of all descendant nodes of the node, and since we must call GetHeight for every
node in the tree the time complexity of this algorithm is O(n^2^).

Time Complexity - O(n^2^)  
Space Complexity - O(n^2^)  

## Notes
- This algorithm has the advantage of being very simple.
