# Solution 1 - Clear And Shift

## Requirements

## Implementation
To solve this problem more efficiently we can simply use the
appropriate masks to create 2 values one with the even index bits
cleared & one with the odd index bits cleared, we can then shift
these so that the bits are in the swapped locations & then OR the
two values together to produce the new result.

### SwapOddEvenBits

Steps:
1. Build a mask with all even index bits set to 1 & all odd index
 bits set to 1.
2. Add the specified value with the mask to zero all even index bits.
3. Right shift the bits by 1 so that all odd bits are now in the
even locations & a 0 bit is in the 0th location (it will be updated
in a future step).
4. Build a mask with all odd index bits set to 1 & all even index
 bits set to 1.
5. Add the specified value with the mask to zero all odd index bits.
6. Left shift the bits by 1 so that all even bits are now in the
odd locations & a 0 bit is in the 31st location (it will be updated
in a future step).
7. OR the results from step 3 & 6 together & return.

Time Complexity: O(1)  
Space Complexity: O(1)  

## Notes
This solution is from CtCI.