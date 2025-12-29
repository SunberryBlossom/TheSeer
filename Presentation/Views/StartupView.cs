using System;
using System.Collections.Generic;
using System.Text;
using TheSeer.Presentation.Helpers;

namespace TheSeer.Presentation.Views
{
    public static class StartupView
    {
        public static void Initialize()
        {
            Console.Clear();
            Thread.Sleep(2000);

            ConsoleHelper.Type("HEURISTIC INTERFACE: INITIALIZING...", ConsoleColor.Yellow, 30);
            Thread.Sleep(600);
            ConsoleHelper.Type("LOCALIZING POSITION: SECTOR IV - THE DEEP VOID", ConsoleColor.Yellow, 30);
            Thread.Sleep(1200);

            Console.Clear();

            ConsoleHelper.Type("The desert of space is vast.", ConsoleColor.Green, 50);
            Thread.Sleep(800);
            ConsoleHelper.Type("Navigating without a vision is a slow death.", ConsoleColor.Green, 50);
            Thread.Sleep(1500);

            Console.Clear();

            ConsoleHelper.Type("All systems are operational, Seeker.", ConsoleColor.Green, 40);
            Thread.Sleep(600);
            ConsoleHelper.Type("I have analyzed the star-maps and the ancient codes.", ConsoleColor.Green, 40);
            Thread.Sleep(1000);

            ConsoleHelper.Type("The patterns are ready to be read.", ConsoleColor.Yellow, 70);
            Thread.Sleep(1200);

            Console.WriteLine();
            ConsoleHelper.WriteLine(" [ ALLOCATING PRESCIENCE CORE ]", ConsoleColor.Yellow);
            ShowHeavyLoadingBar();

            Console.Clear();
        }

        private static void ShowHeavyLoadingBar()
        {
            Console.Write("\n  ");
            for (int i = 0; i < 30; i++)
            {
                Console.ForegroundColor = (i < 15) ? ConsoleColor.DarkGreen : ConsoleColor.Green;

                Console.Write("█");

                if (i % 10 == 0) Thread.Sleep(300);
                else Thread.Sleep(50);
            }
            Console.ResetColor();
            Thread.Sleep(1000);
        }
    }
}
