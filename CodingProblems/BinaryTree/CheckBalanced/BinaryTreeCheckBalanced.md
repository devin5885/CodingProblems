# Check Balanced

### Problem
Impement a function to check if a binary tree is balanced. For the purpose of
this question, a balanced tree is defined to be a tree such that the heights
of the two subtrees of any node never differ by more than one.

### Notes
- From Cracking the Coding Interview, Interview Questions 4.4
- Note that since the height of the sub-tree is assumed to be the height of the
longer of the sub-trees of the right & left nodes, the height of a particular
subtree is not necessarily the height of the parent nodes tree - 1. For this
reason to determine whether the tree is balanced it is necessary to check all
nodes of the tree.

### Solutions:
1. Recursive GetHeight, Reursive IsBalanced - Use the recursive version of GetHeight & implement level check recursively.
2. Iterative GetHeight, Reursive IsBalanced - Use the iterative version of GetHeight & implement level check recursively. (TODO)
3. Iterative GetHeight, Iterative IsBalanced - Use the iterative version of GetHeight & implement level check recursively. (TODO)
4. IsBalanced recursive w/o using GetHeight (TODO)

### Solution 1 - Use GetHeight Recursive

#### Solution Specific Assumptions
- Recursion is allowed.

##### Overview
Check each level to see if it is balanced, if so, check the sub-trees, if any non-balanced
sub-trees are found, return false.

#### Alg
1. Check whether the current node is null, if so return true since this subtree is balanced.
2. Check the height of the right & left subtree of the current node, if they are
greater than 1 return failure.
3. Recursivesly check the right & left sub-trees.

#### Big O
Time - O(N^2) - O(GetHeight) = O(N) * O(N) for this alg?
Space - O(n^2) - Stack space.

#### Notes
- This algorithm is not efficient because we need to call GetHeight (from the main method) for all nodes in the tree, each
call to GetHeight then results in recursive calls to GetHeight for the child nodes. Thus, the time complexity is (N^2)
