# Solution 2 - Use Bit Shift

## Requirements

## Implementation
Check all bits in the specified value recording the largest index that
is set.

### GetMostSignificantBit

Steps:
1. Check that the value is >= 0, if not throw an exception.
2. Handle 0 as a special case as this algorithm does not work for 0.
3. Initialize a integer to keep track of the largest set index & set
this value to 0.
4. Walk the bits from 0 to the size of a signed integer * 8 - 1.
5. Check whether the bit is set by anding with 1 and checking against 1
, if the result is 1 update the largest set index.
6. Shift the bits right by one.
7. Returns the largest set index.

Time Complexity: O(1)  
Space Complexity: O(1)  

## Notes
- The method has the disadvantage that we always have to walk all bits.