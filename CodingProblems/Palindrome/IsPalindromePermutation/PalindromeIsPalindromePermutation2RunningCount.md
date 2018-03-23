# Solution 2 - Running Count

## Requirements

## Implementation

### IsPalidromePermutation

Steps:
1. Check whether the string is null & throw an appropriate exception if so.
2. Create a dictionary of character instance keys & and boolean values. The
boolean value indicates whether an odd or even # number of instances of the
character are found.
3. Parse the string & update the dictionary appropriately adding & updating
character counts as needed. At the same time keep a boolean indicating true
for 0 or 1 instances with odd counts, false otherwise.
4. Return the value of the boolean.

Time Complexity: O(n)  
Space Complexity: O(n)

## Notes
- This solution requires parsing the dictionary after creating it.