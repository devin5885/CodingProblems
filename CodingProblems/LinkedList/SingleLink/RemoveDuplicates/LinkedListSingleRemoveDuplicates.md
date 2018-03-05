# (Linked List Single) Remove Duplicates
- From Cracking the Coding Interview, Interview Questions 2.1

## Problem
Write code to remove duplicates from an unsorted linked list.
FOLLOW UP
How would you solve the problem if a temporary buffer is not allowed?

## Requirements
- For this problem nodes are considered duplicate if the value
of the nodes have the same value.
- The first node should be kept, additional matching nodes should
be removed.
- Null list should be a no-op.

- Method to implement:  
Name: RemoveDuplicates
Parameters: A ref to the head node of the list.
Returns: None.

## Solutions
1. Hash Set - In this solution we use a HashSet.
2. No Additional DS - In this solution we do not use any additional
data structures.