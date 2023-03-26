using System;
using System.Collections.Generic;
using System.Text;

namespace BorderControl.Models
{
    class Citizen : IIdentifiable, IBirthable
    {
        public string Id { get; }
        public string Name { get; }
        public string Age { get; }
        public string Birthdate { get; }


        public Citizen(string name, string age, string id, string bithdate)
        {
            this.Name = name;
            this.Age = age;
            this.Id = id;
            this.Birthdate = bithdate;
        }
    }
}
