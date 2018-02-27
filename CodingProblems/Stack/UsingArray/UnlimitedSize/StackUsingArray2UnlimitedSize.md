# Unlimited Sized Stack Using Array

## Problem Summary
Implement a unlimited size stack using a fixed size array.

## Requirements
- Stack can grow as needed.

- No need to clear (zero) popped elements in the internal array. These elements will
automatically be overridden with new elements when the array slot is next
used.

- A stack class should be defined that stores items of a specified type and has
the following public operations:
 
### Construction
Description: Construct the object implementing the stack  
Parameters: None
Returns: None  

### Push
Description: Add an item to the stack  
Parameters: Element to push  
Returns: None  

### Pop
Description: Pop an item from the stack  
Parameters: None  
Returns: The item  

### Peek
Description: Peek at the top item in the stack  
Parameters: None  
Returns: The item  

### Count
Description: Get the count of items in the stack  
Parameters: None  
Returns: The count  

## Implementation
Use the same algorithm as the fixed size stack solution with the following changes:

1. With fixed size the size is specified in the constructor & the array is
allocated immediately, with variable size no size is specified and the array
is not allocated until items are added.

2. If an attempt is made to add an item to the
stack which will not fit, a new array of twice the size (or 2 if no existing array)
is immediately allocated and the contents of the existing array copied.
Then the new item is added.

Note: c = Count of items in the stack.

### Constructor

Steps:
1. Initialize the stack pointer to -1.
2. Initialize the internal array to an empty array.

Time Complexity: O(1)  
Space Complexity: O(1)  

### Push

Steps:
1. Check whether there is space in the stack for a new element, if not allocate a new array of twice the size of the current array & copy existing items to the new array.
2. Add the new element to the array element one past the stack pointer.
3. Increment the stack pointer to point to the new item.

Time Complexity: O(1)  
Space Complexity: O(c)  

### Pop

Steps:
1. Check whether there are any elements in the stack, if not throw.
2. Return the element pointed to by the stack pointer & decrement the stack pointer.

Time Complexity: O(1)  
Space Complexity: O(0)  

### Peek

Steps:
1. Check whether there are any elements in the stack, if not throw.
2. Return the element pointed to by the stack pointer.

Time Complexity: O(1)  
Space Complexity: O(0)  

Steps:
1. Get the count of the array & return.

Time Complexity: O(1)  
Space Complexity: O(0)  

## Notes
- Enhancement: The array could be replaced by a smaller array when items are
removed, this would save space, but would require additional copying.
