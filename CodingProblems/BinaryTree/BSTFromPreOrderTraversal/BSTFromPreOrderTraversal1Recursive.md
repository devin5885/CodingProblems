# BST from Preorder Traversal - Solution 1 - Recursive

## Additional Requirements

---

## Implementation
- Use the single array traversal to build the tree.

---

### BSTFromPreOrderTraversal

#### Steps
1. First check that the preOrder traversal is null, if so return null.

2. Call the BSTFromPreOrderTraversalHelper method to build the tree. Pass the preOrder traversal as well as min and max parameters set the min and max values for the node data type.

#### Complexity
Time: O(n) where n is the number of nodes in the tree.  
Space: O(n) where n is the number of nodes in the tree.  

---

### BSTFromPreOrderTraversalHelper

#### Steps
3. The helper function takes the preOrder traversal, the current index in the list, and the min/max values to use to determine whether to continue.

4. Checks whether the current index is within the preorder list, if not the helper method returns null.

5. For the left children checks whether the value of the current node is greater than the previous nodes value,
for the right children checks whether the value of the current node is less than the value of the previous node, if so the method returns null.
Note that by passing the min and max values for the data type of T, the method does not need to know whether the right or left child is being checked
since it just uses the min/max values in the respective comparison so that the comparison always fails and the method does not return prematurely.

6. Creattes the new node which is the node pointed to by the current index in the preOrder list.

5. Updates the index in the preOrder list, note that this index must always be incremented when a node is created therefore it must either be a global
variable or a reference parameter to the method.

7. Calls the function recursively for the right and left children to create the subtrees. For the left call passed the min value for the data type of T
and the current node value. For the right call passes the current node value and the maxium value for the data type of T.

8. Returns the newly created node.

9. When all recursive calls and the main call have completed the tree has been built and is returned.

#### Complexity
Time: O(n) where n is the number of nodes in the tree.  
Space: O(n) where n is the number of nodes in the tree.  

---

## Notes
