using System;
using System.Linq;

namespace PizzaCalories
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string[] pizzaInfo = Console.ReadLine().Split();
                string pizzaName = pizzaInfo[1];
                string[] doughtInfo = Console.ReadLine().Split();
                string doughType = doughtInfo[1];
                string bakingTechnique = doughtInfo[2];
                int doughGrams = int.Parse(doughtInfo[3]);

                Dough dough = new Dough(doughType, bakingTechnique, doughGrams);
                Pizza pizaa = new Pizza(pizzaName, dough);

                string command;
                while ((command = Console.ReadLine()) != "END")
                {
                    string[] tokens = command.Split();
                    string toppingType = tokens[1];
                    int toppingWeigth = int.Parse(tokens[2]);
                    Topping topping = new Topping(toppingType, toppingWeigth);
                    pizaa.AddTopping(topping);
                }

                Console.WriteLine(pizaa);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            
        }
    }
}
