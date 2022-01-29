# Traverse In-Order - Solution 2 - Iterative

## Additional Requirements

---

## Implementation
- Traverse the tree iteratively (using a stack).

---

### TraverseInOrder

#### Steps
1. Create the result list.

2. Check whether the passed in tree is null, if so
return the empty list.

3. Create a stack and push the root node.

4. Create a current reference and initialize to the root
node.

5. Continue while the stack is not empty and the current
node reference is non-null.

6. Continue while the current node is not-null.

7. Push the current node to the stack.

8. Update current node to the left node of the current node
and goto step 6.

9. Continue while the stack is not empty.

10. Pop a node from the stack and add it to the result.

11. Update the current node to the right node of the popped
node.

12. Goto 9.

13. Goto 5.

14. Return the resulting list.

#### Complexity
Time: O(n) where n is the number of nodes in the tree.  
Space: O(n) where n is the number of nodes in the tree.  

---

## Notes
