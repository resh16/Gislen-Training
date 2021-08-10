using System;


namespace QueueImplementation
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedListQueueCaller();

            Console.ReadLine();
        }

        public static void LinkedListQueueCaller()
        {
            LinkedListQueue myQueue = new LinkedListQueue();

            myQueue.Enqueue(10);
            myQueue.Enqueue(20);
            myQueue.Enqueue(30);
            myQueue.Enqueue(40);
            myQueue.Enqueue(50);

            myQueue.PrintQueue();

            myQueue.Dequeue();
            myQueue.Enqueue(60);

            myQueue.PrintQueue();
            myQueue.Dequeue();
            myQueue.PrintQueue();



        }
    }
}
