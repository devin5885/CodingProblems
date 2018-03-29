# Find Palindrome Permutations - Solution 1 - Standard

## Additional Requirements

---

## Implementation
This method works by generating all the permutations for the first half of the
 string, then generating strings containing the permutation the center character
(for input strings with odd number of characters) and the reverse of the
permutation.

---

### FindPalindromePermutations

#### Steps
1. Check whether the input string is null, if so throw an exception.

2. Check whether the input string is not a palindrome, if so throw an
exception.

3. Initialize the result list.

4. Check whether the string is less than 4 characters, in this case the
only possible palindrome permutations are the string itself so add
the original string to the list and return.

5. Get the first half of the string (For odd number of chars get first
half not including middle character).

6. Call the GetPermutations helper to get all full permutations of the
first half of the input string (the full permutations are those that
use all character in the input string.)

7. Iterate through all resulting permutations, for each build the
resulting permutation string using the permutation, the reversed
permutation and the center character (if the input string has an
odd number of characters). Add the string to the results.

8. Return the resulting list of strings.

---


## Complexity
Time: O((n/2)!) where n is the length of the string.
Space: O((n/2)!) where n is the length of the string.

---

## Notes
- This algorithm uses the IsPalindrome helper method for error checking.