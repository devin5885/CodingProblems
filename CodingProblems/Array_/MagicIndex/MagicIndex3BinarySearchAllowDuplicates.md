# Magic Index - Solution 3 - Binary Search - Allow Duplicates

## Additional Requirements
- For this implementation the array can contain duplicate items.

---

## Implementation
This solution uses a binary search like algorithm, based on the difference
between the array index & array element value. Unfortunately, because we
allow non-unique elements we still need to search both halves of the array
however we can skip some elements, thus in the non-worst case this
algorithm is more efficient than the brute force algorithm.

---

### FindMagicIndex

#### Steps
1. Check whether the array is null, if so throw an exception.
2. Pass-through to the MagicHelper helper method specifying the beginning &
ending array indexes.

---

### FixMagicIndexHelper

#### Steps
1. If the current (passed in) end index is less than the current (passed in)
 start index, return -1. (Same as Solution #2)

2. Compute the mid-point index of the array between the current start and end
index. (Same as Solution #2)

3. Check whether the element at the mid-point is the magic element, if so
return it. (Same as Solution #2)

4. Get the new left index, ignoring elements whose index is greater than the
value of the mid-point element as the first index that can match has the index
 matching the value of the mid-point element.

5. Call the method recursively to search remaining part of the left side. If
the recursive call returns a value greater than zero this is the magic index.
(If -1 was returned the magic index was not found on the left side).

6. Get the new right index, ignoring elements whose index is less than the
value of the mid-point element as the first index that can match has the index
 matching the value of the mid-point element.

7. Call the method recursively to search remaining part of the right side,
returning the value returned (which could be -1 if the magic index was not
found on the right side).

## Complexity
Time: O(n) where n is the size of the array.  
Space: O(0)  

---

## Notes
- This algorithm is O(n), just like the brute force algorithm, because we
cannot ignore half of the array as we can with Solution 3, however in the
non-worst case scenario, some elements are skipped, thus this algorithm
in non-worst cases is more efficient.

- This solution is pretty complex, since the increase in performance over
the brute force method is minimal, this algorithm would not seem to be
worth using.