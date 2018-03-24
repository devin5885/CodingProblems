# Stack Of Boxes

- From Cracking the Coding Interview, Interview Questions 8.13

---

## Problem
You have a stack of n boxes, with withs w1, heights h1, and depths d1. The
boxes cannot be rotated and can only be stacked on top of one another if
each of the boxes in the stack is strictly larger than the box above it
in with, height, and depth. Implement a method to compute the height of
the tallest possible stack. The height of a stack is the sum of the heights
of each box.

---

## Requirements
- The length, width, & height of a box must be positive & greater than 0.

- For a null list, an exception should be thrown.

- For a list with no boxes, 0 should be returned.

- Method to implement:  

|            |                                                 |
|------------|-------------------------------------------------|
| Name       | GetMaxHeight                                    |
| Parameters | The list of box objects                         |
| Returns    | The maximum possible height                     |

---

## Solutions
1. Compute And Count - Compute all possible stacks of boxes and
return the one with the greatest height.

---

## Notes
- An oddity of this problem is that a box of the same size cannot be
stacked on each other.

- If the boxes could be rotated then the maximum height would be
the height of all boxes added together because then all boxes
could always be used.
