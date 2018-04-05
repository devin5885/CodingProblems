# Traverse Pre-Order - Solution 2 - Iterative

## Additional Requirements

---

## Implementation
- Traverse the tree iteratively (using a stack).

---

### TraversePreOrder

#### Steps
1. Create the result list.

2. Check whether the passed in tree is null, if so
return the empty list.

3. Create a stack and push the root node.

4. Continue while the stack is not empty.

5. Pop the top node from the stack & add to list.

6. If non-null push the left node onto the first stack.

7. If non-null push the left node onto the first stack.

8. Go to Step 4.

9. Return the resulting list.

#### Complexity
Time: O(n) where n is the number of nodes in the tree.  
Space: O(n) where n is the number of nodes in the tree.  

---

## Notes
