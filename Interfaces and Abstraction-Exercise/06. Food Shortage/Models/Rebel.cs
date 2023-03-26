using BorderControl.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BorderControl.Models
{
    public class Rebel : IBuyer
    {
        public string Name { get; }
        public string Age { get; }
        public string Group { get; }
        private int food = 0;

        public Rebel(string name, string age, string group)
        {
            Name = name;
            Age = age;
            Group = group;
        }

        public int Food
        {
            get { return food; }
            private set { food = value; }
        }
        public void BuyFood()
        {
            this.food += 5;
        }
    }
}
