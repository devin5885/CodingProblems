# (String) Find First Non-Repeated Character - Solution 2 Use Hash Set

## Additional Requirements

---

## Implementation

---

### FindFirstNonRepeatedCharIndex

#### Steps
1. Check whether the passed in string is null, if so throw an exception.

2. Initialize a new hash set to store found characters.

2. Iterate through all characters in the string (current char).

3. For each char, check whether the character is already in the hash set
if so end the inner loop and go to the next character. Otherwise:

4. Iterate through all characters in the string (compare char) after this
character. Compare the current character to the compare character, if 
they match the character is duplicated, end the inner loop and go to the next
character. 

4. If the end of the inner loop is reached and the character does not
have a match return it.

5. Add the character to the hash set since it has a duplicate.

5. Continue with all characters.

6. Return -1 since no non-repeating character was found.

---

## Complexity
Time: O(n^2^) where n is number of characters in the string.
Space: O(m) where m is number of duplicated characters.

---

## Notes

- This is similar to the previous solution however we use a hash set to store
the previously found characters, this allows us:  
-- To not have to search the entire string for each character, we can start
the search one character after the current character because all previous
characters are in the hash set.  
-- Immediately continue if we find that the current character is already in the
hash set.

- This is still O(n^2^) but is more efficient because of the above
optimizations.