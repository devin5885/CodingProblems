# (Linked List Single) Partition
- From Cracking the Coding Interview, Interview Questions 2.4

## Problem
Write code to partition a linked list around a Value x, such that all nodes
 less than x come before all nodes greater than or equal to x. IF x is
 contained within the list, the value of x only need to be after the elements less than x.

Note: The second sentence above means that the elements that match x
 don't necessarily have to be in the 'middle' of the list (i.e.) less than
 elements must be before x, but elements greater than x can be before and
all pivot elements do not necessarily have to be in the middle.

## Requirements
- Null list should be a no-op.

- Method to implement:  
Name: Partition
Parameters: Top node in list, Value to partition around.
Returns: None.

## Solutions
1. Stable - The list remains stable during the partitioning.
2. Stable - Use Dummy Nodes - Use dummy nodes to simplify the code.
3. Non-Stable - This list does not need to remain stable during partitioning.