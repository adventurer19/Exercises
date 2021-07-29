using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    public abstract class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public string Sound { get; set; }

        protected Animal(string name, int age, string gender)
        {
            Name = name;
            Age = age;
            Gender = gender;
        }

        public virtual string ProduceSound()
        {
            return this.Sound;

        }

        public override string ToString()
        {
            return this.GetType().Name + Environment.NewLine +
                   $"{this.Name} {this.Age} {this.Gender}";
        }
    }
}
