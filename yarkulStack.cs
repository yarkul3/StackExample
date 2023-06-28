using System;
using System.Collections;
 
class YarkulStack {
 
    // Main Method
    static public void Main()
    {
 
        // Create a stack
        // Using Stack class
        Stack my_stack = new Stack();
 
        // Adding elements in the Stack
        my_stack.Push("Geeks");
        my_stack.Push("geeksforgeeks");
        my_stack.Push('G');
        my_stack.Push(null);
        my_stack.Push(1234);
        my_stack.Push(490.98);
 
        // Accessing the elements
        // of my_stack Stack
        // Using foreach loop
        foreach(var elem in my_stack)
        {
            Console.WriteLine(elem);
        }
    }
}
