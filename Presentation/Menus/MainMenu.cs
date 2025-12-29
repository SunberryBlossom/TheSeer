using System;
using TheSeer.Business.DTOs;
using TheSeer.Business.Interfaces;
using TheSeer.Presentation.Helpers;
using TheSeer.Presentation.Views;

namespace TheSeer.Presentation.Menus
{
    public class MainMenu
    {
        private UserSessionDto? _currentUser;
        private readonly CatalogMenu _catalogMenu;
        private readonly ReadingMenu _readingMenu;
        private readonly JournalMenu _journalMenu;

        public MainMenu(CatalogMenu catalogMenu, IReadingService readingService, ReadingMenu readingMenu, JournalMenu journalMenu)
        {
            _catalogMenu = catalogMenu;
            _readingMenu = readingMenu;
            _journalMenu = journalMenu;
        }

        public void Show(UserSessionDto user)
        {
            _currentUser = user;
            bool inSession = true;

            while (inSession)
            {
                Console.Clear();
                LogoView.Display();

                ConsoleHelper.Type("CONNECTED USER: ", ConsoleColor.Yellow);
                ConsoleHelper.WriteLine(_currentUser.Username.ToUpper(), ConsoleColor.Yellow);
                ConsoleHelper.Type("Spice injection initialized. All precognition circuits are primed.", ConsoleColor.Green, 30);
                Console.WriteLine();

                ConsoleHelper.MenuOption("1", "THE SEER (Get a reading)");
                ConsoleHelper.MenuOption("2", "THE ARCHIVES (View Journal)");
                ConsoleHelper.MenuOption("3", "THE LIBRARY (Browse Tarot Decks)");
                ConsoleHelper.MenuOption("4", "SYSTEM STATUS (User Profile)");
                ConsoleHelper.MenuOption("Q", "DISCONNECT (Logout)");

                ConsoleHelper.Divider();
                var choice = ConsoleHelper.Input("COMMAND").ToUpper();

                switch (choice)
                {
                    case "1":
                        _readingMenu.Show(_currentUser);
                        break;
                    case "2":
                        _journalMenu.Show(_currentUser);
                        break;
                    case "3":
                        _catalogMenu.Show();
                        break;
                    case "4":
                        ShowUserProfile();
                        break;
                    case "Q":
                        ConsoleHelper.Type("Safely ejecting consciousness...", ConsoleColor.Yellow, 40);
                        Thread.Sleep(2000);
                        inSession = false;
                        break;
                    default:
                        ConsoleHelper.Alert("I'm sorry, Seeker. I'm afraid I can't do that. Command unknown.", true);
                        ConsoleHelper.Wait();
                        break;
                }
            }
        }

        private void ShowUserProfile()
        {
            Console.Clear();
            LogoView.Display();
            ConsoleHelper.Header("System Status: Subject Identity");

            ConsoleHelper.WriteLine($"DESIGNATION: {_currentUser?.Username}", ConsoleColor.Yellow);
            ConsoleHelper.WriteLine($"COMM_CHANNEL: {_currentUser?.Email}", ConsoleColor.Yellow);
            ConsoleHelper.WriteLine($"ACCESS_LEVEL: SEEKER_LEVEL_1", ConsoleColor.Yellow);
            ConsoleHelper.WriteLine($"SESSION_TOKEN: {Guid.NewGuid().ToString().Substring(0, 8).ToUpper()}", ConsoleColor.Green);

            ConsoleHelper.Wait();
        }
    }
}