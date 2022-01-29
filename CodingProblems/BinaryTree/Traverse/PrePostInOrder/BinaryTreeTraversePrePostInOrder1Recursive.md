# Traverse Binary Tree - Solution 1 - Recursive

## Additional Requirements

---

## Implementation
- Traverse the tree recursively.

---

### Traverse

#### Steps
1. Create and initialize the return list.

2. If the tree passed in is null, return the empty list.

2. Call TraverseHelper to generate the list.

3. Return the list.

#### Complexity
Time: O(n) where n is the number of nodes in the tree.  
Space: O(n) where n is the number of nodes in the tree.  

---

### TraverseHelper

#### Steps
1. Check whether the passed in node is null, if so return.

2. If the traversal type is PreOrder add the current node to the result list.

3. If the right child of the node is not null call the method recursively passing the right child of the node.

4. If the traversal type is InOrder add the current node to the result list.

5. If the left child of the node is not null call the method recursively passing the left child of the node.

6. If the traversal type is PostOrder add the current node to the result list.

#### Complexity
Time: O(n) where n is the number of nodes in the tree.  
Space: O(n) where n is the number of nodes in the tree.  

---

## Notes
