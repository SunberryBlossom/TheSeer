using System;
using System.Collections.Generic;
using System.Linq;
using TheSeer.Business.DTOs;
using TheSeer.Business.Interfaces;
using TheSeer.Presentation.Helpers;
using TheSeer.Presentation.Views;

namespace TheSeer.Presentation.Menus
{
    public class ReadingMenu
    {
        private readonly IReadingService _readingService;
        private readonly ICatalogService _catalogService;
        private readonly ISpreadService _spreadService;
        private UserSessionDto? _currentUser;

        public ReadingMenu(IReadingService readingService, ICatalogService catalogService, ISpreadService spreadService)
        {
            _readingService = readingService;
            _catalogService = catalogService;
            _spreadService = spreadService;
        }

        public void Show(UserSessionDto user)
        {
            _currentUser = user;
            bool inMenu = true;

            while (inMenu)
            {
                string systemType = SelectSystemType();
                if (systemType == "CANCEL") break;

                var selectedDeck = SelectDeck(systemType);
                if (selectedDeck == null) continue;

                var selectedSpread = SelectSpread(systemType);
                if (selectedSpread == null) continue;

                ExecuteReading(selectedDeck, selectedSpread);

                inMenu = false;
            }
        }

        private string SelectSystemType()
        {
            Console.Clear();
            LogoView.Display();
            ConsoleHelper.Header("STEP 1: CHOOSE YOUR DIVINATION SYSTEM");

            var systemTypes = _catalogService.GetSystemTypes().ToList();

            ConsoleHelper.MenuOption("1", "Tarot");
            ConsoleHelper.MenuOption("2", "Oracle");
            ConsoleHelper.MenuOption("3", "Runes");
            Console.WriteLine();

            foreach (var type in systemTypes)
            {
                ConsoleHelper.WriteLine($"{type.Name}: {type.Description}", ConsoleColor.Green);
            }



            var choice = ConsoleHelper.Input("COMMAND").ToUpper();
            return choice switch
            {
                "1" => "Tarot",
                "2" => "Oracle",
                "3" => "Runes",
                _ => "CANCEL"
            };
        }

        private DeckListItemDto? SelectDeck(string type)
        {
            Console.Clear();
            LogoView.Display();
            ConsoleHelper.Header($"STEP 2: SELECT {type.ToUpper()} SOURCE");

            var decks = _catalogService.GetAllDecks().Where(d => d.SystemName.Equals(type, StringComparison.OrdinalIgnoreCase)).ToList();

            if (!decks.Any())
            {
                ConsoleHelper.Alert($"No {type} sources found in the archives.", true);
                ConsoleHelper.Wait();
                return null;
            }

            foreach (var deck in decks)
            {
                ConsoleHelper.MenuOption(deck.Id.ToString(), $"{deck.Name} ({deck.CardCount} items)");
            }

            ConsoleHelper.MenuOption("Q", "Back to System Selection");

            var choice = ConsoleHelper.Input("SELECT ID").ToUpper();
            if (choice == "Q") return null;

            return decks.FirstOrDefault(d => d.Id.ToString() == choice);
        }

        private SpreadDto? SelectSpread(string type)
        {
            Console.Clear();
            LogoView.Display();
            ConsoleHelper.Header($"STEP 3: SELECT {type.ToUpper()} SPREAD PATTERN");

            var spreads = _spreadService.GetAllSpreads()
                                        .Where(s => s.SystemType.Equals(type, StringComparison.OrdinalIgnoreCase))
                                        .ToList();

            if (!spreads.Any())
            {
                ConsoleHelper.Alert($"No specific spreads found for {type}. Using Universal patterns.", false);
                spreads = _spreadService.GetAllSpreads().Where(s => s.SystemType == "Universal").ToList();
            }

            foreach (var spread in spreads)
            {
                ConsoleHelper.MenuOption(spread.Id.ToString(), $"{spread.Name} ({spread.PositionCount} positions)");
            }

            Console.WriteLine();

            foreach (var spread in spreads)
            {
                ConsoleHelper.WriteLine($"[{spread.Name}] {spread.Description}", ConsoleColor.Green);
            }
            Console.WriteLine();

            ConsoleHelper.MenuOption("B", "Back to Deck Selection");

            var choice = ConsoleHelper.Input("SELECT ID").ToUpper();
            if (choice == "B") return null;

            return spreads.FirstOrDefault(s => s.Id.ToString() == choice);
        }

        private void ExecuteReading(DeckListItemDto deck, SpreadDto spread)
        {
            Console.Clear();
            LogoView.Display();
            ConsoleHelper.Header("ENGAGING THE SEER PROJECT...");

            ConsoleHelper.WriteLine("ENTER YOUR QUESTION THAT YOU WISH ANSWERED", ConsoleColor.Cyan);
            string userQuestion = ConsoleHelper.Input("YOUR QUESTION");

            if (string.IsNullOrWhiteSpace(userQuestion))
            {
                ConsoleHelper.Alert("Seeker, without a question we do not know what to ask the stars...", true);
                userQuestion = ConsoleHelper.Input("COMMAND");
            }

            Console.Clear();
            LogoView.Display();
            ConsoleHelper.Header("ENGAGING THE SEER PROJECT...");
            ConsoleHelper.WriteLine($"QUESTION: {userQuestion}", ConsoleColor.Magenta);
            Console.WriteLine();

            if (deck.SystemName.Equals("Runes", StringComparison.OrdinalIgnoreCase))
            {
                ConsoleHelper.Type($"Reaching into the pouch of {deck.Name}...", ConsoleColor.Yellow, 40);
                ConsoleHelper.Type("Casting the stones upon the white cloth...", ConsoleColor.Yellow, 60);
            }
            else
            {
                ConsoleHelper.Type($"Shuffling the {deck.Name}...", ConsoleColor.Yellow, 40);
                ConsoleHelper.Type($"Invoking the {spread.Name} pattern...", ConsoleColor.Yellow, 60);
            }

            Console.WriteLine();

            ReadingResultDto result = _readingService.PerformReading(_currentUser.Id, deck.Id, spread.Id, userQuestion);

            if (result == null || !result.DrawnCards.Any())
            {
                ConsoleHelper.Alert("The vision is clouded. No cards were drawn.");
                return;
            }

            foreach (var card in result.DrawnCards)
            {
                ConsoleHelper.Divider();

                ConsoleHelper.WriteLine($"POSITION: {card.SpreadPosition.ToUpper()} -- {card.SpreadPositionDescription}", ConsoleColor.Yellow);

                string displayName = card.IsReversed ? $"{card.Card} (REVERSED)" : card.Card;
                ConsoleHelper.WriteLine($"CARD: {displayName.ToUpper()}", ConsoleColor.Yellow);

                ConsoleHelper.Type("INTERPRETATION: ", ConsoleColor.DarkYellow);

                foreach (var meaning in card.MeaningText)
                {
                    ConsoleHelper.WriteLine($"[{meaning.Category}]: {meaning.Content}", ConsoleColor.Yellow);
                }

                Console.WriteLine();
            }

            ConsoleHelper.Divider();
            ConsoleHelper.Type($"Reading saved under ID: {result.ReadingId.ToString().Substring(0, 8)}", ConsoleColor.DarkGray);
            ConsoleHelper.Wait();
        }
    }
}