# Insertion
- From Cracking the Coding Interview, Interview Questions 5.1

## Problem
You are given two 32-bit numbers, N and M, and two bit positions, i and j.
Write a method to insert M into N such that M starts at bit j and ends at
bit i. You can assume that bits j through i have enough space to fit all
of M. That is, if M=10011, you can assume that there are at least 5 bits
between j and i. You would not, for example have j = 3 and i = 2, because
M could not fully fit between bit 3 and bit 2.

## Requirements
- The values are signed.
- M.msb is the most significant set bit in M. M.lsb is the least significant
bit set in M.
- j - i must be greater than or equal to M.msb - M.lsb.
- For now it will be assumed that both N and M are positive #'s, this restriction
may be removed in the future.

- It is not clear from the description but the following assumptions are made:
1. i & j must be between 0 and 31.
2. j must be greater than or equal to i.
3. If j - i is greater than M.msb - M.lsb, the additional bits will be cleared
i N & M will be merged starting at i (i.e.) the remaining high order cleared bits
will not be updated.

- Method to implement:  
Name: UpdateBits  
Parameters: N - The first number, M - The second number, i - First bit
position, j - Second bit position.  
Returns: The updated value.  

## Solutions
1. Standard  