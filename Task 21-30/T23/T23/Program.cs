using System;
using System.Collections.Generic;

class CheckoutQueue
{
    private Queue<string> queue;

    public CheckoutQueue()
    {
        queue = new Queue<string>();
    }

    public int Length => queue.Count;

    public void GoToQueue(string customerName)
    {
        queue.Enqueue(customerName);
        Console.WriteLine($"{customerName} joined the queue.");
    }

    public void ExitQueue()
    {
        if (queue.Count > 0)
        {
            string customerName = queue.Dequeue();
            Console.WriteLine($"{customerName} exited the queue.");
        }
        else
        {
            Console.WriteLine("The queue is empty.");
        }
    }
}

class Program
{
    static void Main()
    {
        CheckoutQueue checkoutQueue = new CheckoutQueue();

        checkoutQueue.GoToQueue("Customer 1");
        checkoutQueue.GoToQueue("Customer 2");
        checkoutQueue.GoToQueue("Customer 3");

        Console.WriteLine($"Queue Length: {checkoutQueue.Length}");

        checkoutQueue.ExitQueue();
        checkoutQueue.ExitQueue();
        checkoutQueue.ExitQueue();
        checkoutQueue.ExitQueue(); // Attempt to exit an empty queue

        Console.WriteLine($"Queue Length: {checkoutQueue.Length}");
    }
}
