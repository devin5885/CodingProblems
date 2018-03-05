# Solution 1 - Stable

## Requirements
- The list should remain 'stable' (i.e.) no elements are reordered except as
necessary for partitioning.

## Implemenation
We will construct two new lists & one list will contain elements less than
the pivot value, the other elements not less than the pivot value. Then
the existing elements will be added to one of the two lists as appropriate.
Finally, if both new lists contain elements we will attach the top of the 
second list to the bottom of the first list. If the first list does not
contain any elements we will simply use the second list.

### Partition

Steps:
1. Initialize 2 lists (before and after) & a ref to the top & bottom of each
list (4 refs total).
2. Walk all nodes in the original list.
3. For each node first store the next node & null the Next pointer (to prevent
cycles).
4. Determine which list to add the node to & add to the appropriate list, updating
the list refs appropriately.
5. Check whether there are any elements in the before list, if so, attach the
after list to the before list & set the head to the head of the before list, otherwise
set the head to the head of the after list (which could be null).

Time Complexity: O(n)  
Space Complexity: O(1)  

## Notes
- This algorithm does not ensure that all elements that are more than the pivot are
after the pivot, just that all elements that are less than the pivot are before the
pivot. If we wanted to make sure that the all elements more than the pivot are after
the pivot as well (i.e.) all pivot elements are in the middle, we could modify the
algorithm to have 3 lists instead of 2. The middle list would contain the pivot
elements, we would then link the 3 lists together (instead of 2) at the end.