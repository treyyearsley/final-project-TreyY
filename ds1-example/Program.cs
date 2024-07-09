
using System.Collections;

public class Stacks
{
    public static void Main()
    {
        Stack sentence = new Stack(); //create a new stack
        
        //Add twevle words for your sentence
        sentence.Push("I");
        sentence.Push("prefer");
        sentence.Push("Mtn");
        sentence.Push("Dew");
        sentence.Push("but");
        sentence.Push("I");
        sentence.Push("have");
        sentence.Push("to");
        sentence.Push("settle");
        sentence.Push("for");
        sentence.Push("Coca");
        sentence.Push("Cola");
        
        //Remove the last two words so you can change them
        sentence.Pop();
        sentence.Pop();
        
        //Add two new words
        sentence.Push("Sierra");
        sentence.Push("Mist");
        
        //Read and return the words in the Stack.
        foreach (var word in sentence)
        {
            Console.WriteLine(word); //The words in the Sentence will be listed backwards because of the "Last In, First Out" Rules.
        }
    }
}
    
