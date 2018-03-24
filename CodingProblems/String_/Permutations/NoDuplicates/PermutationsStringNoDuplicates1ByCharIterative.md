# Permutations without Duplicates - Solution 1 - By Char Recursive

## Additional Requirements

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
- This is not very efficient, however since we must generate all possibilities we
cannot improve this.

- This is similar to the first CtCI solution, but is implemented iteratively &
implements the string building in-line.

