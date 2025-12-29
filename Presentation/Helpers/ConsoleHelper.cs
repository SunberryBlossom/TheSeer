using System;
using System.Collections.Generic;
using System.Text;

namespace TheSeer.Presentation.Helpers
{
    public static class ConsoleHelper
    {
        private const ConsoleColor Primary = ConsoleColor.Yellow;
        private const ConsoleColor Secondary = ConsoleColor.DarkYellow;
        private const ConsoleColor Accent = ConsoleColor.Green;
        private const ConsoleColor Muted = ConsoleColor.DarkGray;
        private const ConsoleColor Error = ConsoleColor.Red;

        private const int DefaultSpeed = 20;

        public static void Type(string message, ConsoleColor color = ConsoleColor.Gray, int speed = DefaultSpeed)
        {
            Console.ForegroundColor = color;
            foreach (char c in message)
            {
                Console.Write(c);

                if (Console.KeyAvailable)
                {
                    Console.Write(message.Substring(message.IndexOf(c) + 1));
                    Console.ReadKey(true);
                    break;
                }
                Thread.Sleep(speed);
            }
            Console.ResetColor();
            Console.WriteLine();
        }

        public static void Header(string title)
        {
            Console.Clear();
            WriteLine(new string('=', 55), Primary);
            Type($"        ::: {title.ToUpper()} :::", Secondary, 40);
            WriteLine(new string('=', 55), Primary);
            Console.WriteLine();
        }

        public static void WriteLine(string message, ConsoleColor color = ConsoleColor.Gray)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();
        }

        public static void Divider()
        {
            WriteLine(new string('-', 55), Muted);
        }

        public static string Input(string prompt)
        {
            Console.Write($"{prompt}: ", Secondary);
            Console.ForegroundColor = Accent;
            string input = Console.ReadLine() ?? string.Empty;
            Console.ResetColor();
            return input;
        }

        public static string SecureInput(string prompt)
        {
            Console.Write($"{prompt}: ", Secondary);
            string password = string.Empty;
            while (true)
            {
                var key = Console.ReadKey(true);
                if (key.Key == ConsoleKey.Enter) break;
                if (key.Key == ConsoleKey.Backspace && password.Length > 0)
                {
                    password = password[..^1];
                    Console.Write("\b \b");
                }
                else if (!char.IsControl(key.KeyChar))
                {
                    password += key.KeyChar;
                    Console.Write("*");
                }
            }
            Console.WriteLine();
            return password;
        }

        public static void Alert(string message, bool isError = false)
        {
            Console.WriteLine();
            WriteLine(isError ? $" [!] {message}" : $" [*] {message}", isError ? Error : ConsoleColor.Green);
            Console.WriteLine();
        }

        public static void Wait()
        {
            Console.WriteLine();
            Type("[Press any key to continue]", Muted, 10);
            Console.ReadKey(true);
        }

        public static void MenuOption(string key, string description)
        {
            Console.ForegroundColor = Accent;
            Console.Write($"  [{key}] ");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine(description);
            Console.ResetColor();
        }
    }
}
