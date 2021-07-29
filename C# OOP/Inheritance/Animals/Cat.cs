﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
   public class Cat:Animal
    {
        public Cat(string name, int age, string gender) : base(name, age, gender)
        {
            this.Sound = "Meow meow";
        }
    }
}
