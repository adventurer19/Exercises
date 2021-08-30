using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercises
{
    public class Box<T> : IComparable<T> where T : IComparable<T>

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


        public int CompareTo(T other) => Element.CompareTo(other);

        public int Count<T>(List<T> list, T readline) where  T : IComparable
        {
            return list.Count(word => word.CompareTo(readline) > 0);

        }
    }
}
