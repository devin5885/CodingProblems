# Next Number
- From Cracking the Coding Interview, Interview Questions 5.4

## Problem
- Given a positive integer, print the next smallest and the next largest number
that have the same number of 1 bits in their binary representation.

## Requirements
- The values are signed and positive.
- Since only positive numbers are allowed it will be assumed that only positive
numbers can be returned as well, so the sign bit will not be considered as
bit that can be flipped.
- The problem does not state what should happen if no matching number is found
however the solution code returns -1 in this case therefore the implemented
 methods will return -1 in this case as well.
- For now we will assume 32-bit values, this could be changed in the future.
- Since we are not creating console applications the implemented methods will
return the numbers.

- Methods to implement:  
Name: GetNext
Parameters: The value to get the next largest value for.
Returns: The next largest value that has same # of matching bits.

Name: GetPrev
Parameters: The value to get the next smallest value for.
Returns: The next smallest value that has same # of matching bits.

## Solutions
1. Brute Force - Get the value by checking higher #'s sequentially until a match is found.
2. Bit Adjust - Use bit adjustment to get the value.
3. Arithmetic - Use a combination of bit adjustment & arithmetic operators to get the value.
