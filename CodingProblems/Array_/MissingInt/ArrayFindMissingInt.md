# Array Missing Int

- From Cracking the Coding Interview, Interview Questions 10.7

## Problem
Given an input file with four billion non-negative integers, provide an
algorithm to generate an integer that is not contained in the file.
Assume that you have 1 GB of memory available for this task.

FOLLOW UP

What if you have only 10 MB of memory? Assume that all the values are
distinct and we now have no more than one billion non-negative
integers.

## Requirements

- This solution is for the initial question, the follow up question is
addressed is another solution.

- We will write a generic algorithm that will handle a file of any size
containing integers within a specific range, optionally with a missing
value within the range.

- Note that the values in the file will be limited to 32-bit integers.

- Note that the problem description does not indicate what should happen
if there are multiple and different missing values, this case will not
be tested.

- Note that since we allow duplicates in order to find the missing value
we need a minimum buffer size of (maximum value - minimum value + 1) / 8
(+ 1 if maximum value - minimum value + 1 %& is non-zero). This is because
we need to be able to map all the possible values to a bit in the buffer
in order to determine the missing byte w/o loading the entire file.

- For the CtCI test case, we will use a 16 MB file with a minimum value
if 0 and a maximum value of int.MaxValue and a maximum buffer size of
1 GB.

- Method to implement:  

|            |                                                               |
|------------|---------------------------------------------------------------|
| Name       | FindMissingInt                                                |
| Parameters | The file name of the file to read                             |
|            | The size of the buffer we can use (in bytes)                  |
|            | The minimum value contained in the file (32-bit integer)      |
|            | The maximum value contained in the file (32-bit integer)      |
| Returns    | The missing value of -1 if there is no missing value          |

## Solutions
1. Standard