# Solution 1 - Bit Adjust

## Requirements

## Implementation
These algorithms work by finding the most appropriate bit to set or clear to make the
value smaller or larger, they then find the best bit to the right of the changed
bit to set or clear to make the # of bits match the original value.

### GetNext

Steps:
1. Verify that the specified number is positive if not throw an appropriate exception.
2. Initialize a temp value to the value passed in.
3. Count the # of 0's in the right-most bits of the value passed in, before the first 1 is found. (by right shifting the temp value & testing).
4. Count the # of 1's, after & including the 1 found in the above step. Stop when a zero is found. (by right shifting the temp value & testing).
5. Do error checking, if the two counts added together are 0 or 31, then fail & return -1. Note that since the sign bit cannot be changed the value to check for is 31 not (32 could only occur for a negative #).
6. Determine the bit to set, this is the two counts added together (This bit is always 0) & set this bit.
7. Clear all bits to the right of the bit that was set.
8. Determine the # of bits to set, this is the count of 1 bits - 1. Note that we subtract 1 because we set a bit to increase the #.
9. If the count of bits to set is greater than 0 then set that # of bits. Note that when using CreateMask we need to use count1 - 1 so that we get the correct bit indexes set. 
10. Return the resulting value.
 
Time Complexity: O(1)  
Space Complexity: O(1)  

### GetPrev

Steps:
1. Verify that the specified number is positive if not throw an appropriate exception.
2. Initialize a temp value to the value passed in.
3. Count the # of 1's in the right-most bits of the value passed in, before the first 0 is found (by right shifting the temp value & testing).
4. If there are any 1's left to the right of the 0 found above count the # of 0's up to the next 1, after & including the 0 found in the above step. (by right shifting the temp value & testing).
5. Do error checking, if the value contained all 1's in the left-most bits, all 0's in the right most bits (i.e.) all 1's were shifted out return -1.
6. Determine the bit to clear, this is the two counts added together (This bit is always 1) & clear this bit.
7. Clear all bits to the right of the bit that was set.
8. Determine the # of bits to set, this is the count of 1 bits + 1. Note that we add 1 because we cleared a bit to decrease the #.
9. If the count of bits to set is greater than 0 then set that # of bits. Note that unlike the GetNext case we need to set the bits starting at the left-most bit after the cleared bit (instead of the right-most (i.e.) 0 bit). So we set the bits from the cleared bit index - 1 to the cleared bit index - 1 - the # of bits to set + 1.
10. Return the resulting value.

Time Complexity: O(1)  
Space Complexity: O(1)  

## Notes
- This algorithm is in CtCI.
- For GetNext - On pg. 284 the note in CtCI shows the value 11..1100..00 however this is not
a valid # for the problem since it is negative. The problem case is in fact
01..1100..00. Also, the code as written would not work for a negative # because
c0 + c1 would be 32, not 31. So the code works for the expected non-negative
case only.
