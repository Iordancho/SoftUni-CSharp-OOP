using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PizzaCalories
{
    public class Pizza
    {
        private string name;
        private List<Topping> toppings;

        public string Name
        {
            get { return name; }
            set 
            {
                if (string.IsNullOrWhiteSpace(value) || value.Length > 15)
                {
                    throw new ArgumentException("Pizza name should be between 1 and 15 symbols.");
                }
                name = value; 
            }
        }
        public IReadOnlyCollection<Topping> Toppings
        {
            get { return toppings; }
        }

        public void AddTopping(Topping topping)
        {
            if (toppings.Count == 10)
            {
                throw new ArgumentException("Number of toppings should be in range [0..10].");
            }
            toppings.Add(topping);
        }

        public Dough Dough { get; set; }

        public Pizza(string name, Dough dough)
        {
            Name = name;
            this.toppings = new List<Topping>();
            this.Dough = dough;
        }

        public double TotalCalories
            => Dough.Calories + toppings.Sum(x => x.Calories);

        public override string ToString()
        {
            return $"{this.name} - {TotalCalories:f2} Calories.";
        }
    }
}
