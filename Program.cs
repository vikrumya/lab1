// Лабораторная работа #1
// http://ipm.ifmo.ru/wp-content/uploads/2016/02/s2lab01.pdf
// Вариант (null)

using System;
using System.Collections;

namespace Lab1
{
    using AL = ArrayList;

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== ArrayList ===");
            AL arrayList = new AL();
            for(int i = 0; i < 255; i++)
            {
                arrayList.Add(i);
            }
            Console.WriteLine("Count: {0}", arrayList.Count);
            Console.WriteLine("Binsearch for int 7: {0}", arrayList.BinarySearch(7));
            arrayList.Remove(7);
            Console.WriteLine("Count: {0}", arrayList.Count);
            Console.WriteLine("Binsearch for int 7: {0}", arrayList.BinarySearch(7));

            Console.WriteLine("=== Stack ===");
            int n;
            Stack stack = new Stack();
            Console.WriteLine("Enter number of elements: ");
            while (!int.TryParse(Console.ReadLine(), out n)) ;
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter elememt[{0}]: ", i);
                stack.Push(Console.ReadLine());
            }
            while(stack.Count > 0)
            {
                Console.WriteLine("Pop: {0}", stack.Pop());
            }

            Console.WriteLine("=== Queue ===");
            Random rnd = new Random();
            Queue queue = new Queue();
            for (int i = 0; i < 20; i++)
            {
                queue.Enqueue(rnd.NextDouble()*rnd.Next(100));
            }
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine("queue[{0}] = {1}", i, string.Format("{0:0.00}", queue.Dequeue()));
            }

            Console.WriteLine("=== Hashtable ===");
            Hashtable hashTable = new Hashtable();
            for (int i = 0; i < 20; i++)
            {
                hashTable.Add(i, rnd.Next(40));
            }
            Console.WriteLine("Is contains value 5? {0}", hashTable.ContainsValue(5).ToString());
            Console.WriteLine("Done!");
            Console.ReadKey();
        }
    }
}
