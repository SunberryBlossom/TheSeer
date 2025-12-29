using System;
using TheSeer.Business.DTOs;
using TheSeer.Business.Interfaces;
using TheSeer.Presentation.Menus;
using TheSeer.Presentation.Views;

namespace TheSeer.ConsoleApp
{
    public class App
    {
        private readonly IUserService _userService;
        private readonly ICatalogService _catalogService;
        private readonly IReadingService _readingService;
        private UserSessionDto? _currentUser;
        private readonly UserMenu _userMenu;
        private readonly MainMenu _mainMenu;

        public App(IUserService userService, ICatalogService catalogService, IReadingService readingService, UserMenu userMenu, MainMenu mainMenu)
        {
            _userService = userService;
            _catalogService = catalogService;
            _readingService = readingService;
            _userMenu = userMenu;
            _mainMenu = mainMenu;
        }

        public void Run()
        {

            StartupView.Initialize();

            bool running = true;
            while (running)
            {
                if (_currentUser == null)
                {
                    _currentUser = _userMenu.ShowStartMenu();

                    if (_currentUser == null && !running) break;
                }
                else
                {
                    _mainMenu.Show(_currentUser);
                    _currentUser = null;
                }
            }
        }
    }
}