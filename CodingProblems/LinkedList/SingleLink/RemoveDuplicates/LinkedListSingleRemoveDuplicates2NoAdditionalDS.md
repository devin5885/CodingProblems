# Solution 2 - No Additional DS

## Requirements
- For this solution no additional data structures are allowed.

## Implemenation
Iterate thru the list, for each node iterate thru all remaining
nodes removing any duplicates nodes when found.

### RemoveDuplicates

Steps:
1. Initialize a current node to check ref to the head node in the list.
2. Continue while the node to check ref is not null.
3. Initialize refs to the next node (node being checked against)
after the node to check and the previous node (the node to check).
4. Continue while the node being checked against is non-null.
5. Check whether to node being checked against matches the node being
checked, if so update refs to remove the node being checked against,
 otherwise just go the next node.
6. Update the node being checked against ref to the next node go
back to step 4.
7. Update the node to check ref to back to step 2.

Time Complexity: O(n^2^)
Space Complexity: O(1)

## Notes
- This algorithm does not require any additional storage but is slow.