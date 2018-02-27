# Solution 2 - Variable Size Stack

## Solution Specific Assumptions
- Stack can grow as needed.

## Implementation Overview
Implement the stacks using an array. Use the same algorithm as the fixed size
stacks with the following changes:

1. With fixed size the size is specified in the constructor & the array is
allocated immediately, with variable size no size is specified and the array
is not allocated until items are added.

2. In the variable size case, if an attempt is made to add an item to the
stack which will not fit, a new array of twice the size (or 2 if no existing array)
is immediately allocated and the contents of the existing array copied.
Then the new item is added.

## Algorithms for Operations Overview

### Constructor
Parameters: None.
1. Initialize the stack pointer to -1.
2. Initialize the internal array to an empty array.
Returns: None.

### Push
Parameters: Element to push.
1. Check whether there is space in the stack for a new element, if not allocate a new array of twice the size of the current array & copy existing items to the new array.
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
c = Count of items in the stack.

### Constructor
Time - O(1)  
Space - O(1)  

#### Push
Time - O(1)  
Space - O(c)  

### Pop
Time - O(1)  
Space - O(0)  

### Peek
Time - O(1)  
Space - O(0)  

### Count
Time - O(1)  
Space - O(0)  

## Notes
- Enhancement: The array could be replaced by a smaller array when items are
removed, this would save space, but would require additional copying.
