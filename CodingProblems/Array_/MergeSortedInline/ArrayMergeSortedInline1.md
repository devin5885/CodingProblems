# Array Merge Sorted - Solution 1 - Simple

## Additional Requirements

---

## Implementation
Iterate through the A and B arrays from end of elements in each taking the
 element that is greater and placing it at the end of the A list, reducing
the placement location index each time. Continue until we run out of elements
 in one of the arrays. Once this occurs take the remaining elements in the other
 array and add them to the target array.

---

### Merge
1. Check whether either array is null, if so throw an exception.

2. If the count is less than 0, throw an exception.

3. Initialize three references, one to the index of the last element in the B
array (Source B), one to the last element to merge in the A array (specified
 as a parameter - 1) (Source A), and one to the index of the last index of the
 A array (Target A).

4. Continue while both Source A and Source B are greater than or equal to 0.

5. If the A element at Source A is greater than the B element at Source B take
the Source A element and place it in the location of Target A. Reduce Source A
by one and Target A by one.

6. Otherwise, take the Source B element and place it in the location of Target A.
Reduce Source B by one and Target A by one.

7. Go to Step #4.

8. While Source A is less than 0 and Source B is greater than or equal to 0 take
the Source B element and place it in the location of Target A. Reduce Source B
by one and Target A by one. (Out of A elements case).

8. While Source B is less than 0 and Source A is greater than or equal to 0 take
the Source A element and place it in the location of Target A. Reduce Source A
by one and Target A by one. (Out of B elements case).

#### Steps

#### Complexity
Time: O(n + m) where n is the count of elements in the first array and n is the count of elements in the second array.  
Space: O(n + m) where n is the count of elements in the first array and n is the count of elements in the second array.  

---

## Notes
