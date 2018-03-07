# Solution 2 - Shift the Number

## Requirements

## Implementation
Use bit shifting, shift the number being checked.

### GetBitCount

Steps:
1. Initialize a counter of the # of set bits to 0.
2. Check whether the number being checked is 0, if so return current count,
otherwise continue. Note that we can stop when the number is 0 because
once the number is 0 we know that all 1 bits have been shifted out.
3. Compare the number being checked to a mask of 1, if non-zero increment
the current count. By using a mask 1 we check only the 0th index bit, which
we then shift out.
4. Right shift the # being checked. Go to 2.

Time Complexity: O(n)  
Space Complexity: O(1)  

## Notes
- This algorithm is more efficient than the mask shift since we can stop once
we run out of 1 bits.
