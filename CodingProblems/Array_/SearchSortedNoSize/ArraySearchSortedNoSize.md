# Array Search Sorted No Size

- From Cracking the Coding Interview, Interview Questions 10.4

## Problem
You are given an array-like data structure Listy which lacks a size method.
It does, however have an elementAt(i) method that returns the element at
index i in O(1) time. If i is beyond the bounds of the data structure it
returns -1 (For this reason, the data structure only supports positive
integers.) Given an Listy which contains sorted, positive integers, find
the index at which an element x occurs. If x occurs multiple times you
may return any index.

## Requirements
- Null string for the listy array should throw an exception.

- If the element value to find is less than 0, the method should throw an exception.

- Since the requirements state that if the array contains multiple instances
of the same value, for testing purposes we will test only with arrays that do
not contain multiple instances since the different solutions could return different
indexes.

- Method to implement:  

|            |                                                               |
|------------|---------------------------------------------------------------|
| Name       | Search                                                        |
| Parameters | The listy array                                               |
|            | The element value to find                                     |
| Returns    | The index or -1 if the value is not found.                    |

## Solutions
1. Brute Force - Iterate through the array.

2. Binary Search - Use a binary search to find the item after determining the
starting point of the binary search.