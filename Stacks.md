# Stacks
## What is a Stack?
A stack is a data structure that is characterized by the way data is stored and accessed. Stacks use a "Last in, First Out" rule which is just as it sounds. The last piece of data to be entered into the stack will be the first to be removed. Think of a stack of pancakes. As you cook the pancakes you will put them on a plate. The pancakes that are cooked first will be at the bottom of the stack while the pancakes cooked last will be at the top. Stacks in programming are no different. The values added first will be at the front or bottom of the stack and the values added last will be at the back or front of the stack.

## How does a Stack work?
As mentioned above when adding to or removing data from a stack it will use a "Last In, First Out" rule. See the image below for more details. To add to a stack you will use the "Push" operation. This will add a value to the top or back of the set. This is the equivalent of the "Add" operation used for lists. The remove a value you will use the "Pop" operation. The "Pop" operation will remove and return the value found at the back of the stack. Much like taking the pancake at the top of the stack.
</br></br>
![Stacks Image (Found at https://code-maze.com/stack-csharp/)](images/StackWithSteps.drawio.png)


## Stacks in C# and Efficiency of Common Set Operations
| Common Stack Operation | Description                                                           | C# Code                    | Performance/ Big O Notation              |
|------------------------|-----------------------------------------------------------------------|----------------------------|------------------------------------------|
| push(value)            | Adds "value" to the back of the stack.                                | mySet.Push(value)          | O(1)|
| pop()                  | Removes and returns the value the is at the back or top of the stack. | var Value = mySet.pop()    | O(1)|
| empty()                | Returns "True" if the stack is empty or has a length of zero.         | if (myStack.Count == 0)    | O(1)|
| size()                 | Return the size or number of items in the stack.                      | var length = myStack.Count | O(1)|

## Applications of Stacks


## Example Problem


## Student Problem
Please attempt the problem on your own before looking at the solution.

 

[Student Problem](ds1-problem)


## Solution for Student Problem
[Student Solution](ds1-solution)

## Important Terms
