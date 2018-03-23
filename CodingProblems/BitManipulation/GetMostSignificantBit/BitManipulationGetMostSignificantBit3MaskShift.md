# Solution 3 - Shift the Mask

## Requirements

## Implementation
Check bits starting with the most significant bit, when the first set
bit is found return it. Note that this requires shifting the mask to
do the appropriate test.

### GetMostSignificantBit

Steps:
1. Check that the value is >= 0, if not throw an exception.
2. Walk all bits of the integer starting with index (sizeof(int) * 8) - 1 and
ending with index 0.
3. For each bit build a mask with all zeros except the bit being checked,
and it with the # being checked & compare to 0. If the result is non-zero
the bit is set.
4. Return the index + 1.
5. If no set bits a found return 0.

Time Complexity: O(1)
Space Complexity: O(1)  

## Notes
- This method has the advantage that we only need to walk bits until
the first set bit is found.