# Solution 1 - Convert to String

## Requirements

## Implementation
- Convert to string & return the # of 1's in the string.

### GetBitCount

Steps:
1. Check that the value is >= 0, if not throw an exception.
2. Convert to string & return the # of 1's in the string.

Time Complexity: O(1)
Space Complexity: O(1)

## Notes
- This solution is simple but inefficient because the signed integer must
be converted to a string. Also, this only works for languages that have a
way to convert an integer to a binary string.