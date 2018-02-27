# Solution 2 - Iterative

## Requirements
- Recursion is not allowed.

## Overview
Similar to a depth first search, go thru each level, querying child nodes of nodes in this level into a list. Stop when there are no more child nodes.
The # of loops in the height of the tree.

#### Implementation

Note: n = # of nodes in tree.  

Steps:
1. Create a list & add the node passed in to the list.
2. While there are nodes in the list. Initialize a new list for the next level.
For each node query the child nodes & add to next level list. 
After querying replace the previous list with the new list.
Increment the next level count each time.
3. Return the level count.

Time Complexity: O(n)  
Space Complexity: O(n)  

## Notes
