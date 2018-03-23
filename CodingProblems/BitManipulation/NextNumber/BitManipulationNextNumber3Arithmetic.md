# Solution 1 - Use Arithmetic

## Requirements

## Implementation
These algorithms are similar to the bit adjustment approach however instead
of updating bits arithmetic is used to modify the number.

### GetNext

Steps:
1. Verify that the specified number is positive if not throw an appropriate exception.
2. Initialize a temp value to the value passed in.
3. Count the # of 0's in the right-most bits of the value passed in, before the first 1 is found. (by right shifting the temp value & testing).
4. Count the # of 1's, after & including the 1 found in the above step. Stop when a zero is found. (by right shifting the temp value & testing).
5. Do error checking, if the two counts added together are 0 or 31, then fail & return -1. Note that since the sign bit cannot be changed the value to check for is 31 not (32 could only occur for a negative #).
6. Add 2^count0^ - 1 to the number and add 1 to the number. This will set the appropriate bit and clear the bits on the right of this bit.
7. Add 2^count1-1^ -1 to the number. This will set the trailing 0's to 1.
8. Return the resulting number.

Time Complexity: O(1)  
Space Complexity: O(1)  

### GetPrev

Steps:
1. Verify that the specified number is positive if not throw an appropriate exception.
2. Initialize a temp value to the value passed in.
3. Count the # of 1's in the right-most bits of the value passed in, before the first 0 is found (by right shifting the temp value & testing).
4. If there are any 1's left to the right of the 0 found above count the # of 0's up to the next 1, after & including the 0 found in the above step. (by right shifting the temp value & testing).
5. Do error checking, if the value contained all 1's in the left-most bits, all 0's in the right most bits (i.e.) all 1's were shifted out return -1.
6. Subtract 2^count1^ - 1 to the number and subtract 1 from the number. This will clear the appropriate bit & set the bits to the right of this bit.
7. Add 2^count1-1^ -1 to the number. This will set the appropriate number of bits to the right of the cleared bit.
8. Return the resulting number.

Time Complexity: O(1)  
Space Complexity: O(1)  

## Notes
- This algorithm is in CtCI.
