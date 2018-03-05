# Solution 3 - Non-Stable

## Requirements
- The list does not need to remain 'stable' (i.e.) elements can be reordered
as necessary.

## Implemenation
We will construct a single new list. Elements less than the pivot value will
be added at the beginning of the, the other elements not less than the pivot
 value will be added at the end of the list. The head reference will then
be updated to point to the new list.

### Partition

Steps:
1. Initialize a ref to the head and tail of a new list & set the refs to null.
2. Walk all nodes in the original list.
3. For each node first store the next node & null the Next pointer (to prevent
cycles).
4. If the new list is empty add the node to the new list by setting the head
& tail refs to the node, otherwise.
5. Determine which end of list to add the node to & add to the appropriate end,
updating the list refs appropriately.
6. Set the head element to the head of the new list.

Time Complexity: O(n)  
Space Complexity: O(1)  

## Notes
- This algorithm does not ensure that all elements that are more than the pivot are
after the pivot, just that all elements that are less than the pivot are before the
pivot. If we wanted to make sure that the all elements more than the pivot are after
the pivot as well (i.e.) all pivot elements are in the middle, to do this we would
need to use the modified solution #1.