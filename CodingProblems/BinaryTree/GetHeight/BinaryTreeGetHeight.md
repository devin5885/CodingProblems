# BinaryTreeGetHeight

### Problem
Impement a function to get the height of a binary tree (or subtree). The
height of a binary tree is defined as the # of levels of the tree.

### Notes
- Note that since the height of the sub-tree is assumed to be the height of the
longer of the sub-trees of the right & left nodes, the height of a particular
subtree is not necessarily the height of the parent nodes tree - 1.

### Solutions:
1. Recursive - Implement the method recurisively.
2. Iterative - Implment the method iteratively.

### Solution 1 - Recursive

#### Solution Specific Assumptions
- Recursion is allowed.

##### Overview
For each node recursively get the height of its right & left sub-trees.
Return whichever is larger plus 1 for this node.

#### Alg
If the node is null return 0.
Return the larger of the height of the right & left subtrees & 1 for this level.

#### Big O
N, n = # of nodes in tree.  
Time - O(N)  (Recursive calls)
Space - O(n) (Call stack for recursive calls)

#### Notes

### Solution 2 - Iterative

#### Solution Specific Assumptions
- Recursion is not allowed.

##### Overview
Similiar to a depth first search, go thru each level, quering child nodes of nodes in this level into a list. Stop when there are no more child nodes.
The # of loops in the height of the tree.

#### Alg
1. Create a list & add the node passed in to the list.
2. While there are nodes in the list. Init a new list for the next level.
For each node query the child nodes & add to next level list. 
After querying replace the previous list with the new list.
Increment the next level count each time.
3. Return the level count.

#### Big O
N = Node count.
n = Node count. (Actually we create & destroy lists as we go along, so we won't use n all at once)
Time - O(N)
Space - O(n) (Node lists)

#### Notes
