# Solution 2 - Stable - Use Dummy Nodes

## Requirements
- The algorithm should use 'Dummy' nodes to simplify the code.

## Implemenation
- The implementation is the same as Solution 1 except:
1. When creating the 2 lists we add 'dummy' elements to both lists, this
simplifies the code for adding nodes to the lists because the empty list
case does not have to be considered.
2. When checking whether any nodes were added to the before list we need
to check the Next ref for null, not the before list start node since this
is always valid. Further if the before list is empty except for the dummy
node we set the head pointer to the next pointer of dummy node in the after
list.
3. Otherwise, when attaching the node lists we attach the next pointer of the
last node in the before list to next pointer of the dummy node in the after
list and update the head reference to point to the Next pointer of the dummy
node in the before list.

## Notes
- This option does not gain much, a few lines of code are eliminated but
reattaching the lists becomes more complex and thus error prone.