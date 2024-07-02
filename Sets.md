# Sets
## What is a Set?
Sets are a data structure in C# that are very similar to lists. They allow us to store an unlimited amount of data in them, and allow us to lookup this information and pull it out as we need. The difference with a  set is that it does not allow duplicates like lists do, it does not keep information in order, and every piece of information has a specific place for it when the set is created. This is done through the act of hashing.
## How does a Set work?
As mentioned above a set is very similar to a list. One key difference is the way in which that data is stored. Lists store data in the order in which it was entered unless you specifically add it to the front of th list. Sets store the data using hashing which is explained below. You add, remove, find a value, and get the set size in same way you would for a list. Those operations are listed in the table below.
## Hashing
An easy way to imagine a hash is as an equation for how we will store our information in our list. This equation is considered a **hashing function**. An attribute of a set is that they have low lookup and upload time. In order to get this performance, we could make our equation something like `index(n) = n+2`. This is a very basic example of the idea behind a hash. Every piece of data we store in our list now has a set index. If we want to store the number 5 in our list, we would store it at index 7.
</br></br>
A problem that you may notice that we will face with a system like this is that what happens as our numbers gets larger, and we get more of them? Storing a number like 6 wouldn't be so bad since then we just need to put it at index 8, however when you begin to store more data in the set the index will grow as well. With the simple equation used above you likely wouldn't have any issues but what if the equation looked more like `index(n) = n*3`? Then the index would really get out of hand. In a case like this we need to change the hashing equation to something that uses lower indexes and still allows for quick search and upload times. You could, instead of using 'n' you could you use a percentage of 'n' to reduce the jump in the index for each item in the set.


| Data Type        | C# Code             | Hash Code   |
|------------------|---------------------|-------------|
| postive integer  | 3.GetHashCode()     | 3           |
| negative integer | -3.GetHashCode()    | -3          |
| string           | "cat".GetHashCode() | -1599535192 |
| other string     | "dog".GetHashCode() | -73217838 |
|float/double | 3.14.GetHashCode() | 300063655 |
| boolean | true.GetHashCode() | 1 |
| List/Object | new List<string>().GetHashCode() | 27252167|

## Conflict Resolution for Sets
The first way to deal with conflicts in sets is called **open addressing**. Open addressing is when an item will be stored at the next available index. For example, if you enter the number 2 and your hashing function is supposed to put the number at index 4 but there is already another number there the number two will be moved to the next available index.This method can in turn create more conflicts with other data that is entered in the set.
</br></br>
The next method is called **chaining**. Chaining will try to resolve the same issue mentioned above which is when data is entered the hashing function tries to store the value in an already filled index. The difference is chaining will store a list of value at that index. This will reduce the amount of residual conflicts that are created. For both of these methods the performance is affected. Instead of O(1) it will now be O(n) because you will have to search through many different indexes or lists of value to find the correct value.

## Sets in C# and Efficiency of Common Set Operations
|Common BST Operation| Description                           | C# Code               | Performance/ Big O Notation                                                          |
|--------------------|---------------------------------------|-----------------------|--------------------------------------------------------------------------------------|
|add(value)| Adds "value" to the set               | mySet.add(value)      | O(1) - Performance of hashing the value as long as there is good confilct resolution |
|remove(value)| Remove "value" from the Set           | mySet.remove(value)   | O(1)- Performance of hashing the value as long as there is good confilct resolution  |
|member(value)| Determine if "value" is in the Set    | mySet.Contains(value) | O(1)- Performance of hashing the value as long as there is good confilct resolution  |
|size()| Return the number of items in the set | mySet.Count           | O(1)- Performance returing the size of the set                                       |

## Applications of Sets
* Determine unique values. Sets don't allow duplicates so if you need to find only unique values a set is a good option.
* Fast performance. Hashing allows for fast performance when adding, removing, and finding data.
* You can find common values or the intersection of two sets and the union of two sets.

## Example Problem
You are running a race and decide tou want to clock your time at a certain point during each lap. These times are added to a set. You want to find out what the fastest lap time was and also what the slowest lap time was. The race was eight laps in length.
[Example Problem](ds2-example)

## Student Problem
Please attempt the problem on your own before looking at the solution.

[Student Problem](ds2-problem)


## Solution for Student Problem
[Student Solution](ds2-solution)

## Important Terms
### Set
A set is a data structure that maps data to an index based on a hashing function. Sets will only hold unique data or because of the way the hashing function maps the data.
### Hashing
The process of mapping data to a specific index using a hashing function.
### Hashing Function
A function that converts data that is input into a set into a numerical index. This index is where that data will be stored within the set.
### Open Addressing
Open addressing is a method of removing conflicts within a set by storing data in the next available index when its hashed index is occupied. Open addressing has the potential to create more conflicts.
### Chaining
Chaining is a method of removing conflicts within a set by storing a list of value at an index in the hashing function sends multiply pieces of data to the same index.