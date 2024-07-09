# Trees
## What is a Tree?
A tree is a data structure that uses nodes to store data. Every tree will have a root node and other nodes that branch off the root node. These nodes are connected together by pointers. There are three tpyes of Trees that we will look as: Binary Trees, Binary Search Trees, and Balanced Binary Search Trees.

## Binary Tree


## Trees in C# and Efficiency of Common Set Operations
| Common Tree Operation | Description                                                                                                       | Performance/ Big O Notation                                                                                                                  |
|-----------------------|-------------------------------------------------------------------------------------------------------------------|----------------------------------------------------------------------------------------------------------------------------------------------|
| insert (value)        | Insert a value into the tree.                                                                                     | O(log n) - Uses recursion to find the next available node to store data in.                                                                  |
| remove(value)         | Remove a value from a tree.                                                                                       | O(log n) - Uses recursion to search the tree for a claue then removes that value.                                                            |
| contains(value)       | Determines if a value exists within the tree.                                                                     | O(log n) - Uses recursion to search the tree for a value.                                                                                    |
| traverse_forward      | Visits all objects in the tree from smallest to largest.                                                          | O(n) - Uses recursion to traverse the left subtree then the right subtree.                                                                   |
| traverse_reverse      | Visits all objects in the tree from largest to smallest                                                           | O(n) - Uses recursion to traverse the right subtree then the left subtree.                                                                   |
| height(node)          | Determines the height of the tree. If the overall height of the tree is needed, the root node should be provided. | O(n) - Uses recursion to find the height of the left and the right subtrees. The maximum height is returned. Add one more for the root node. |
| size()                | Returns the size of the tree.                                                                                     | O(1) - The size is maintained within the BST class.                                                                                          |
| empty()               | Returns true if the root node is empty.                                                                           | O(1) - Comparing the root node or the size.                                                                                                  |

## Applications of Trees


## Example Problem
[Example Problem](ds3-example)

## Student Problem
Please attempt the problem on your own before looking at the solution.



[Student Problem](ds3-problem)


## Solution for Student Problem
[Student Solution](ds3-solution)

## Important Terms
### Tree
A tree is a data structure that starts with a root node and branches off according to relation between the nodes. There are no disconnected nodes or any loops.
### Binary Tree
A tree that has two children per node.
### Binary Search Tree
A tree that sorts data by putting data that is less than the root to the left and data the is more than the root to the right. Binary Search Trees increase efficiency in searching algorithms
### Balanced Binary Search Tree
A binary search tree that is restructured to be balanced. When searching a balanced binary search tree you get a performance of O(log n).
### Node
A value that is entered into a tree. It contains the value and the pointers to any children nodes.
### Root
The first node in a tree.
### Parent
A node that connects to children nodes.
### Child
A node that connects from a parent node.
### Leaf
A node that has no children nodes.
### Traverse
The process of visiting each node in a tree and the values stored in the nodes. Used often using recursion to navigate from the leaf node with the smallest value to the leaf node that contains the largest value.
### Recursion
The process a procedure goes through when one of the steps of the procedure is calling the procedure itself.
### Subtree
A subtree is a subset of a tree made when a new node is selected to be the root node and all of the children nodes are included.
### Balanced
A tree is balanced when the height of a tree is the same from the root node to each of the leaf nodes.
### Red Black Tree
A binary search tree that is self-balancing

