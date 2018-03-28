# Find Longest Palindrome - Solution 2 - Use Anchors

## Additional Requirements

---

## Implementation
To find the best palindrome we will iterate through "anchor indexes". For
each anchor index we will check all possible palindromes centered on this
index (both odd & even number of characters). We will keep the best
palindrome found for the anchor index while checking that index. Once we
have checked the anchor index we will compare the resulting palindrome
to the current palindrome. If the new palindrome is longer we will discard
the existing palindrome and keep this one. When we have checked all
anchors we will return the resulting palindrome.

---

### FindLongestPalindrome

#### Steps
1. Check whether the input string is null, if so throw an exception.

2. Initialize the result string to an empty string.

3. Iterate through 'anchor indexes'. (i.e.) from zero to the last
character index in the input string.

4. For each anchor index, iterate twice, once using the anchor index on the
current character index (To check palindromes with an even number of 
characters) and once for the anchor index between the current character index
and the next character index (To check palindromes with an odd number of
characters).

5. Initialize a right index to the anchor index.

6. Initialize a left index to the anchor index (for the odd number of characters
strings) and the anchor index + 1 (for the even number of characters strings).

7. Initialize refs to the best right & left index to null. These will store
the most favorable indexes that generate a palindrome for this iteration.

8. Iterate while reducing the right index by one and increasing the left index
by one until the right index is less than zero or the right index is past the
end of the string.

9. If the characters at the left & right indexes match update the best indexes
and continue, otherwise stop iterating with this right and left index. At this
the best index values will contain the best indexes for generating a palindrome
for this anchor.

10. If we found best right & left indexes compute the length of the resulting
palindrome, if it is longer than the current palindrome update the result
string.

11. Continue through all anchor indexes.

12. Return the resulting palindrome.

---

## Complexity
Time: O(n^2^)  
Space: O(1)  

---

## Notes
- This algorithm is more efficient but is complex.

- The efficiency of this algorithm is that because we start with the shortest
substring for each anchor and increase the string size, once we find that
the string is not a palindrome we don't need to check longer strings for this
anchor since we know they also cannot be palindromes.