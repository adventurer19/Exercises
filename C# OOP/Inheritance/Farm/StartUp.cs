﻿using System;

namespace Farm
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var dog = new Dog();
            dog.Eat();
            dog.Bark();
            var cat = new Cat();
            cat.Eat();
            cat.Meow();
            

        }
    }
}
