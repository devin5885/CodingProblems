# Binary Tree Is Full

## Additional Requirements

---

## Implementation
Use a DFS like strategy to walk the tree nodes level by level
checking for incomplete sub-trees.

---

### IsFull

#### Steps
1. Check whether the binary tree is null, if so return true.

2. Initialize a queue to store nodes & enqueue the root node.

4. Continue while there are nodes in the queue.

5. Dequeue a node.

6. If the left child is non-null if so enqueue the node. If the
right child is null return false.

7. If the right child is non-null if so enqueue the node. If the
left child is null return false.

8. Go to step 4.

9. Return true since the tree is full.

#### Complexity
Time: O(n) where n is the number of nodes in the tree.  
Space: O(m) where m is the maximum number of nodes on any level.

---

## Notes
