# Solution 1 - Simple

## Requirements

## Implementation

### IsPalidromePermutation

Steps:
1. Check whether the string is null & throw an appropriate exception if so.
2. Create a dictionary of character instance keys & and boolean values. The
boolean value indicates whether an odd or even # number of instances of the
character are found.
3. Parse the string & update the dictionary appropriately adding & updating
character counts as needed.
4. Process the dictionary, check that there is a single or no characters with
an odd # of instances, if so return true, if not fail.

Time Complexity: O(n)  
Space Complexity: O(n)

## Notes
- This solution requires parsing the dictionary after creating it.