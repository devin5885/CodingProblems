# Binary Tree Is Binary Search Tree

## Additional Requirements
- Use Recursion.

---

## Implementation
For each node compare the left and right children's value to the parent. If
 the left node's value is greater than the parent's value or the right
nodes value is less than the parent's value return false. Then check all
sub-nodes.

### IsBinarySearchTree

#### Steps
1. Check whether the binary tree is null, if so return true.

2. If the left node is non-null check whether the value is
greater than this nodes value, if so return false. If not
recursively call the method for the left node. If the
recursive method returns false, return false.

3. If the right node is non-null check whether the value is
less than this nodes value, if so return false. If not
recursively call the method for the right node. If the
recursive method returns false, return false.

4. Return true since tree is a valid binary search tree.

#### Complexity
Time: O(n) where n is the number of nodes in the tree.  
Space: O(n) where n is the number of nodes in the tree.  

---

## Notes
