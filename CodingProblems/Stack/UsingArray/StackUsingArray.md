# StackUsingArray

### Problem
Implement a stack using an array (fixed size).

### Notes
- If a variable sized data structure is used then the problem is trivial, just add & take from the DS as needed.
- The following operations should be defined: Push, Pop, Peek, Count
- No need to clear removed elements in stack.

### Solution 1 - Fixed Size

#### Solution Specific Assumptions
- Stack's capacity is fixed (Set at construction).

##### Overview
Implement the stack using an array. When an item is pushed add to the array & increment the stack pointer. When an element is poped, get the element at the stack pointer & decrement the stack pointer.

#### Alg
Push:  
1. Check whether there is space in the stack for a new element, if not throw.
2. Add the new element to the array element one past the stack pointer.
3. Incrment the stack pointer to point to the new item.

Pop:
1. Check whether there are any elements in the stack, if not throw.
2. Return the element pointed to by the stack pointer & decrement the stack pointer.

Peek:
1. Check whether there are any elements in the stack, if not throw.
2. Return the element pointed to by the stack pointer.

#### Big O
Creation:
Time - O(1)
Space - O(Capacity)

Push:
Time - O(1)
Space - O(0)

Pop:
Time - O(1)
Space - O(0)

Peek:
Time - O(1)
Space - O(0)

Count:
Time - O(1)
Space - O(0)

#### Notes
- We could save space by waiting to construct the stack when an element is first added, but this would make the code more complex.

### Solution 1 - Variable Size

#### Solution Specific Assumptions
- Stack can grow as needed.

##### Overview
Implement the stack using an array. When an item is pushed check whether there is space in the array, if not update the array appropriately then add to the array & increment the stack pointer. When an element is poped, get the element at the stack pointer & decrement the stack pointer.

Once a larger array is allocated it is never deallocated (i.e.) the array never shrinks in size.

#### Alg
Push:  
1. Check whether there is space in the stack for a new element, if not allocate a new array of twice the size of the current array & copy existing items to the new array.
2. Add the new element to the array element one past the stack pointer.
3. Incrment the stack pointer to point to the new item.

Pop:
1. Check whether there are any elements in the stack, if not throw.
2. Return the element pointed to by the stack pointer & decrement the stack pointer.

Peek:
1. Check whether there are any elements in the stack, if not throw.
2. Return the element pointed to by the stack pointer.

#### Big O
Creation:
Time - O(1)
Space - O(1)

Push:
Time - O(1)
Space - O(1) (2 initially, doubling each time that more space is needed for new items)

Pop:
Time - O(1)
Space - O(0)

Peek:
Time - O(1)
Space - O(0)

Count:
Time - O(1)
Space - O(0)

#### Notes
- Key differences between fixed and variable size stack solutions:
1. With fixed size the size is specified in the constructor & the array is
allocated immediately, with variable size no size is specified and the array
is not allocated until items are added.
2. In the variable size case, if an attempt is made to add an item to the
stack which will not fit, a new array of twice the size (or 2 if no existing array)
is immediately allocated and the contents of the existing array copied.
Then the new item is added.