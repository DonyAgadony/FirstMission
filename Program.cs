using System.Collections;

class Program
{
    public static void Main()
    {
        Queue queue = new();
        queue.Enqueue(1);
        Queue queue1 = new();
        queue1.Enqueue(2);

        Queue rtn = MergeQueue(queue, queue1);
        foreach (object obj in rtn.ToArray())
        {
            Console.WriteLine(obj);
        }
    }
    public static Queue MergeQueue(Queue Q1, Queue Q2)
    {
        Queue rtn = new();
        while (Q1.Count > 0)
        {
            rtn.Enqueue(Q1.Dequeue());
        }
        while (Q2.Count > 0)
        {
            rtn.Enqueue(Q2.Dequeue());
        }
        return rtn;
    }
}