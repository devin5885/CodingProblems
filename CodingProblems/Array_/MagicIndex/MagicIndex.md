# Magic Index

- From Cracking the Coding Interview, Interview Questions 8.3

---

## Problem
A magic index in an array A[1...n-1] is defined to be an index such that A[i]
 = i. Given a sorted array of distinct integers write a method to a find a
magic index, if one exists, in array A.

FOLLOW UP:
What if the values are not distinct.

---

## Requirements
- The method will return -1 if no magic index if found.
- If there are multiple magic indexes the behavior is undefined. (This cannot
be easily error checked for).
- The array passed in must be non-null.

- Method to implement:  

|            |                             |
|------------|-----------------------------|
| Name       | FindMagicIndex              |
| Parameters | The array                   |
| Returns    | The magic index             |

---

## Solutions
1. Brute Force - Iterate through the array from the start until the magic index is found, then return it.
2. Binary Search - Use binary search to find the magic index.
3. Binary Search Allow Duplicates - Use binary search in an array that may have duplicate items.