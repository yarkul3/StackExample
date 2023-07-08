using System;
using System.Collections.Generic;

public static class Program
{
    static void Main(string[] args)
    {
        Queue<int> queue = new Queue<int>();
        queue.Enqueue(1);
        queue.Enqueue(2);
        queue.Enqueue(3);

        Console.WriteLine($"'queue' contains {queue.Count} item(s)");
        Console.WriteLine("Printing the values:");
        foreach (var item in queue)
            Console.WriteLine(item);
    }
    
    // output:
    //
    // 'queue' contains 3 item(s)
    // Printing the values:
    // 1
    // 2
    // 3
}
