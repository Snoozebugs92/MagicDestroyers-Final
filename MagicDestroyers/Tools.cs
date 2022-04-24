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
    }

}

