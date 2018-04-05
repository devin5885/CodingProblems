# Traverse Pre-Order - Solution 1 - Recursive

## Additional Requirements

---

## Implementation
- Traverse the tree recursively.

---

### TraversePreOrder

#### Steps
1. Create an initialize the return list.

2. Call TraversePreOrderHelper to generate the list.

3. Return the list.

#### Complexity
Time: O(n) where n is the number of nodes in the tree.  
Space: O(n) where n is the number of nodes in the tree.  

---

### TraversePreOrderHelper

#### Steps
1. Check whether the passed in node is null, if so return.

2. Visit the node.

3. Call the method recursively passing the right child of the node (which
could be null).

4. Call the method recursively passing the left child of the node (which
could be null).

#### Complexity
Time: O(n) where n is the number of nodes in the tree.  
Space: O(n) where n is the number of nodes in the tree.  

---

## Notes
