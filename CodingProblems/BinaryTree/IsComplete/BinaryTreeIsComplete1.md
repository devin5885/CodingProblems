# Binary Tree Is Complete

## Additional Requirements

---

## Implementation
Use a DFS like strategy to walk the tree nodes level by level
checking incomplete sub-trees.

---

### IsComplete

#### Steps
1. Check whether the binary tree is null, if so return true.

2. Initialize a queue to store nodes & enqueue the root node.

3. Initialize a boolean to false to indicate that no non-full
sub-trees have been found yet. Note that this flag once set
will not be reset, including across levels, this ensures that
a non-full level that is not the last level returns false.

4. Continue while there are nodes in the queue.

5. Dequeue a node.

6. If the left child is non-null check whether a non-full sub-tree
has been found, if so return false. If not enqueue the node. If the
left child is null, set the non-full sub-tree flag to true.

7. If the right child is non-null check whether a non-full sub-tree
has been found, if so return false. If not enqueue the node. If the
right child is null, set the non-full sub-tree flag to true.

8. Go to step 4.

9. Return true since the tree is complete.

#### Complexity
Time: O(n) where n is the number of nodes in the tree.  
Space: O(m) where m is the maximum number of nodes on any level.

---

## Notes
