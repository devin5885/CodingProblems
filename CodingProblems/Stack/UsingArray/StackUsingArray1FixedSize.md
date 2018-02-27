# Solution 1 - Fixed Size Stack

## Solution Specific Assumptions
- Stack's capacity is fixed (Set at construction).

## Overview
Implement the stack using an array.

To keep track of the current front of the stack an integer stack pointer will
be used this integer will contain the index of the current stack item or -1 if
the stack is empty.

When an item is pushed the element will be added & the stack pointer incremented. 
When an element is popped, the element at the stack pointer will be retrieved and
returned at the same time decrementing the stack pointer.

## Algorithms for Operations Overview

### Constructor
Parameters: Per-stack size  
1. Construct an array of the appropriate size.
2. Initialize the Stack Pointer to -1.
Returns: None.

### Push
Parameters: Element to push.
1. Check whether there is space in the stack for a new element, if not throw.
2. Add the new element to the array element one past the stack pointer.
3. Increment the stack pointer to point to the new item.
Returns: None.

### Pop
Parameters: None.
1. Check whether there are any elements in the stack, if not throw.
2. Return the element pointed to by the stack pointer & decrement the stack pointer.
Returns: The item.

### Peek
Parameters: None.
1. Check whether there are any elements in the stack, if not throw.
2. Return the element pointed to by the stack pointer.
Returns: The item.

## Big O
s = Capacity of the stack.  

### Constructor
Time - O(1)
Space - O(s)

### Push
Time - O(1)
Space - O(0)

### Pop
Time - O(1)
Space - O(0)

### Peek
Time - O(1)
Space - O(0)

### Count
Time - O(1)
Space - O(0)

#### Notes
- Enhancement: We could save space by waiting to construct the stack when an
element is first added, but this would make the code more complex.