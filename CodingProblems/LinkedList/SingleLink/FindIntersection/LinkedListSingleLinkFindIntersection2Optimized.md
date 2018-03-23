# Solution 2 - Optimized

## Requirements

## Implemenation
To solve this problem we will compare each node of the two lists one by one
until we find a matching node. We will then return this node. Because the
lists may have a differing # of nodes before they intersect, before comparing
nodes we need to determine the lengths of both lists & advance down the longer
list until we get to the corresponding start node of the shorter list. While
determining the lengths since we need to walk both lists we will also check
whether the last node in two lists matches if it does not we know that the
lists don't intersect.

### Intersection

1. Check if either list is null, if so return null.
2. Get the count of the first list, keeping a ref to the last node in the list.
3. Get the count of the second list, keeping a ref to the last node in the list.
4. Compare the last node of both lists, if they don't match return null.
5. If the counts do not match advance in the longer list to the corresponding
node in the shorter list (By index).
6. Check each node of both lists, until the first matching node is found &
return it. Note that since the last nodes in the list match & we are pointing
to the same index in both list not much error checking is needed.

Time complexity: O(n)
Space complexity: O(1)

## Notes
- This solution is more complex that the brute-force solution but is much more
efficient.