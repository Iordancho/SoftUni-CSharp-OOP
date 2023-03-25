using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShoppingSpree
{
    public class Person
    {
        private string name;
        private decimal money;
        private List<Product> products;

        public Person(string name, decimal money)
        {
            Name = name;
            Money = money;
            this.products = new List<Product>();
        }

        public string Name
        {
            get { return name; }
            private set 
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name cannot be empty");
                }
                name = value; 
            }
        }
        public decimal Money
        {
            get { return money; }
            private set 
            {
                if (value < 0)
                {
                    throw new ArgumentException("Money cannot be negative");
                }
                money = value; 
            }
        }
        public IReadOnlyCollection<Product> Products
        {
            get { return products; }
        }

        public  bool BuyProduct(Product product)
        {
            if (Money - product.Cost < 0)
            {
                return false;
            }
            products.Add(product);
            Money -= product.Cost;
            return true;
        }
        public override string ToString()
        {
            return $"{Name} - {string.Join(", ", Products.Select(x => x.Name))}";
        }
    }
}
