using LinkedListProj.Model;
using System;

namespace LinkedListProj
{
    class Program
    {
        static void Main(string[] args)
        {
            var circularList = new CircularLinkedList<int>();
            circularList.Add(1);
            circularList.Add(2);
            circularList.Add(3);
            circularList.Add(4);
            circularList.Add(5);
            circularList.Add(6);
            foreach(var item in circularList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            circularList.Delete(4);
            foreach (var item in circularList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("=-=-=-=-=-=-=");
            var list = new Model.LinkedList<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);
            //Print(list);
            Console.WriteLine();
            list.Delete(3);
            list.Delete(1);
            list.Delete(58);
            Print(list);
            list.AppendHead(8);
            //Print(list);
            list.InsertAfter(4, 8);
            //Print(list);
            Console.WriteLine();
            Console.WriteLine();

            var twowaysList = new TwoWaysLinkedList<int>();
            twowaysList.Add(1);
            twowaysList.Add(2);
            twowaysList.Add(3);
            twowaysList.Add(4);
            twowaysList.Add(5);
            twowaysList.Delete(3);
            foreach(var item in twowaysList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            twowaysList.Delete(3);
            foreach (var item in twowaysList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            var reverse = twowaysList.Reverse();
            foreach(var item in reverse)
            {
                Console.WriteLine(item);
            }

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
