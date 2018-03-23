# GetMostSignificantBit

## Problem
Given a positive signed integer determine return the 1-based index of the most
significant bit that is set.

## Requirements
- The specified signed integer must be a positive number greater than 0.
- The returned index is 1 based. (As otherwise we can't distinguish between no
bits set & the 0th absolute index bit set).

- Method to implement:  
Name: GetMostSignificantBit
Parameters: Signed integer to check.
Returns: The index of the most significant bit.

## Solutions
1. Convert to string.
2. Bit shift.
3. Mask shift.
4. Binary search.