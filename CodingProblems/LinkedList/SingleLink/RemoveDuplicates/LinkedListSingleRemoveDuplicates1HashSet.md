# Solution 1 - Use Hash Set

## Requirements
- For this solution additional data structures are allowed.

## Implemenation
Iterate thru the list adding each node value to a hash set, if
a node value is found that is already in the hash set,
remove the node from the list.

### RemoveDuplicates

Steps:
1. Initialize a hash set.
2. Initialize a current node ref to the head node and a previous
node ref to null.
3. For each node, check whether the node is in the hash set, if
not add to the node to the hash set.
4. If the node is in the hash set, update refs to remove the node.

Time Complexity: O(n)
Space Complexity: O(n)

## Notes
- This algorithm is efficient but requires additional storage.