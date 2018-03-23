# Magic Index - Solution 2 - Binary Search

## Additional Requirements
- For this implementation, the values in the array must be unique, therefore
this implementation will check this and throw an exception if a duplicate
values are found.

---

## Implementation
This solution uses a binary search like algorithm, based on the difference
between the array index & array element value. This allows us to split the
array by half each time, thus resulting in a log n runtime. Unfortunately,
this method is not compatible with arrays that can have non-unique elements.

---

### FindMagicIndex

#### Steps
1. Check whether the array is null, if so throw an exception.

2. Check whether the array has duplicate elements, if so throw an exception.

3. Pass-through to the MagicHelper helper method specifying the beginning and
ending array indexes.

---

### FindMagicIndexHelper

#### Steps
1. If the current (passed in) end index is less than the current (passed in)
start index, return -1.

2. Compute the mid-point index of the array between the current start and end index.

3. Check whether the element at the mid-point is the magic element, if so return it.

4. Check whether the element ad the mid-point is greater than the index of the
element, if so the magic index (if any) must be to the left of the mid-point,
thus call the helper method recursively to check the remaining array elements
to the left of the mid-point.

5. Otherwise the magic index (if any) must be to the right of the mid-point,
thus call the helper method recursively to check the remaining array elements
the left of the mid-point.

## Complexity
Time: O(log n) where n is the size of the array.  
Space: O(0)  

---

## Notes

---

The reason that this algorithm works is that if the element value is greater
than the index value (and the elements are distinct) the elements values below
this element value can decrease only as fast as the index decreases, thus it
will never be possible for the element value to "catch up" to the index value
and match. If the element value is less than the index value the opposite is
 true the element values can only increase as the index increases, thus again
it will not be possible for the element value to "catch up" to the index value
and match.

Note that assumption is not true if the array is allowed to have duplicate
values as there is no guarantee that value will increase or decrease up or
down the array.

(e.g.) If the element index is 5 and the element value is 3, for the magic
index to be before this value in the array the element values 2 or 1 would
have to be at the 2 or 1 index, which is not possible since the maximum
value that could be in the 2 or 1 index is 0 or -1.

---