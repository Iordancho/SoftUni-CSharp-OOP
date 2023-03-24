using System;
using System.Collections.Generic;
using System.Text;

namespace CustomRandomList
{
    public class RandomList : List<string>
    {
        public string RandomString(List<string> list)
        {
            Random random = new Random();
            return list[random.Next(0, Count)];
        }
    }
}
