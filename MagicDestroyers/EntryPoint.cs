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
            List<Spellcaster> spellCasterTeam = new List<Spellcaster>();

            foreach (var character in characters)
            {
                if (character is Melee)
                {
                    meleeTeam.Add((Melee)character);
                }
                else if (character is Spellcaster)
                {
                    spellCasterTeam.Add((Spellcaster)character);
                }
            }

            while (!gameOver)
            {
                // Approach 1, Make the attack method take the character as an argument. meleeTeam[0].Attack(spellCasterTeam[0]);
                // Approach 2, Make method called TakeDamage. spellCasterTeam[0].TakeDamage(meleeTeam[0]);
                // Approach 3, Use the TakeDamage method but give a int damage input parameter.

                // 1. Take a random Melee.
                // 2. Take a random Spellcaster.                

                // 3. Melee attacks Spellcaster.
                // 3.1 Check character status and remove from team if needed.
                // 3.2 If dead choose another character from the team.
                meleeTeam[0].TakeDamage(spellCasterTeam[0].Attack(), spellCasterTeam[0].Name);

                // 4. Spellcaster attacks Melee.
                // 4.1 Check character status and remove from team if needed.
                // 4.2 If dead choose another character from the team.
                spellCasterTeam[0].TakeDamage(meleeTeam[0].Attack(), meleeTeam[0].Name);

                // 5. If no characters are alive from either one of the teams gameOver = true

            }
        }
    }
}
