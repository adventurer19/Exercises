using System;
using System.Collections.Generic;
using System.Text;

namespace Shopping_Spree
{
    public static class Validation
    {
        public static void Valid(string name,string ex)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException(ex);
            }
            
        }

        public static void ValidAge(decimal cost, string ex)
        {
            if (cost < 0)
            {
                throw new ArgumentException(ex);
            }
        }
    }
}
