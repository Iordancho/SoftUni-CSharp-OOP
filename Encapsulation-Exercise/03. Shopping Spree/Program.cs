using System;
using System.Collections.Generic;

namespace ShoppingSpree
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string[] personInfo = Console.ReadLine().Split(new char[] { '=', ';' }, StringSplitOptions.RemoveEmptyEntries);
                string[] productInfo = Console.ReadLine().Split(new char[] { '=', ';' }, StringSplitOptions.RemoveEmptyEntries);
                Dictionary<string, Person> people = new Dictionary<string, Person>();
                Dictionary<string, Product> products = new Dictionary<string, Product>();

                for (int i = 0; i < personInfo.Length; i += 2)
                {
                    string name = personInfo[i];
                    decimal money = decimal.Parse(personInfo[i + 1]);
                    Person person = new Person(name, money);
                    people.Add(name, person);
                }

                for (int i = 0; i < productInfo.Length; i += 2)
                {
                    string name = productInfo[i];
                    decimal cost = decimal.Parse(productInfo[i + 1]);
                    Product product = new Product(name, cost);
                    products.Add(name, product);
                }

                string command;
                while ((command = Console.ReadLine()) != "END")
                {
                    string personName = command.Split()[0];
                    string productName = command.Split()[1];

                    Person person = people[personName];
                    Product product = products[productName];

                    bool isBought = person.BuyProduct(product);

                    if (!isBought)
                    {
                        Console.WriteLine($"{personName} can't afford {productName}");
                    }
                    else
                    {
                        Console.WriteLine($"{personName} bought {productName}");
                    }
                }

                foreach (var (name, person) in people)
                {
                    //string productsInfo = person.Products.Count > 0
                    //     ? string.Join(", ", person.Products)
                    //     : "Nothing bought";
                    //Console.WriteLine($"{name} - {productInfo}");
                    if (person.Products.Count > 0)
                    {
                        Console.WriteLine(person);
                    }
                    else
                    {
                        Console.WriteLine($"{name} - Nothing bought");
                    }
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
           
        }
    }
}
