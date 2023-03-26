using BorderControl.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BorderControl.Models
{
    internal class Citizen : IIdentifiable, IBirthable, IBuyer
    {
        
        public string Id { get; }
        public string Name { get; }
        public string Age { get; }
        public string Birthdate { get; }
        private int food = 0;

        public int Food
        {
            get { return food; }
            private set { food = value; }
        }


        public Citizen(string name, string age, string id, string bithdate)
        {
            this.Name = name;
            this.Age = age;
            this.Id = id;
            this.Birthdate = bithdate;
        }

        public void BuyFood()
        {
            this.food += 10;
        }
    }
}
