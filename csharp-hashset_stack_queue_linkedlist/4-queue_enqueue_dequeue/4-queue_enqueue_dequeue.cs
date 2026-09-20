using System;
using System.Collections.Generic;

class MyQueue
{
    public static Queue<string> Info(Queue<string> aQueue, string newItem, string search)
    {
        Console.WriteLine("Number of items: {0}", aQueue.Count);

        if (aQueue.Count == 0)
            Console.WriteLine("Queue is empty");
        else
            Console.WriteLine("First item: {0}", aQueue.Peek());

        aQueue.Enqueue(newItem);

        bool contains = aQueue.Contains(search);
        Console.WriteLine("Queue contains \"{0}\": {1}", search, contains);

        if (contains)
        {
            string removed;
            do
            {
                removed = aQueue.Dequeue();
            }
            while (removed != search);
        }

        return aQueue;
    }
}
