using System;
using TheSeer.Business.DTOs;
using TheSeer.Business.Interfaces;

namespace TheSeer.ConsoleApp
{
    public class App
    {
        private readonly IUserService _userService;
        private readonly ICatalogService _catalogService;
        private readonly IReadingService _readingService;
        private UserSessionDto? _currentUser;

        public App(IUserService userService, ICatalogService catalogService, IReadingService readingService)
        {
            _userService = userService;
            _catalogService = catalogService;
            _readingService = readingService;
        }

        public void Run()
        {

            bool running = true;
            while (running)
            {
                // NOT YET IMPLEMENTED! This will be the final step I think, after views and menus >:3
                running = false;
            }
        }
    }
}