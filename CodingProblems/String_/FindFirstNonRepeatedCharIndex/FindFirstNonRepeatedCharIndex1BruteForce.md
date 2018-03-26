# (String) Find First Non-Repeated Character - Solution 1 Brute Force

## Additional Requirements

---

## Implementation

---

### FindFirstNonRepeatedCharIndex

#### Steps
1. Check whether the passed in string is null, if so throw an exception.

2. Iterate through all characters in the string (current char).

3. For each char, iterate through all characters in the string (compare
char). Compare the current character to the compare character, if they
are not the same character index & and they match, end the inner loop
and go to the next character. 

4. If the end of the inner loop is reached and the character does not
have a match return it.

5. Continue with all characters.

6. Return -1 since no non-repeating character was found.

---

## Complexity
Time: O(n^2^) where n is number of characters in the string.
Space: O(1)

---

## Notes

