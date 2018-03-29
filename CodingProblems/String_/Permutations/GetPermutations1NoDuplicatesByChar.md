# Get Permutations Solution 1 - No Duplictes By Char Iterative

- From Cracking the Coding Interview, Interview Questions 8.7

## Additional Requirements
- No duplicate characters allowed in the string.

---

## Implementation

---

### GetPermutations

#### Steps
1. Initialize the result list.

2. Check for a null string passed in, if so return any empty result list.

3. If the string has at least 1 char add the initial string consisting of the
single char.

4. Process each character in the passed in string by:

5. Generating a new empty set of permutations.

6. Walk each string the result list of permutations, for each existing
permutation generate a collection of new permutation with the current character
inserted in all the possible locations.

7. Replace the existing result list with the new result list.

---

## Complexity
Time: O(n!) where n is the length of the string.
Space: O(n!) where n is the length of the string.

---

## Notes
- This is similar to the first CtCI solution, but is implemented iteratively &
implements the string building in-line.

- This solution would create duplicate permutations if the string contains
duplicate characters, this could be resolved by removing duplicate values
from the resulting array, however this would be inefficient, so this solution
is not used for the duplicate character case.

