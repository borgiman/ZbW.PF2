namespace MB17;

public static class Program
{
    private static void Main()
    {
        var maxHeap = new MaxHeap(10);
        maxHeap.Enqueue(10);
        maxHeap.Enqueue(20);
        maxHeap.Enqueue(26);
        maxHeap.Enqueue(30);
        maxHeap.Enqueue(25);
        maxHeap.PrintHeap();

        maxHeap.Dequeue();
        maxHeap.PrintHeap();

        maxHeap.Dequeue();
        maxHeap.PrintHeap();

        maxHeap = new MaxHeap(10);
        maxHeap.EnqueueRecursive(10);
        maxHeap.EnqueueRecursive(20);
        maxHeap.EnqueueRecursive(15);
        maxHeap.EnqueueRecursive(30);
        maxHeap.EnqueueRecursive(25);
        maxHeap.PrintHeap();
    }
}