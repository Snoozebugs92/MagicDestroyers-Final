using MagicDestroyers.Characters;
using MagicDestroyers.Characters.Melee;
using MagicDestroyers.Characters.Spellcasters;
using System;
using System.Collections.Generic;

namespace MagicDestroyers
{
    class EntryPoint
    {
        static void Main()
        {
            Warrior warriorOne = new Warrior();
            Mage mageOne = new Mage();

            Character secondWarrior = new Warrior();

            List<Character> theCharacters = new List<Character>();

            theCharacters.Add(warriorOne);
            theCharacters.Add(mageOne);

            for (int i = 0; i < theCharacters.Count; i++)
            {
                Console.WriteLine(theCharacters[i]);
            }

            Console.WriteLine();

            Console.WriteLine($"Warriors name is {warriorOne.Name}.");
            Console.WriteLine($"{warriorOne.Name}'s level is: {warriorOne.Level}");
            Console.WriteLine($"{warriorOne.Name}'s healthpoints are: {warriorOne.HealthPoints}");
            Console.WriteLine($"{warriorOne.Name}'s faction is: {warriorOne.Faction}");

            Console.WriteLine();

            Console.WriteLine($"Mage's name is {mageOne.Name}.");
            Console.WriteLine($"{mageOne.Name}'s level is: {mageOne.Level}");
            Console.WriteLine($"{mageOne.Name}'s healthpoints are: {mageOne.HealthPoints}");
            Console.WriteLine($"{mageOne.Name}'s faction is: {mageOne.Faction}");
        }
    }
}
