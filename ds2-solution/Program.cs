﻿//You and a friend really enjoy looking for shed antlers in the spring.
//You each keep a tally of how many you find each week.
//You are able to shed hunt for ten weeks before it is too hot outside. 
//Please create a set for you and a set for your friends and store how many antlers you each found in the appropriate set.
//Use the quantities as follows. You: 6, 14, 1, 5, 10, 3, 12, 7, 9, 11) Friend: (8, 9, 7, 5, 10, 3, 15, 6, 4, 14).
//Find out by using the intersect function if you and you friend found the same amount in a particular week.
//Use the union function to find all numbers found data the two sets. There will be no duplicates in the new set.

using Microsoft.VisualBasic.CompilerServices;

public class Sets_Problem
{
    public static void Main()
    {
        HashSet<short> myQuantity = new HashSet<short>(); //create a set for your quantities
        myQuantity.Add(6);
        myQuantity.Add(14);
        myQuantity.Add(1);
        myQuantity.Add(5);
        myQuantity.Add(10); //6, 14, 1, 5, 10, 3, 12, 7, 9, 11)
        myQuantity.Add(3);
        myQuantity.Add(12);
        myQuantity.Add(7);
        myQuantity.Add(9);
        myQuantity.Add(11);
        
        HashSet<short> friendsQuantity = new HashSet<short>(); //create a set for your friends quantities
        friendsQuantity.Add(8);
        friendsQuantity.Add(9);
        friendsQuantity.Add(7);
        friendsQuantity.Add(5);
        friendsQuantity.Add(10); //(8, 9, 7, 5, 10, 3, 15, 6, 4, 14)
        friendsQuantity.Add(3);
        friendsQuantity.Add(15);
        friendsQuantity.Add(6);
        friendsQuantity.Add(4);
        friendsQuantity.Add(14);

        IEnumerable<short> intersect = myQuantity.Intersect(friendsQuantity);
        IEnumerable<short> union = myQuantity.Union(friendsQuantity);
        
        Console.WriteLine("------------Intersect----------");

        foreach (var number in intersect) //will return all shared quantities between the two sets
        
        {
            Console.WriteLine(number);
        }
        //Should return 6, 14, 5, 10, 3, 7, 9
        
        Console.WriteLine("----------Union---------"); //will return a new set with one of each number found in each set
                                                       //If the number is found in each set it will only appear once in the new set.

        foreach (var num in union)
        {
            Console.WriteLine(num); //should return 6, 14, 1, 5, 10, 3, 12, 7, 9, 11, 8, 15, 4
        }
    }
}
