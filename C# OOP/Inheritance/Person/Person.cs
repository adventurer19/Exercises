using System;
using System.Collections.Generic;
using System.Text;

namespace Person
{
    public class Person
    {
        private string name;
        private int age;

        private string Name
        {
            get { return name; }
            set { name = value; }
        }

        private int Age
        {
            get { return Age; }
            set { age = value; }
        }

        public Person()
        {
            
        }

        public Person(string name, int age):this()
        {
            this.name = name;
            this.age = age;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append(string.Format("Name: {0}, Age: {1}", this.name, this.age));
            return sb.ToString();
        }
    }
}

