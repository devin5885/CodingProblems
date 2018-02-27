# Solution 1 - Fixed Size Stacks

## Solution Specific Assumptions
- The capacity of the stacks in the same for each stack & is fixed (Set at construction).
- Since stack capacity for each stack is fixed a particular stack can run out of space w/o the other stacks being full.

## Implementation Overview
Implement the stacks using an array. Use the same algorithm as a the single
stack approach with the following changes:

- Update the stack constructor to take the # of stacks as well as the size of
each stack. Take the size of the stacks instead of the overall size to ensure
that the total size is a multiple of the # of stacks.

- Instead of a single Stack Pointer variable extend this to an array of stack
pointer variables, these variables will indicate the current item for the stack.

- In order to make the Stack Pointer variables work consistently, create an
array of Stack Pointer offset values, this value will indicate the starting
offset for that stack. Thus to get the actual index of the current item 
it will be necessary to add the current Stack Pointer value to the offset.

## Algorithms for Operations Overview

### Constructor
Parameters: Per-stack size, # of stacks  
1. Store the stack count.
3. Create a Stack Pointer array initialize all elements to -1.
3. Create a Stack Pointer Offset array, initialize each elements to the capacity per stack * the stack #.
4. Create a Stack array, set size to the capacity per stack * the # of stacks.
Returns: None  

### Push
Parameters: Stack # (0 based), Element to push.
1. Check whether there is space in the specified stack for a new element, if not throw.
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
s = Size of each stack.  

### Constructor
Time - O(n)  
Space - O(n)  

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

## Notes
- This solution requires allot more test cases & does not provide much benefit over the single array per-stack.
- Design Question - What should the parameter order be for Push, Stack # first then value?
- Design Question - Should we allow a default for Stack #?
- The variable stack size is similar to this problem, but reallocates & copies the array if the stack gets too big.
- The variable stack size, with variable individual stack sizes problem is much more complex.