# Solution 1 - Recursive

## Requirements
- Recursion is allowed.

## Overview
For each node recursively get the height of its right & left sub-trees.
Return whichever is larger plus 1 for this node.

## Implemenation

Note: n = # of nodes in tree.  

Steps:
1. If the node is null return 0.
2. Return the larger of the height of the right & left subtrees & 1 for this level.

Time Complexity - O(n)  
Space Complexity - O(n)  

## Notes