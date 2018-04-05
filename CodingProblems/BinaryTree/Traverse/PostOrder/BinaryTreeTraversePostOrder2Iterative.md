# Traverse Post-Order - Solution 2 - Iterative

## Additional Requirements

---

## Implementation
- Traverse the tree iteratively (using two stacks).

---

### TraversePostOrder

#### Steps
1. Create the result list.

2. Check whether the passed in tree is null, if so
return the empty list.

3. Create the first stack and push the root node.

4. Create a second stack.

5. Continue while the first stack is not empty.

6. Pop the top node from the first stack & add to the second stack.

7. If non-null push the left node onto the first stack.

8. If non-null push the right node onto the first stack.

9. Go to Step 5.

10. Continue while the second stack is not empty.

11. Add the node to the result list.

12. Go to Step 10.

13. Return the resulting list.

#### Complexity
Time: O(n) where n is the number of nodes in the tree.  
Space: O(n) where n is the number of nodes in the tree.  

---

## Notes
