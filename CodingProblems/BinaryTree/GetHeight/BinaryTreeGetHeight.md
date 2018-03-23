# Get Height

### Problem
Implement a function to get the height of a binary tree (or subtree). The
height of a binary tree is defined as the # of levels of the tree.

### Requirements

- Method to implement:  
Name: GetHeight  
Parameters: The top node of the tree (Can be a sub-tree).  
Returns: The height of the tree.  

### Solutions
1. Recursive - Implement the method recursively.
2. Iterative - Implement the method iteratively.

### Notes
- Note that since the height of the sub-tree is assumed to be the height of the
longer of the sub-trees of the right & left nodes, the height of a particular
subtree is not necessarily the height of the parent nodes tree - 1.