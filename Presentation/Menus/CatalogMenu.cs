using System;
using System.Collections.Generic;
using System.Linq;
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

                var groupedDecks = decks
                    .GroupBy(d => string.IsNullOrWhiteSpace(d.SystemName) ? "OTHER" : d.SystemName.ToUpper())
                    .OrderBy(g => g.Key)
                    .ToList();

                int deckIndex = 1;
                Dictionary<int, DeckListItemDto> deckMap = new();

                foreach (var group in groupedDecks)
                {
                    ConsoleHelper.WriteLine($"=== {group.Key} ===", ConsoleColor.Green);
                    foreach (var deck in group)
                    {
                        ConsoleHelper.MenuOption(deckIndex.ToString(), $"{deck.Name}");
                        deckMap[deckIndex] = deck;
                        deckIndex++;
                    }
                    Console.WriteLine();
                }

                ConsoleHelper.MenuOption("Q", "RETURN TO MAIN TERMINAL");
                ConsoleHelper.Divider();

                var choice = ConsoleHelper.Input("SELECT DECK FOR DETAILED SCAN", allowBack: true).ToUpper();

                if (choice == "Q")
                {
                    browsing = false;
                }
                else if (choice == "BACK")
                {
                    return;
                }
                else if (int.TryParse(choice, out int index) && deckMap.ContainsKey(index))
                {
                    ShowDeckDetails(deckMap[index].Id);
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

            ConsoleHelper.Type("DESCRIPTION:", ConsoleColor.Green, 20);
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

            var groupedCards = deck.Cards
                .GroupBy(c => string.IsNullOrWhiteSpace(c.Suit) ? "GENERAL" : c.Suit.ToUpper())
                .OrderBy(g => g.Key);

            ConsoleHelper.Type($"ANALYZING {deck.Cards.Count} ENTITIES BY CATEGORY AND VALUE...", ConsoleColor.Green, 20);
            Console.WriteLine();

            var cardList = deck.Cards.OrderBy(c => c.Suit).ThenBy(c => c.Value).ToList();
            int cardIndex = 1;
            Dictionary<int, CardDetailDto> cardMap = new();

            foreach (var group in groupedCards)
            {
                Console.WriteLine();
                ConsoleHelper.WriteLine($"--- [ CATEGORY: {group.Key} ] ---", ConsoleColor.DarkRed);

                foreach (var card in group.OrderBy(c => c.Value))
                {
                    Console.Write("  ");
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.Write($"[{cardIndex:D2}] ");

                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine($"{card.Name.ToUpper()}");

                    cardMap[cardIndex] = card;
                    cardIndex++;
                    Thread.Sleep(5);
                }
            }

            Console.ResetColor();
            Console.WriteLine();
            ConsoleHelper.Divider();

            ConsoleHelper.MenuOption("Q", "Back to deck list");
            var input = ConsoleHelper.Input("Enter card number for details or Q to return", allowBack: true).ToUpper();
            if (input == "Q")
                return;

            if (int.TryParse(input, out int selected) && cardMap.ContainsKey(selected))
            {
                var cardDetail = _catalogService.GetCardDetails(cardMap[selected].Id);
                if (cardDetail != null)
                {
                    ShowCardDetails(cardDetail);
                }
                else
                {
                    ConsoleHelper.Alert("Could not load card details.", true);
                }
            }
            else
            {
                ConsoleHelper.Alert("Invalid selection.", true);
            }
        }

        private void ShowCardDetails(CardDetailDto card)
        {
            Console.Clear();
            LogoView.Display();
            ConsoleHelper.Header($"Card Detail: {card.Name}");

            ConsoleHelper.Type($"VALUE: {card.Value}", ConsoleColor.Green, 20);
            ConsoleHelper.Type($"SUIT: {card.Suit ?? "GENERAL"}", ConsoleColor.Green, 20);
            Console.WriteLine();

            ConsoleHelper.WriteLine(card.Description ?? "No description available.", ConsoleColor.Gray);
            Console.WriteLine();

            if (card.Meanings != null && card.Meanings.Count > 0)
            {
                var upright = card.Meanings.Where(m => !m.IsReversed).ToList();
                var reversed = card.Meanings.Where(m => m.IsReversed).ToList();

                if (upright.Count > 0)
                {
                    ConsoleHelper.WriteLine("UPRIGHT MEANINGS:", ConsoleColor.Yellow);
                    foreach (var meaning in upright)
                    {
                        ConsoleHelper.WriteLine($"- {meaning.Content}", ConsoleColor.Gray);
                    }
                    Console.WriteLine();
                }

                if (reversed.Count > 0)
                {
                    ConsoleHelper.WriteLine("REVERSED MEANINGS:", ConsoleColor.Yellow);
                    foreach (var meaning in reversed)
                    {
                        ConsoleHelper.WriteLine($"- {meaning.Content}", ConsoleColor.Gray);
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                ConsoleHelper.WriteLine("No meanings available.", ConsoleColor.DarkGray);
            }

            ConsoleHelper.Divider();
        }
    }
}
