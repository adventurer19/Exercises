using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
   public class Tomcat:Cat
   {
       private const string gender = "Male";
        public Tomcat(string name, int age) : base(name,age,gender)
        {
            this.Sound = "MEOW";
        }
    }
}
