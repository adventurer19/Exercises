using System;
using System.Collections.Generic;
using System.Text;

namespace TupleTask
{
    
    public class Tuple <TFirst,TSecond>
    {
        public TFirst FirstElement { get; private set; }
        public TSecond SecondElement { get;private set; }

        public Tuple(TFirst firstElement, TSecond secondElement)
        {
            FirstElement = firstElement;
            SecondElement = secondElement;
        }

        public override string ToString()
        {
            return $"{FirstElement} -> {SecondElement}";
        }
    }
}
