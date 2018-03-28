# Find Longest Palidrome

---

## Problem
Write a method to find & return the longest possible palindrome in an input
string, if there are multiple possible palindromes of the same length the
first palindrome (i.e.) the palindrome starting with the lowest index should
be returned. Thus, if the string does not contain any palindromes the first
character in the string should be returned.

---

## Requirements
- The method should throw an exception if the string is null.

- The method should return an empty string if an empty string is passed in.

- Method to implement:  

|            |                                                               |
|------------|---------------------------------------------------------------|
| Name       | FindLongestPalidrome                                          |
| Parameters | The input string.                                             |
| Returns    | The longest possible palindrome.                              |

---

## Solutions
1. Brute Force - Check all possibilities.

2. Use Anchors - Use 'anchor' indexes to minimize the number of times that
we need to check whether a string is a palindrome.