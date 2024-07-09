//You like to lift weights and decide you want to track your progress on the bench press.
//You track your last set for each workout. When you track it is formatted like this "225 x 10".
//Weight by the number of reps.
//After ten weeks of tracking you decide to look back at your last five weeks and see what progress you have made.
//Use the "Count" Operation to make sure you have tracked ten weeks.
//The use the "Pop" Operation to remove and store the Last five entries. Then display those entries.

using System.Collections;

public class Stacks
{
    public static void Main()
    {
        Stack benchPress = new Stack(); //Create a new stack
        
        //Add ten weeks worth of data
        benchPress.Push("225 x 15");
        benchPress.Push("225 x 18");
        benchPress.Push("275 x 7");
        benchPress.Push("295 x 5");
        benchPress.Push("295 x 5");
        benchPress.Push("315 x 3");
        benchPress.Push("325 x 2");
        benchPress.Push("330 x 1");
        benchPress.Push("340 x 1");
        benchPress.Push("345 x 1");
        
        
        //Get the size of your stack
        var length = benchPress.Count;
        Console.WriteLine($"You have tracked {length} weeks.");
        
        //Pop and store the last five values
        var week10 = benchPress.Pop();
        var week9 = benchPress.Pop();
        var week8 = benchPress.Pop();
        var week7 = benchPress.Pop();
        var week6 = benchPress.Pop();
       
        //Display the last five weeks
        Console.WriteLine($"Week 6- {week6}");
        Console.WriteLine($"Week 7- {week7}");
        Console.WriteLine($"Week 8- {week8}");
        Console.WriteLine($"Week 9- {week9}");
        Console.WriteLine($"Week 10- {week10}");
        
        //Results will vary based on the values added to the stack.

    }
}