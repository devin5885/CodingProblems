# Paint Fill

- From Cracking the Coding Interview, Interview Questions 8.8

---

## Problem
Implement the "paint fill" function that one might see on may image existing
programs. That is, given a screen (represented by a two-dimensional array of
colors), a point, and a new color, fill in the surrounding area until the
color changes from the original color.

---

## Requirements
- 32-bit color values will be assumed.

- Method to implement:  

|            |                                                 |
|------------|-------------------------------------------------|
| Name       | PaintFill                                       |
| Parameters | The image to update                             |
|            | The row of the entry to update                  |
|            | The column of the entry to update               |
|            | The new color                                   |
| Returns    | True if an update was done, false otherwise     |

---

## Solutions
1. Recursive - Update the image recursively.