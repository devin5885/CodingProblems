# Is Palindrome (Using Stacks) - Solution 1 - Standard

## Additional Requirements

---

## Implementation
Using two stacks compare the characters from the string to the
characters in reverse order, if they match return true, otherwise
return false.

---

### IsPalindrome

#### Steps
1. Check whether the input string is null, if so throw an exception.

2. Create a stack and add the characters from the input string from
the beginning to the end of the string.
 
3. Create a stack and add the characters from the input string from
the end to the beginning of the string.

4. Pop elements from both stacks comparing the elements, if the
elements don't match, return false. After all elements are popped
and match return true.

---

## Complexity
Time: O(n) where n in the length of the string.  
Space: O(n) where n in the length of the string.  

---

## Notes
