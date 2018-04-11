# Array Merge Sorted Inline

- From Cracking the Coding Interview, Interview Questions 10.1

## Problem
You are given two sorted arrays, A and B, where A has a large enough buffer
at the end to hold B. Write a method to merge B into A in sorted order.

## Requirements
- Null string for either array should throw exception.

- If the element count is less than 0, the method should throw an exception.

- It will be assumed that we can get the length of the arrays.

- Method to implement:  

|            |                                                               |
|------------|---------------------------------------------------------------|
| Name       | Merge                                                         |
| Parameters | The A array                                                   |
|            | The count of elements to be merged in the A array.            |
|            | The B array                                                   |
| Returns    | None                                                          |

## Solutions
1. Standard - Use two loops, one to consume elements in both arrays, and one
of two defined loops to consume remaining elements.