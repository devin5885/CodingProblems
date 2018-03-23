# IsPalidromePermutation
- From Cracking the Coding Interview, Interview Questions 1.4

## Problem
Implement an algorithm to determine if a specified string is a permutation of a Palindrome.

## Requirements
- Null string should throw exception.
- Empty string should return true.

- Method to implement:  
Name: IsPalidrome  
Parameters: String to check   
Returns: True if the string is a palindrome permutation, false otherwise.

## Solutions
1. Simple - Create a dictionary of character instance counts & use to determine if permutation.
2. Running Count - Keep a running count of characters with an odd # of instances to avoid having to process resulting dictionary.