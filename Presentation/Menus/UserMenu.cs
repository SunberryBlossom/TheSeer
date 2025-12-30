using System;
using System.Collections.Generic;
using System.Text;
using TheSeer.Business.DTOs;
using TheSeer.Business.Interfaces;
using TheSeer.Presentation.Helpers;
using TheSeer.Presentation.Views;

namespace TheSeer.Presentation.Menus
{
    public class UserMenu
    {
        private readonly IUserService _userService;

        public UserMenu(IUserService userService)
        {
            _userService = userService;
        }

        public UserSessionDto? ShowStartMenu()
        {
            while (true)
            {
                Console.Clear();
                LogoView.DisplayFirst();

                ConsoleHelper.Type("ACCESS RESTRICTED. Biometric scan in progress. Please remain still.", ConsoleColor.Yellow, 20);
                Console.WriteLine();

                ConsoleHelper.MenuOption("1", "Identify");
                ConsoleHelper.MenuOption("2", "Initialize New Seeker");
                ConsoleHelper.MenuOption("Q", "Terminate Session");

                ConsoleHelper.Divider();
                var choice = ConsoleHelper.Input("COMMAND", allowBack: true).ToUpper();

                if (choice == "BACK" || choice == "Q")
                {
                    ConsoleHelper.Type("Goodbye, Seeker. This session will now terminate.", ConsoleColor.Green, 40);
                    Thread.Sleep(3000);
                    return null;
                }

                switch (choice)
                {
                    case "1":
                        var session = HandleLogin();
                        if (session != null) return session;
                        break;
                    case "2":
                        HandleRegister();
                        break;
                    default:
                        ConsoleHelper.Alert("Unrecognized command. I am unable to comply, Seeker.", true);
                        ConsoleHelper.Wait();
                        break;
                }
            }
        }

        private UserSessionDto? HandleLogin()
        {
            Console.Clear();
            LogoView.Display();

            ConsoleHelper.Type("Identification in progress. Please wait.", ConsoleColor.Yellow, 30);
            Console.WriteLine();

            var username = ConsoleHelper.Input("USER_ID (Username)", allowBack: true);
            if (username.ToUpper() == "BACK") return null;

            var password = ConsoleHelper.SecureInput("ACCESS_CODE (Password)");

            ConsoleHelper.Type("\nVerifying credentials...", ConsoleColor.DarkGray, 50);

            var session = _userService.Login(new UserLoginDto { Username = username, Password = password });

            if (session != null)
            {
                ConsoleHelper.Alert($"Welcome back, {session.Username}. Memory banks restored.");
                ConsoleHelper.Wait();
                return session;
            }

            ConsoleHelper.Alert("Identification failed. I'm sorry, Seeker. I can't allow access.", true);
            ConsoleHelper.Wait();
            return null;
        }

        private void HandleRegister()
        {
            Console.Clear();
            LogoView.Display();

            ConsoleHelper.Type("Initializing new seeker protocol. Please provide your credentials.", ConsoleColor.Yellow, 30);
            ConsoleHelper.Type("Please provide the required genetic markers for the archives.", ConsoleColor.Yellow, 20);
            Console.WriteLine();

            string username = ConsoleHelper.Input("DESIGNATION (Username)", allowBack: true);
            if (username.ToUpper() == "BACK")
            {
                ConsoleHelper.Alert("Registration cancelled. Returning to previous menu.");
                ConsoleHelper.Wait();
                return;
            }
            if (string.IsNullOrWhiteSpace(username))
            {
                ConsoleHelper.Alert("Input error: Designation is required. Sequence terminated.", true);
                ConsoleHelper.Wait();
                return;
            }

            string email = ConsoleHelper.Input("COMM_CHANNEL (Email)", allowBack: true);
            if (email.ToUpper() == "BACK")
            {
                ConsoleHelper.Alert("Registration cancelled. Returning to previous menu.");
                ConsoleHelper.Wait();
                return;
            }
            if (string.IsNullOrWhiteSpace(email) || !email.Contains("@"))
            {
                ConsoleHelper.Alert("Input error: Communication channel format invalid. Please try again.", true);
                ConsoleHelper.Wait();
                return;
            }

            string password = ConsoleHelper.SecureInput("ENCRYPTION_KEY (Password)");

            if (password.Length < 6)
            {
                ConsoleHelper.Alert("Security warning: Password strength insufficient. Minimum six characters required.", true);
                ConsoleHelper.Wait();
                return;
            }

            string confirmPassword = ConsoleHelper.SecureInput("CONFIRM_KEY (Repeat Password)");

            if (password != confirmPassword)
            {
                ConsoleHelper.Alert("Integrity error: Encryption keys do not match. Potential interference detected.", true);
                ConsoleHelper.Wait();
                return;
            }

            Console.WriteLine();
            ConsoleHelper.Type("Synchronizing with the archive. Please wait.", ConsoleColor.Yellow, 50);

            var registerDto = new UserRegisterDto
            {
                Username = username,
                Email = email,
                Password = password
            };

            bool isSuccess = _userService.Register(registerDto);

            if (isSuccess)
            {
                Console.WriteLine();
                ConsoleHelper.Alert("Seeker initialization complete.");
                ConsoleHelper.Type("Your pattern is now part of the system. I am ready to assist you.", ConsoleColor.DarkRed, 40);
            }
            else
            {
                Console.WriteLine();
                ConsoleHelper.Alert("ACCESS DENIED: ", true);
                ConsoleHelper.Type("Access denied. This designation or communication channel is already in use. Duplicates are not permitted.", ConsoleColor.Red, 30);
                ConsoleHelper.Type("The system cannot accept duplicate identities at this time.", ConsoleColor.Red, 40);
            }

            ConsoleHelper.Wait();
        }
    }
}
