using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ImplementationLinkedList
{
    public class CustomedLinkList
    {
        public int Count { get; private set; }

        public Node Head { get; set; }
        public Node Tail { get; set; }

        public CustomedLinkList()
        {
            
        }

        public CustomedLinkList(int input) : this()
        {
            Node newNode = new Node()
            {
                Previus = null,
                Value = input,
                Next = null
            };
            Count++;
            Head = Tail = newNode;
        }

        public CustomedLinkList(IEnumerable<int>listeEnumerable):this(listeEnumerable.First())
        {
            bool isFirst = true;
            foreach (var item in listeEnumerable)
            {
                if (isFirst)
                {
                    isFirst = false;
                }
                else
                {
                    var node = new Node()
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

        public void AddFirst(int input)
        {
            var node = new Node() {Value = input};
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
        public void AddLast(int input)
        {
            var node = new Node() { Value = input };
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

        public int RemoveFirst()
        {
            if (Count > 0)
            {
                int result = Head.Value;
                if (Head.Next == null)
                {
                    Tail = null;
                }
                else
                {
                    Head.Previus = null;
                }
                Head = Head.Next;
                Count--;
                return result;

            }
            throw new IndexOutOfRangeException("Empty List");
        }
        public int RemoveLast()
        {
            if (Count > 0)
            {
                int result = Tail.Value;
                if (Tail.Previus == null)
                {
                    Head = null;
                }
                else
                {
                    Tail.Previus.Next = null;
                }
                Tail =Tail.Previus;
                Count--;
                return result;

            }
            throw new IndexOutOfRangeException("Empty List");
        }
        public void Foreach(Action<int> action)
        {
            Node current = Head;
            while (current !=null)
            {
                action(current.Value);
                current = current.Next;
            }
        }

        public int[] ToArray()
        {
            if (Count == 0)
            {
                throw new IndexOutOfRangeException("Empty list");
            }
            int[] array = new int[Count];
            int index = 0;
            Node current = Head;
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
