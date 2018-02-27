# Check Balanced

## Problem Summary
Implement a function to check if a binary tree is balanced. For the purpose of
this question, a balanced tree is defined to be a tree such that the heights
of the two subtrees of any node never differ by more than one.

## Requirements

- Method to implement:
Name: CheckBalanced
Parameters: The top node of the tree (Can be a sub-tree).
Returns: True if the tree is balanced, false otherwise.

## Solutions:
1. Recursive - Use GetHeight Recursive - Use the recursive version of GetHeight.
2. Optimized Recursive - Check height of sub-trees while getting height.

## Notes
- From Cracking the Coding Interview, Interview Questions 4.4

- Note that since the height of the sub-tree is assumed to be the height of the
bigger of the sub-trees of the right & left nodes, thus the sub-tree of a particular
node being balanced does not necessarily guarantee that all sub-trees of all
sub-nodes of the node is balanced. Thus, when checking for a balanced tree we
must always check all nodes until we find an unbalanced node.


