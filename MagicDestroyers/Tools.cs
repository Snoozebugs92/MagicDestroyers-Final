namespace MagicDestroyers
{
    using System;
    public static class Tools
    {
        public static void ColorfullWrite(string input, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(input);
            Console.ResetColor();
        }

        public static void TypeSpecificColorfullWrite(string message, string type)
        {
            ConsoleColor color = ConsoleColor.White;
         
            switch (type)
            {
                case "MagicDestroyers.Characters.Melee.Warrior":
                    color = ConsoleColor.DarkYellow;
                    break;
                case "MagicDestroyers.Characters.Melee.Knight":
                    color = ConsoleColor.Yellow;
                    break;
                case "MagicDestroyers.Characters.Melee.Assassin":
                    color = ConsoleColor.Gray;
                    break;
                case "MagicDestroyers.Characters.Spellcasters.Mage":
                    color = ConsoleColor.Cyan;
                    break;
                case "MagicDestroyers.Characters.Spellcasters.Druid":
                    color = ConsoleColor.DarkMagenta;
                    break;
                case "MagicDestroyers.Characters.Spellcasters.Necromancer":
                    color = ConsoleColor.Green;
                    break;
                default:
                    color = ConsoleColor.White;
                    break;
            }
            Console.ForegroundColor = color;
            Console.WriteLine(message);
        }
    }

}

