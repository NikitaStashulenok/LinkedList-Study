using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace LinkedListProj.Model
{
    public class TwoWaysLinkedList<T> : IEnumerable<T>
    {
        public TwoWaysItem<T> Head { get; set; }
        public TwoWaysItem<T> Tail { get; set; }
        public int Count { get; set; }
        public TwoWaysLinkedList() { }
        public TwoWaysLinkedList(T data)
        {
            var item = new TwoWaysItem<T>(data);
            Head = item;
            Tail = item;
            Count = 1;
        }
        public void Add(T data)
        {
            var item = new TwoWaysItem<T>(data);
            if (Count == 0)
            {
                Head = item;
                Tail = item;
                Count = 1;
                return;
            }
            Tail.Next = item;
            item.Previous = Tail;
            Tail = item;
            Count++;
        }
        public void Delete(T data)
        {
            var current = Head;
            while(current != null)
            {
                if(current.Data.Equals(data))
                {
                    current.Previous.Next = current.Next;
                    current.Next.Previous = current.Previous;
                    Count--;
                    return;
                }

                current = current.Next;
            }
        }
        public TwoWaysLinkedList<T> Reverse()
        {
            var list = new TwoWaysLinkedList<T>();
            var current = Tail;
            while (current != null)
            {
                list.Add(current.Data);                
                current = current.Previous;
            }
            return list;
        }

        public IEnumerator GetEnumerator()
        {
            var current = Head;
            while(current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            return (IEnumerator<T>)GetEnumerator();
        }
    }
}
