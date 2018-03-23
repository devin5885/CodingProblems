# Solution 2 - Variable Size Stacks

## Solution Specific Assumptions
- Stack can grow as needed.
- 
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
Parameters: # of stacks  
1. Store the stack count.
3. Create a Stack Pointer array initialize all elements to -1.
4. Create a Stack Pointer Offset array, do not initialize.
5. Construct an array of size 0.
Returns: None  

### Push
Parameters: Stack # (0 based), Element to push.
1. Check whether there is space in the stack for a new element, if not allocate a new array of twice the size of the current array & copy existing items to the new array.
2. Add the new element to the array element one past the stack pointer for the stack #.
3. Increment the stack pointer for the stack # to point to the new item.
Returns: None  

### Pop
Parameters: Stack # (0 based).
1. Check whether there are any elements in the specified stack, if not throw.
2. Return the element pointed to by the stack pointer for the stack # & decrement the stack pointer.
Returns: The item.

### Peek
Parameters: Stack # (0 based).
1. Check whether there are any elements in the specified stack, if not throw.
2. Return the element pointed to by the stack pointer for the stack.
Returns: The item.

## Big O
n = # of stacks.  

### Constructor
Time - O(n)  
Space - O(n)  

### Push
Time - O(n)  
Space - O(n)  

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
- This solution requires allot more test cases & does not provide much
benefit over the single array per-stack.
- Design Question - What should the parameter order be for Push, Stack # first then value?
- Design Question - Should we allow a default for Stack #?
- Enhancement: The array could be replaced by a smaller array when items are
removed, this would save space, but would require additional copying.
