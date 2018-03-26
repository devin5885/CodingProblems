# Fibonacci

- From Cracking the Coding Interview, Chapter 8

---

## Problem
Implement a method to generate the appropriate Fibonacci number given it's index.

---

## Requirements
- The index is assumed to be positive, the method should throw an exception if a
negative number is specified.

- Since we are returning a 32-bit integer overflow is possible, currently this
is not checked for.

- Method to implement:  

|            |                                                 |
|------------|-------------------------------------------------|
| Name       | Fibonacci                                       |
| Parameters | The index                                       |
| Returns    | The appropriate Fibonacci number                |

---

## Solutions
1. Recursive - Simple (but inefficient) generation.