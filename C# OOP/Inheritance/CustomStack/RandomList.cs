using System;
using System.Collections.Generic;
using System.Text;

namespace CustomRandomList
{
    public class RandomList : List<string>
    {
        public string RandomString()
        {
            Random index = new Random();
            int idx = index.Next(this.Count);
            string result = this[idx];
            this.Remove(result);
            return result;
        }
    }
}
