# Binary Tree Is Perfect

## Additional Requirements

---

## Implementation
Use a DFS like strategy to walk the tree nodes level by level
checking for incomplete sub-trees.

### IsPerfect

#### Steps
1. Check whether the binary tree is null, if so return true.

2. Initialize the node list and add the root node.

3. Initialize a level counter to 1.

4. Continue while there are nodes in the node list.

5. Create and initialize a list for the next levels children.

6. Iterate through the current node list.

7. Add the non-null left & right children to the next levels
children list.

8. Got step 6.

9. Determine the expected node count for the next level (i.e.) the
level matching the next level children list. The expected count is
0 or 2^level^.

10. If the count of nodes does not match return false.

11. Update the node list to the next level children node list.

12. Increment the level counter.

13. Go to Step 4

14. Return true since the tree is perfect.

#### Complexity
Time: O(n) where n is the number of nodes in the tree.  
Space: O(m) where m is the maximum number of nodes on any level.

---

## Notes
