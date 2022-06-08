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
            Random rng = new Random();

            Melee currentMelee;
            Spellcaster currentSpellcaster;

            bool gameOver = false;

            List<Character> characters = new List<Character>()
            {
                new Warrior(),
                new Knight(),
                new Assassin(),
                new Mage(),
                new Necromancer(),
                new Druid()
            };

            List<Melee> meleeTeam = new List<Melee>();
            List<Spellcaster> spellcasterTeam = new List<Spellcaster>();

            foreach (var character in characters)
            {
                if (character is Melee)
                {
                    meleeTeam.Add((Melee)character);
                }
                else if (character is Spellcaster)
                {
                    spellcasterTeam.Add((Spellcaster)character);
                }
            }
                // Approach 1, Make the attack method take the character as an argument. meleeTeam[0].Attack(spellCasterTeam[0]);
                // Approach 2, Make method called TakeDamage. spellCasterTeam[0].TakeDamage(meleeTeam[0]);
                // Approach 3, Use the TakeDamage method but give a int damage input parameter.


            while (!gameOver)
            {
                // (Random)Character Selection 
                currentMelee = meleeTeam[rng.Next(0, meleeTeam.Count)];
                currentSpellcaster = spellcasterTeam[rng.Next(0, spellcasterTeam.Count)];               

               
                currentSpellcaster.TakeDamage(currentMelee.Attack(), currentMelee.Name, currentMelee.GetType().ToString());
                if (!currentSpellcaster.IsAlive)
                {
                    spellcasterTeam.Remove(currentSpellcaster);

                    if (spellcasterTeam.Count == 0)
                    {
                        currentMelee.WonBattle();
                        Tools.ColorfullWrite("Melee team wins!", ConsoleColor.Red);
                        break;
                    }
                    else
                    {
                    currentSpellcaster = spellcasterTeam[rng.Next(0, spellcasterTeam.Count)];
                    }

                }

                currentMelee.TakeDamage(currentSpellcaster.Attack(), currentSpellcaster.Name, currentSpellcaster.GetType().ToString());
                if (!currentMelee.IsAlive)
                {
                    meleeTeam.Remove(currentMelee);

                    if (meleeTeam.Count == 0)
                    {
                        currentSpellcaster.WonBattle();
                        Console.WriteLine("Spellcaster team wins!", ConsoleColor.Green);
                        break;
                    }
                    else
                    {
                    currentMelee = meleeTeam[rng.Next(0, meleeTeam.Count)];
                    }
                }
            }
        }
    }
}
