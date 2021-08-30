using System;
using System.Collections.Generic;
using System.Linq;

namespace CustomDoublyLinkedList
{
    public class CustomDoublyLinkedList<T>
    {
        public int Count { get; private set; }
        public ListNode<T> Head { get; set; }
        public ListNode<T> Tail { get; set; }
        //
        public CustomDoublyLinkedList()
        {
            
        }
        public CustomDoublyLinkedList(T input) : this()
        {
            ListNode<T> newNode = new ListNode<T>
            {
                Previus = null,
                Value = input,
                Next = null
            };
            Count++;
            Head = Tail = newNode;
        }

        public CustomDoublyLinkedList(IEnumerable<T>list):this(list.First())
        {
            bool isFirst = true;
            foreach (var item in list)
            {
                if (isFirst)
                {
                    isFirst = false;
                }
                else
                {
                    var node = new ListNode<T>
                    {
                        Value = item,
                        Previus = Tail,
                        Next = null
                    };
                    Tail.Next = node;
                    Tail = node; 
                }
            }
        }

        public void AddFirst(T input)
        {
            ListNode<T> node = new ListNode<T>() {Value = input};
            if (Count == 0)
            {
                Head = Tail = node;
                
            }
            else
            {
                node.Next = Head;
                Head.Previus = node;
                Head = node;
            }

            Count++;
        }
        public void AddLast(T input)
        {
            ListNode<T> node = new ListNode<T>() { Value = input };
            if (Count == 0)
            {
                Head = Tail = node;

            }
            else
            {
                node.Previus = Tail;
                Tail.Next = node;
                Tail = node;
            }

            Count++;
        }

        public T RemoveFirst()
        {
            if (Count > 0)
            {
                T result = Head.Value;
                ListNode<T> second = Head.Next;
                if (Head.Next == null)
                {
                    Tail = null;
                }
                else
                {
                    Head.Previus = null;
                }

                Head = second;
                Count--;
                return result;

            }
            throw new IndexOutOfRangeException("Empty List");
        }
        public T RemoveLast()
        {
            if (Count > 0)
            {
                T result = Tail.Value;
                ListNode<T> previusNode = Tail.Previus;
                if (Tail.Previus == null)
                {
                    Head = null;
                }
                else
                {
                    Tail.Previus.Next = null;
                }

                Tail = previusNode;
                Count--;
                return result;

            }
            throw new IndexOutOfRangeException("Empty List");
        }
        public void ForEach(Action<T> action)
        {
            ListNode<T> current = Head;
            while (current !=null)
            {
                action(current.Value);
                current = current.Next;
            }
        }

        public T[] ToArray()
        {
            if (Count == 0)
            {
                throw new IndexOutOfRangeException("Empty list");
            }
            T[] array = new T[Count];
            int index = 0;
            ListNode<T> current = Head;
            while (current!=null)
            {
                array[index] = current.Value;
                index++;
                current = current.Next;
            }
            return array;
        }
    }
}
