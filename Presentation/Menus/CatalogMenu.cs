using System;
using System.Collections.Generic;
using System.Text;
using TheSeer.Business.DTOs;
using TheSeer.Business.Interfaces;
using TheSeer.Presentation.Helpers;
using TheSeer.Presentation.Views;

namespace TheSeer.Presentation.Menus
{
    public class CatalogMenu
    {
        private readonly ICatalogService _catalogService;

        public CatalogMenu(ICatalogService catalogService)
        {
            _catalogService = catalogService;
        }

        public void Show()
        {
            bool browsing = true;
            while (browsing)
            {
                Console.Clear();
                LogoView.Display();
                ConsoleHelper.Header("The Library: Ancient Archives");

                ConsoleHelper.Type("ACCESSING DATA BANKS... RETRIEVING DECK SCHEMATICS.", ConsoleColor.DarkGray, 20);
                Console.WriteLine();

                var decks = _catalogService.GetAllDecks().ToList();

                if (!decks.Any())
                {
                    ConsoleHelper.Alert("The archives appear to be empty. No decks found.", true);
                    ConsoleHelper.Wait();
                    return;
                }

                for (int i = 0; i < decks.Count; i++)
                {
                    ConsoleHelper.MenuOption((i + 1).ToString(), $"{decks[i].Name} - {decks[i].Description}");
                }

                ConsoleHelper.MenuOption("Q", "RETURN TO MAIN TERMINAL");
                ConsoleHelper.Divider();

                var choice = ConsoleHelper.Input("SELECT DECK FOR DETAILED SCAN").ToUpper();

                if (choice == "Q")
                {
                    browsing = false;
                }
                else if (int.TryParse(choice, out int index) && index > 0 && index <= decks.Count)
                {
                    ShowDeckDetails(decks[index - 1].Id);
                }
                else
                {
                    ConsoleHelper.Alert("Invalid selection. My sensors detect no such archive.", true);
                    ConsoleHelper.Wait();
                }
            }
        }

        private void ShowDeckDetails(int deckId)
        {
            var deck = _catalogService.GetDeckById(deckId);
            if (deck == null) return;

            Console.Clear();
            LogoView.Display();
            ConsoleHelper.Header($"Archive: {deck.Name}");

            ConsoleHelper.Type("DESCRIPTION:", ConsoleColor.Cyan, 20);
            ConsoleHelper.Type(deck.Description);

            Console.WriteLine();
            ConsoleHelper.Type($"CARDS DETECTED: {deck.Cards.Count}", ConsoleColor.DarkGray, 20);

            ConsoleHelper.Divider();
            ConsoleHelper.MenuOption("1", "View all cards in this deck");
            ConsoleHelper.MenuOption("Q", "Back to library");

            var choice = ConsoleHelper.Input("COMMAND").ToUpper();
            if (choice == "1")
            {
                ShowAllCards(deck);
                ConsoleHelper.Wait();
            }
        }

        private void ShowAllCards(DeckListItemDto deck)
        {
            Console.Clear();
            LogoView.Display();
            ConsoleHelper.Header($"Archive Scan: {deck.Name}");

            if (deck.Cards == null || !deck.Cards.Any())
            {
                ConsoleHelper.Alert("No data signatures detected in this archive.", true);
                ConsoleHelper.Wait();
                return;
            }

            // 1. Gruppera efter kategori
            // 2. Sortera grupperna alfabetiskt (Key)
            var groupedCards = deck.Cards
                .GroupBy(c => string.IsNullOrWhiteSpace(c.Suit) ? "GENERAL" : c.Suit.ToUpper())
                .OrderBy(g => g.Key);

            ConsoleHelper.Type($"ANALYZING {deck.Cards.Count} ENTITIES BY CATEGORY AND VALUE...", ConsoleColor.Cyan, 20);
            Console.WriteLine();

            foreach (var group in groupedCards)
            {
                Console.WriteLine();
                ConsoleHelper.WriteLine($"--- [ CATEGORY: {group.Key} ] ---", ConsoleColor.Magenta);

                // Här sker den interna sorteringen på VALUE
                foreach (var card in group.OrderBy(c => c.Value))
                {
                    Console.Write("  ");
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.Write($"[{card.Value:D2}] "); // Visar värdet, t.ex. [01], [02]

                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine(card.Name.ToUpper());

                    Thread.Sleep(5);
                }
            }

            Console.ResetColor();
            Console.WriteLine();
            ConsoleHelper.Divider();
            ConsoleHelper.Wait();
        }
    }
}
