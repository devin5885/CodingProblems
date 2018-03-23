# Solution 1 - Convert to String

## Requirements

## Implementation
- Convert to string & return the length of the string.

### GetMostSignificantBit

Steps:
1. Check that the value is >= 0, if not throw an exception.
2. Handle 0 as a special case as this algorithm does not work for 0.
2. Convert to string & return the length of the string.

Time Complexity: O(n)
Space Complexity: O(n)

## Notes
- This solution is simple but inefficient because the signed integer must
be converted to a string. Also, this only works for languages that have a
way to convert an integer to a binary string.