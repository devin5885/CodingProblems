# Paint Fill - Solution 1 - Recursive

## Additional Requirements

---

## Implementation

---

### PaintFill

#### Steps
1. Check whether the specified entry is already newColor, if so return false.

2. Call PaintFillHelper to update the appropriate entries from the old color
to the new color.

---

### PaintFillHelper
Note: Additionally takes the old color, so that the method can check whether
the entry should be updated.

#### Steps
1. Check whether a valid row, column index has been specified, if not return
false. (This is an expected case).

2. Check whether the entry matches the old color, if not return false. (This
is also an expected case).

3. Recursively call the helper method for the 8 cells around the current cell.
Note that some cells may not exist & some will not be updated because they
don't match the old color.

---

## Complexity
Time: O(n*m) - Where n is the row count & m is column count.  
Space: O(0) - In-line update.  

---

## Notes
- The implementation is similar to CrCI however the row/col validation checking
is encapsulated and the error checking is cleaner.
