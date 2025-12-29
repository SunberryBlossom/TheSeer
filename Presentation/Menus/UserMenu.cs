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

                ConsoleHelper.Type("ACCESS RESTRICTED. BIOMETRIC SCAN REQUIRED.", ConsoleColor.Yellow, 20);
                Console.WriteLine();

                ConsoleHelper.MenuOption("1", "Identify");
                ConsoleHelper.MenuOption("2", "Initialize New Seeker");
                ConsoleHelper.MenuOption("Q", "Terminate Session");

                ConsoleHelper.Divider();
                var choice = ConsoleHelper.Input("COMMAND").ToUpper();

                switch (choice)
                {
                    case "1":
                        var session = HandleLogin();
                        if (session != null) return session;
                        break;
                    case "2":
                        HandleRegister();
                        break;
                    case "Q":
                        ConsoleHelper.Type("Good-bye, Seeker. Time waits for no one.", ConsoleColor.Green, 40);
                        return null;
                    default:
                        ConsoleHelper.Alert("Invalid command. My sensors do not recognize that input.", true);
                        ConsoleHelper.Wait();
                        break;
                }
            }
        }

        private UserSessionDto? HandleLogin()
        {
            Console.Clear();
            LogoView.Display();

            ConsoleHelper.Type("WAITING FOR IDENTIFICATION...", ConsoleColor.Yellow, 30);
            Console.WriteLine();

            var username = ConsoleHelper.Input("USER_ID (Username)");
            var password = ConsoleHelper.SecureInput("ACCESS_CODE (Password)");

            ConsoleHelper.Type("\nVerifying credentials...", ConsoleColor.DarkGray, 50);

            var session = _userService.Login(new UserLoginDto { Username = username, Password = password });

            if (session != null)
            {
                ConsoleHelper.Alert($"Welcome back, {session.Username}. Memory banks restored.");
                ConsoleHelper.Wait();
                return session;
            }

            ConsoleHelper.Alert("Identification failed. I'm afraid I can't let you in.", true);
            ConsoleHelper.Wait();
            return null;
        }

        private void HandleRegister()
        {
            Console.Clear();
            LogoView.Display();

            ConsoleHelper.Type("INITIATING NEW SEEKER SEQUENCE...", ConsoleColor.Yellow, 30);
            ConsoleHelper.Type("Please provide the required genetic markers for the archives.", ConsoleColor.Yellow, 20);
            Console.WriteLine();

            string username = ConsoleHelper.Input("DESIGNATION (Username)");
            if (string.IsNullOrWhiteSpace(username))
            {
                ConsoleHelper.Alert("Identity error: Designation cannot be null. Sequence aborted.", true);
                ConsoleHelper.Wait();
                return;
            }

            string email = ConsoleHelper.Input("COMM_CHANNEL (Email)");
            if (string.IsNullOrWhiteSpace(email) || !email.Contains("@"))
            {
                ConsoleHelper.Alert("Protocol error: Invalid communication channel format.", true);
                ConsoleHelper.Wait();
                return;
            }

            string password = ConsoleHelper.SecureInput("ENCRYPTION_KEY (Password)");

            if (password.Length < 6)
            {
                ConsoleHelper.Alert("Security alert: Key strength insufficient. Minimum 6 characters required.", true);
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
            ConsoleHelper.Type("Syncing with the Great Archive...", ConsoleColor.Yellow, 50);

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
                ConsoleHelper.Alert("SEEKER SUCCESSFULLY INITIALIZED.");
                ConsoleHelper.Type("Your pattern is now part of the System. I, the Seer, await you.", ConsoleColor.Magenta, 40);
            }
            else
            {
                Console.WriteLine();
                ConsoleHelper.Alert("ACCESS DENIED: ", true);
                ConsoleHelper.Type("Identity conflict detected. This Designation or Comm-Channel is already claimed by another entity.", ConsoleColor.Red, 30);
                ConsoleHelper.Type("The System does not allow duplicates in this timeline.", ConsoleColor.Red, 40);
            }

            ConsoleHelper.Wait();
        }
    }
}
