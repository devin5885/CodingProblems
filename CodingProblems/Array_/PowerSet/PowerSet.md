# Power Set

- From Cracking the Coding Interview, Interview Questions 8.4

---

## Problem
Write a method to return all subsets of a set.

---

## Requirements
- Since we are considering a set, there cannot be duplicate entries.
- All subsets is also called the power set.

- Method to implement:  

|            |                                                 |
|------------|-------------------------------------------------|
| Name       | GetPowerSet                                     |
| Parameters | The set represented as an array                 |
| Returns    | The power set represented as a list of lists    |

---

## Solutions
1. Recursive - Generate all possible power sets.
2. Combinatorics - Generate a list of integers and generate the power sets from the bit pattern of the integers.