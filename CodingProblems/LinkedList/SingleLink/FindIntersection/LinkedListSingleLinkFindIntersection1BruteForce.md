# Solution 1 - Brute Force

## Requirements

## Implemenation
To solve this problem we will simply walk the first list checking each node
in the list against all nodes in the second list. When a match is found
it will be returned.

### Intersection

1. Walk the first list checking each node.
2. Walk the second list for each node in the first list.
3. If the nodes match return the node.

Time complexity: O(n^2^)
Space complexity: O(1)

## Notes
- This solution is very simple but not very efficient.
