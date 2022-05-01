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

            int currentMelee = 0;
            int currentSpellcaster = 0;

            bool gameOver = false;

            List<Character> characters = new List<Character>()
            {
                new Warrior(),
                new Warrior(),
                new Warrior(),
                new Mage(),
                new Mage(),
                new Mage()
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
                currentMelee = rng.Next(0, meleeTeam.Count);
                currentSpellcaster = rng.Next(0, spellcasterTeam.Count);               

                // Melee attacks Spellcaster.
                meleeTeam[currentSpellcaster].TakeDamage(spellcasterTeam[currentSpellcaster].Attack(), spellcasterTeam[currentSpellcaster].Name);
                // 3.1 Check character status and remove from team if needed.
                // 3.2 If dead choose another character from the team.
                if (!meleeTeam[currentMelee].IsAlive)
                {
                    meleeTeam.Remove(meleeTeam[currentMelee]);

                    if (meleeTeam.Count == 0)
                    {
                        spellcasterTeam[currentMelee].WonBattle();
                        Console.WriteLine("Spellcaster team wins!");
                        break;
                    }
                    else
                    {
                    currentMelee = rng.Next(0, meleeTeam.Count);
                    }

                }

                // 4. Spellcaster attacks Melee.
                spellcasterTeam[currentSpellcaster].TakeDamage(meleeTeam[currentMelee].Attack(), meleeTeam[currentMelee].Name);
                // 4.1 Check character status and remove from team if needed.
                // 4.2 If dead choose another character from the team.
                if (!spellcasterTeam[currentSpellcaster].IsAlive)
                {
                    spellcasterTeam.Remove(spellcasterTeam[currentSpellcaster]);

                    if (spellcasterTeam.Count == 0)
                    {
                        meleeTeam[currentMelee].WonBattle();
                        Console.WriteLine("Melee team wins!");
                        break;
                    }
                    else
                    {
                    currentSpellcaster = rng.Next(0, spellcasterTeam.Count);
                    }
                }

                // 5. If no characters are alive from either one of the teams gameOver = true

            }
        }
    }
}
