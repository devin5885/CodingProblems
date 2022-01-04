# Binary Tree from Preorder and Inorder Traversals - Solution 1 - Recursive

## Additional Requirements

---

## Implementation
- Use the two arrays to build the tree.

---

### FromPreOrderAndInOrderTraversals

#### Steps
1. First check that both the preOrder and inOrder traversals are not null, if not return null.

2. Calls the FromPreOrderAndInOrderTraversalsHelper method to build the tree. Pass the preOrder and inOrder lists as well as indexes to the first and last elements in the lists.

#### Complexity
Time: O(n) where n is the number of nodes in the tree.  
Space: O(n) where n is the number of nodes in the tree.  

---

### FromPreOrderAndInOrderTraversalsHelper

#### Steps
3. The helper function takes the two traversals and the current start and and end indexes in the lists and then performs the following steps:

4. Creates the current node which is the node pointed to by the start pointer to the preOrder list.

5. Determines the index of the node that was just created in the inOrder list.

6. Divides the list into two lists one for the left sub-tree and one for the right sub-tree (if any) and determines the new indexes in both lists for the sub-trees.

7. Calls the function recursively for the right and left children to create the subtrees.

8. Returns the newly created node.

9. When all recursive calls and the main call have completed the tree has been built and is returned.

#### Complexity
Time: O(n) where n is the number of nodes in the tree.  
Space: O(n) where n is the number of nodes in the tree.  

---

## Notes
