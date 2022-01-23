# Binary Tree Is Binary Search Tree

## Additional Requirements
- Use Recursion.

---

## Implementation
For each node compare the nodes value to the current min and max values, return false if the nodes
value is outside of these values, otherwise if needed make the recursive calls for the left and right
sub-trees. If a subtree calls return false, return false. If the function completes without returning
false, return true to indicate that the tree is a BST.

### IsBinarySearchTree

#### Steps
1. Calls IsBinarySearchTreeHelper passing the root node and the min/max
values for the data type T.

#### Complexity
Time: O(n) where n is the number of nodes in the tree.  
Space: O(n) where n is the number of nodes in the tree.  

---

### IsBinarySearchTreeHelper

#### Steps
1. Takes the current node of the tree and min and max values, min and max values specify the current
minimum and maximum values to check node values against.

2. Check whether the binary tree is null, if so return true.

3. Checks whether the nodes value is greater than the max value or smaller than the min value, if so
returns false.

4. If the right child exists makes a sub-call passing the current min value and the nodes value for
max. If the sub-call returns false, the method immediately returns false.

5. If the left child exists makes a sub-call passing the nodes value for min and the current max value for
max. If the sub-call returns false, the method immediately returns false.

6. Return true since tree is a valid binary search tree.

## Notes
