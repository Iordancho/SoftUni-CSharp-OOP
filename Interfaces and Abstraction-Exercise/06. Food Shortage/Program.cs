using System;
using System.Collections.Generic;
using System.Linq;
using BorderControl;
using BorderControl.Interfaces;
using BorderControl.Models;

class StartUp
{
    static void Main()
    {
        List<IBuyer> creatures = new List<IBuyer>();

        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            string[] tokens = Console.ReadLine().Split();
            
            if (tokens.Length == 4)
            {
                creatures.Add(new Citizen(tokens[0], tokens[1], tokens[2], tokens[3]));
            }
            else if (tokens.Length == 3)
            {
                creatures.Add(new Rebel(tokens[0], tokens[1], tokens[2]));
            }
        }
        int totalFood = 0;
        string name;
        while ((name = Console.ReadLine()) != "End")
        { 
            var creature = creatures.FirstOrDefault(c => c.Name == name);
            if (creature != null)
            {
                creature.BuyFood();
                
            }
        }
        Console.WriteLine(creatures.Sum(c => c.Food));
    }
}