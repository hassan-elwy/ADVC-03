namespace Assignment12.task5
{
    public static class QueueHelper<T>
    {
        public static void printContentAndCount(Queue<T> queue)
        {
            Console.WriteLine("Count: " + queue.Count);
            Console.WriteLine("Items:");
            foreach (T item in queue)
            {
                Console.Write(" " + item + " ");
            }

            Console.WriteLine();
        }

        public static void PeekItem(Queue<T> queue)
        {
            Console.WriteLine("current item:" + queue.Peek());
        }

        public static void Dequeue(Queue<T> queue)
        {
            
            if(queue.TryDequeue(out T res))
            {

            Console.WriteLine("Printing:"+res );
            }
            else { Console.WriteLine("queue in empty"); }
           

        }
    }
}
