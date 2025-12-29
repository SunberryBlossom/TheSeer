using System;
using System.Collections.Generic;
using System.Text;
using TheSeer.Business.DTOs;
using TheSeer.Presentation.Helpers;
using TheSeer.Presentation.Views;

namespace TheSeer.Presentation.Menus
{
    public class JournalMenu
    {
        private readonly IJournalService _journalService;
        private UserSessionDto? _currentUser;

        public JournalMenu(IJournalService journalService)
        {
            _journalService = journalService;
        }

        public void Show(UserSessionDto user)
        {
            _currentUser = user;
            bool inJournal = true;

            while (inJournal)
            {
                Console.Clear();
                LogoView.Display();
                ConsoleHelper.Header("THE ARCHIVES: HISTORICAL RECORDS");

                var entries = _journalService.GetUserReadings(_currentUser.Id);

                if (!entries.Any())
                {
                    ConsoleHelper.WriteLine("The scrolls are empty. You have no recorded visions.", ConsoleColor.Gray);
                    ConsoleHelper.Wait();
                    return;
                }

                foreach (var entry in entries.OrderByDescending(e => e.PerformedAt).Take(10))
                {
                    ConsoleHelper.MenuOption(entry.ReadingId.ToString().Substring(0, 8),
                        $"{entry.PerformedAt:yyyy-MM-dd HH:mm} | {entry.SpreadName}");
                }

                ConsoleHelper.Divider();
                ConsoleHelper.MenuOption("Q", "RETURN TO COMMAND CENTER");

                var choice = ConsoleHelper.Input("ENTER RECORD ID OR COMMAND").ToUpper();

                if (choice == "Q")
                {
                    inJournal = false;
                }
                else
                {
                    var selected = entries.FirstOrDefault(e => e.ReadingId.ToString().StartsWith(choice.ToLower()));

                    if (selected != null)
                        ShowReadingDetails(selected.ReadingId);
                    else
                        ConsoleHelper.Alert("Record not found in the archives.");
                }
            }
        }

        private void ShowReadingDetails(Guid readingId)
        {
            Console.Clear();
            LogoView.Display();

            var entries = _journalService.GetUserJournal(readingId);

            if (entries == null || !entries.Any())
    {
        ConsoleHelper.Alert("No records found for this vision.");
        return;
    }

    var firstEntry = entries.First();

    ConsoleHelper.Header($"RECORD: {firstEntry.ReadingId.ToString().ToUpper()}");
    ConsoleHelper.WriteLine($"DATE: {firstEntry.ReadingDate:f}", ConsoleColor.Cyan);
    ConsoleHelper.WriteLine($"SPREAD: {firstEntry.SpreadName}", ConsoleColor.Cyan);
    Console.WriteLine();

    foreach (var entry in entries)
    {
        ConsoleHelper.Divider();
        ConsoleHelper.WriteLine($"ENTRY ID: {entry.Id}", ConsoleColor.DarkGray);
        ConsoleHelper.Type("CONTENT: ", ConsoleColor.Yellow);
        ConsoleHelper.WriteLine(entry.TextContent);
    }

    ConsoleHelper.Divider();
    ConsoleHelper.Wait();
        }
    }
}
