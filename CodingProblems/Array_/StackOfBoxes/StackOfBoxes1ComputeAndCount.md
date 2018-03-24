# Stack of Boxes - Solution 1 - Compute And Count

## Additional Requirements

---

## Implementation
- To solve this problem we will simply calculate all possible stacks of boxes
and then determine the stack with the greatest height and return it.

---

### GetMaxHeight

#### Steps
1. Check whether the list of boxes is null, if so throw an exception.

2. Initialize the list of all valid stacks.

3. Add a stack of a single box to the list for each box.

4. Walk the list of boxes, for each box:

5. Walk the existing list of stacks, for each stack:

6. Create a new stack bases on the current stack.

7. If this box has not yet been added to stack and can fit on top of
the previous box, add it to the stack & add the new stack to the result
list of stacks.

8. Continue for all stacks.

9. Continue for all boxes.

10. If any stacks were added to the result stacks list determine the tallest
stack & return it's height, otherwise return 0.

---

## Complexity
Time: O(n!) where n is the # of boxes.
Space: O(n!) where n is the # of boxes.

---

## Notes
- This is not very efficient, there may be ways to improve it.

- This algorithm is implemented iteratively.

