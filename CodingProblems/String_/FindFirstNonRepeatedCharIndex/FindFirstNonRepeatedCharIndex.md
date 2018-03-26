# (String) Find First Non-Repeated Character Index

---

## Problem
Implement a method to find the index of the first non-repeated character in an
 string. If all characters are repeated return -1.

---

## Requirements
- If the passed in string is null an exception should be thrown.

- If an empty string is passed in -1 should be returned.

- Method to implement:  

|            |                                                 |
|------------|-------------------------------------------------|
| Name       | FindFirstNonRepeatedCharIndex                   |
| Parameters | The string                                      |
| Returns    | The appropriate index                           |

---

## Solutions
1. Brute Force - Walk the string, for each character, check all other characters.