# FindMatchingPairs

---

## Problem
Given two lists, return a list containing one element for each pair of matching elements.

---

## Requirements
- The result list does not need to be in any particular order.

- The method should throw an exception if either list is null.

- Method to implement:  

|            |                                                               |
|------------|---------------------------------------------------------------|
| Name       | FindMatchingPairs                                             |
| Parameters | The first list                                                |
|            | The second list                                               |
| Returns    | The resulting list                                            |

---

## Solutions
1. Character Count Maps - Use a pair of maps to get character counts, use those maps
to get the result list.
2. Sort and Parse - Sort the lists and parse in a single pass.