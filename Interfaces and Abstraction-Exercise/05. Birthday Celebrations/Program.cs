using System;
using System.Collections.Generic;
using BorderControl;
using BorderControl.Models;

class StartUp
{
    static void Main()
    {
        List<IBirthable> creatures = new List<IBirthable>();

        string input;
        while ((input = Console.ReadLine()) != "End")
        {
            var tokens = input.Split();
            if (tokens[0] == "Pet")
            {
                creatures.Add(new Pet(tokens[1], tokens[2]));
            }
            else if (tokens[0] == "Citizen")
            {
                creatures.Add(new Citizen(tokens[1], tokens[2], tokens[3], tokens[4]));
            }
        }

        string birthDate = Console.ReadLine();
        foreach (var c in creatures)
        {
            if (c.Birthdate.EndsWith(birthDate))
            {
                Console.WriteLine(c.Birthdate);
            }
        }
    }
}