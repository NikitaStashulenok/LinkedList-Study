using LinkedListProj.Model;
using System;

namespace LinkedListProj
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new Model.LinkedList<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);
            Print(list);
            Console.WriteLine();
            list.Delete(3);
            list.Delete(1);
            list.Delete(58);
            Print(list);
            list.AppendHead(8);
            Print(list);
            list.InsertAfter(4, 8);
            Print(list);
            Console.WriteLine();
            Console.WriteLine();
            Console.ReadLine();
        }

        private static void Print(LinkedList<int> list)
        {
            foreach (var item in list)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

        }
    }
}
