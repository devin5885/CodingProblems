# Solution 5 - Use Bit Array

## Implementation 
This solution is similar to the boolean array solution, but uses a bit array to save space.

### IsUnique

Steps:
1. If string is null return true.
2. Check whether the string is >64K, if so return false immediately.
3. Create & initialize all array elements to false. 
4. For each char check whether the corresponding array element is True, if it is return False, if not update the array entry to True.
5. End: Return true.

Time Complexity: O(n)  
Space Complexity: O(1)  

### Notes
- See Boolean Array
