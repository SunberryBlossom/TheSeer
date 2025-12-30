using System;
using System.Collections.Generic;
using System.Text;
using TheSeer.Presentation.Helpers;

namespace TheSeer.Presentation.Views
{
    public static class LogoView
    {
        public static void DisplayFirst()
        {
            ConsoleColor logoColor = ConsoleColor.Yellow;

            string[] logo = new string[]
            {
                @"#    ░▒▓████████▓▒░▒▓█▓▒░░▒▓█▓▒░▒▓████████▓▒░       ░▒▓███████▓▒░▒▓████████▓▒░▒▓████████▓▒░▒▓███████▓▒░    ",
                @"#       ░▒▓█▓▒░   ░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░             ░▒▓█▓▒░      ░▒▓█▓▒░      ░▒▓█▓▒░      ░▒▓█▓▒░░▒▓█▓▒░   ",
                @"#       ░▒▓█▓▒░   ░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░             ░▒▓█▓▒░      ░▒▓█▓▒░      ░▒▓█▓▒░      ░▒▓█▓▒░░▒▓█▓▒░   ",
                @"#       ░▒▓█▓▒░   ░▒▓████████▓▒░▒▓██████▓▒░         ░▒▓██████▓▒░░▒▓██████▓▒░ ░▒▓██████▓▒░ ░▒▓███████▓▒░    ",
                @"#       ░▒▓█▓▒░   ░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░                    ░▒▓█▓▒░▒▓█▓▒░      ░▒▓█▓▒░      ░▒▓█▓▒░░▒▓█▓▒░   ",
                @"#       ░▒▓█▓▒░   ░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░                    ░▒▓█▓▒░▒▓█▓▒░      ░▒▓█▓▒░      ░▒▓█▓▒░░▒▓█▓▒░   ",
                @"#       ░▒▓█▓▒░   ░▒▓█▓▒░░▒▓█▓▒░▒▓████████▓▒░      ░▒▓███████▓▒░░▒▓████████▓▒░▒▓████████▓▒░▒▓█▓▒░░▒▓█▓▒░   ",
            };

            Console.WriteLine();
            foreach (var line in logo)
            {
                Console.Write("   ");
                ConsoleHelper.WriteLine(line, logoColor);
                Thread.Sleep(40);
            }
            Console.WriteLine();
            ConsoleHelper.Divider();
        }
    

    public static void Display()
        {
            ConsoleColor logoColor = ConsoleColor.Yellow;

            string[] logo = new string[]
            {
                @"#    ░▒▓████████▓▒░▒▓█▓▒░░▒▓█▓▒░▒▓████████▓▒░       ░▒▓███████▓▒░▒▓████████▓▒░▒▓████████▓▒░▒▓███████▓▒░    ", 
                @"#       ░▒▓█▓▒░   ░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░             ░▒▓█▓▒░      ░▒▓█▓▒░      ░▒▓█▓▒░      ░▒▓█▓▒░░▒▓█▓▒░   ", 
                @"#       ░▒▓█▓▒░   ░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░             ░▒▓█▓▒░      ░▒▓█▓▒░      ░▒▓█▓▒░      ░▒▓█▓▒░░▒▓█▓▒░   ", 
                @"#       ░▒▓█▓▒░   ░▒▓████████▓▒░▒▓██████▓▒░         ░▒▓██████▓▒░░▒▓██████▓▒░ ░▒▓██████▓▒░ ░▒▓███████▓▒░    ", 
                @"#       ░▒▓█▓▒░   ░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░                    ░▒▓█▓▒░▒▓█▓▒░      ░▒▓█▓▒░      ░▒▓█▓▒░░▒▓█▓▒░   ", 
                @"#       ░▒▓█▓▒░   ░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░                    ░▒▓█▓▒░▒▓█▓▒░      ░▒▓█▓▒░      ░▒▓█▓▒░░▒▓█▓▒░   ", 
                @"#       ░▒▓█▓▒░   ░▒▓█▓▒░░▒▓█▓▒░▒▓████████▓▒░      ░▒▓███████▓▒░░▒▓████████▓▒░▒▓████████▓▒░▒▓█▓▒░░▒▓█▓▒░   ", 
            };

            Console.WriteLine();
            foreach (var line in logo)
            {
                Console.Write("   ");
                ConsoleHelper.WriteLine(line, logoColor);
            }
            Console.WriteLine();
            ConsoleHelper.Divider();
        }
    }
}
