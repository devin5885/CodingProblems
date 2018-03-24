# Permutations without Duplicates

- From Cracking the Coding Interview, Interview Questions 8.7

---

## Problem
Write a method to compute all permutations of a string of unique
characters.

---

## Requirements
- For the null string an empty set of permutations should be returned.

- Method to implement:  

|            |                                                 |
|------------|-------------------------------------------------|
| Name       | GetPermutations                                 |
| Parameters | The string                                      |
| Returns    | A list of string permutations                   |

---

## Solutions
1. By Char Iterative - Generate permutations by processing the array character
by character and building & storing the resulting permutations.

2. By Substring - Generate permutations by processing sets of characters. (TODO-Future)