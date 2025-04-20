using MB14.QueueExample;

var queue = new QueueAsArray();
//var queue = new QueueCircularBuffer();
//var queue = new QueueLinkedList();

var count = queue.Count;
Console.WriteLine("Count, Soll: 0, Ist: " + count);

queue.Enqueue("Nummer 1");
Console.WriteLine("Nummer 1 enqueued");

queue.Enqueue("Nummer 2");
Console.WriteLine("Nummer 2 enqueued");

count = queue.Count;
Console.WriteLine("Count, Soll: 2, Ist: " + count);

var peek = queue.Peek();
Console.WriteLine("Peek, Soll: Nummer 1, Ist: " + peek);

var dequeued = queue.Dequeue();
Console.WriteLine("Dequeue, Soll: Nummer 1, Ist: " + dequeued);

peek = queue.Peek();
Console.WriteLine("Peek, Soll: Nummer 2, Ist: " + peek);

dequeued = queue.Dequeue();
Console.WriteLine("Dequeue, Soll: Nummer 2, Ist: " + dequeued);

count = queue.Count;
Console.WriteLine("Count, Soll: 0, Ist: " + count);

queue.Enqueue("Nummer 1");
Console.WriteLine("Nummer 1 enqueued");

queue.Enqueue("Nummer 2");
Console.WriteLine("Nummer 2 enqueued");

queue.Clear();
count = queue.Count;
Console.WriteLine("Clear + Count, Soll: 0, Ist: " + count);
