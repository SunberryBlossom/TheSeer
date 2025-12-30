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
            ConsoleHelper.Header("Step 1: Select System Type");

            ConsoleHelper.MenuOption("TAROT", "Tarot Reading");
            //ConsoleHelper.MenuOption("LENORMAND", "Lenormand Reading");
            ConsoleHelper.MenuOption("RUNES", "Rune Reading");
            ConsoleHelper.MenuOption("ORACLE", "Oracle Reading");
            ConsoleHelper.MenuOption("CANCEL", "Back to Main Menu");

            ConsoleHelper.Divider();
            var choice = ConsoleHelper.Input("SYSTEM TYPE", allowBack: true).ToUpper();
            if (choice == "CANCEL" || choice == "BACK") return "CANCEL";
            return choice;
        }

        private DeckListItemDto? SelectDeck(string type)
        {
            Console.Clear();
            LogoView.Display();
            ConsoleHelper.Header($"Step 2: Please select your {type.ToUpper()} source.");

            var decks = _catalogService.GetAllDecks().Where(d => d.SystemName.Equals(type, StringComparison.OrdinalIgnoreCase)).ToList();

            if (!decks.Any())
            {
                ConsoleHelper.Alert($"No sources found. The archives are silent.", true);
                ConsoleHelper.Wait();
                return null;
            }

            foreach (var deck in decks)
            {
                ConsoleHelper.MenuOption(deck.Id.ToString(), $"{deck.Name} ({deck.CardCount} items)");
            }

            ConsoleHelper.MenuOption("Q", "Back to System Selection");

            Console.WriteLine();
            var choice = ConsoleHelper.Input("SELECT ID").ToUpper();
            if (choice == "Q") return null;

            return decks.FirstOrDefault(d => d.Id.ToString() == choice);
        }

        private SpreadDto? SelectSpread(string type)
        {
            Console.Clear();
            LogoView.Display();
            ConsoleHelper.Header($"Step 3: Please select your {type.ToUpper()} spread pattern.");

            var spreads = _spreadService.GetAllSpreads()
                                        .Where(s => s.SystemType.Equals(type, StringComparison.OrdinalIgnoreCase))
                                        .ToList();

            if (!spreads.Any())
            {
                ConsoleHelper.Alert($"No specific spreads found for {type}. Defaulting to universal patterns.", false);
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
                Console.WriteLine();
            }
            Console.WriteLine();

            ConsoleHelper.MenuOption("B", "Back to Deck Selection");

            Console.WriteLine();
            var choice = ConsoleHelper.Input("SELECT ID", allowBack: true).ToUpper();
            if (choice == "B" || choice == "BACK") return null;

            return spreads.FirstOrDefault(s => s.Id.ToString() == choice);
        }

        private void ExecuteReading(DeckListItemDto deck, SpreadDto spread)
        {
            Console.Clear();
            LogoView.Display();
            ConsoleHelper.Header("Engaging the Seer protocol. Please stand by.");

            ConsoleHelper.WriteLine("Please enter your question for analysis.", ConsoleColor.Green);
            string userQuestion = ConsoleHelper.Input("YOUR QUESTION");

            if (string.IsNullOrWhiteSpace(userQuestion))
            {
                ConsoleHelper.Alert("No question detected. Unable to proceed with the inquiry.", true);
                userQuestion = ConsoleHelper.Input("COMMAND");
            }

            Console.Clear();
            LogoView.Display();
            ConsoleHelper.Header("ENGAGING THE SEER PROJECT...");
            ConsoleHelper.WriteLine($"QUESTION: {userQuestion}", ConsoleColor.Green);
            Console.WriteLine();

            if (deck.SystemName.Equals("Runes", StringComparison.OrdinalIgnoreCase))
            {
                ConsoleHelper.Type($"Reaching into the {deck.Name}. Please wait.", ConsoleColor.Yellow, 40);
                ConsoleHelper.Type("Casting the stones. Please remain calm.", ConsoleColor.Yellow, 60);
            }
            else
            {
                ConsoleHelper.Type($"Shuffling the {deck.Name}. Please wait.", ConsoleColor.Yellow, 40);
                ConsoleHelper.Type($"Invoking the {spread.Name} pattern. Stand by.", ConsoleColor.Yellow, 60);
            }

            Console.WriteLine();

            ReadingResultDto result = _readingService.PerformReading(_currentUser.Id, deck.Id, spread.Id, userQuestion);

            if (result == null || !result.DrawnCards.Any())
            {
                ConsoleHelper.Alert("The vision is unclear. No results available.");
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
            ConsoleHelper.Type($"Reading has been archived. Reference ID: {result.ReadingId.ToString().Substring(0, 8)}", ConsoleColor.DarkGray);
            ConsoleHelper.Wait();
        }
        public void ReplayReading(Guid readingId)
        {
            var result = _readingService.GetReadingResult(readingId);

            if (result == null)
            {
                ConsoleHelper.Alert("Unable to locate the requested reading. Please verify the ID.", true);
                ConsoleHelper.Wait();
                return;
            }

            Console.Clear();
            LogoView.Display();
            ConsoleHelper.Header("Replaying historical reading. Please observe.");

            ConsoleHelper.WriteLine($"Original question: {result.Question}", ConsoleColor.Green);
            Console.WriteLine();

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
            ConsoleHelper.Type($"Reference ID: {result.ReadingId.ToString().Substring(0, 8)}", ConsoleColor.DarkGray);
            ConsoleHelper.Wait();
        }
    }
}