using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace Exercises
{
    public class Box<T>
    {
        public List<T> Elemenets { get; }
        public T Element { get; }
        public Box(T element)
        {
            Element = element;
        }

        public Box(List<T> elementsList)
        {
            this.Elemenets = elementsList;
        }

        public void Swap(List<T> elements, int indexOne, int indexTwo)
        {
            T firstEl = elements[indexOne];
            elements[indexOne] = elements[indexTwo];
            elements[indexTwo] = firstEl;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            foreach (var itemElemenet in Elemenets)
            {
                sb.AppendLine($"{itemElemenet.GetType()}: {itemElemenet}");

            }

            return sb.ToString().TrimEnd();
        }
    }
}
