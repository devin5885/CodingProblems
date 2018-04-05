# Traverse In-Order - Solution 1 - Recursive

## Additional Requirements

---

## Implementation
- Traverse the tree recursively.

---

### TraverseInOrder

#### Steps
1. Create an initialize the return list.

2. Call TraverseInOrderHelper to generate the list.

3. Return the list.

#### Complexity
Time: O(n) where n is the number of nodes in the tree.  
Space: O(n) where n is the number of nodes in the tree.  

---

### TraverseInOrderHelper

#### Steps
1. Check whether the passed in node is null, if so return.

2. Call the method recursively passing the right child of the node (which
could be null).

3. Add the node to the result list.

4. Call the method recursively passing the left child of the node (which
could be null).

#### Complexity
Time: O(n) where n is the number of nodes in the tree.  
Space: O(n) where n is the number of nodes in the tree.  

---

## Notes
