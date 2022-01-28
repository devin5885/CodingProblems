# Traverse In-Order - Solution 1 - Recursive

## Additional Requirements

---

## Implementation
- Traverse the tree recursively.

---

### TraverseInOrder

#### Steps
1. Create and initialize the return list.

2. If the tree passed in is null, return the empty list.

2. Call TraverseInOrderHelper to generate the list.

3. Return the list.

#### Complexity
Time: O(n) where n is the number of nodes in the tree.  
Space: O(n) where n is the number of nodes in the tree.  

---

### TraverseInOrderHelper

#### Steps
1. Check whether the passed in node is null, if so return.

2. If the right child of the node is not null call the method recursively passing the right child of the node.

3. Add the node to the result list.

4. If the left child of the node is not null call the method recursively passing the left child of the node.

#### Complexity
Time: O(n) where n is the number of nodes in the tree.  
Space: O(n) where n is the number of nodes in the tree.  

---

## Notes
