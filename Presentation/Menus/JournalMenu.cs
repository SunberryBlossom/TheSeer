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
        private readonly ReadingMenu _readingMenu;
        private UserSessionDto? _currentUser;

        public JournalMenu(IJournalService journalService, ReadingMenu readingMenu)
        {
            _journalService = journalService;
            _readingMenu = readingMenu;
        }

        public void Show(UserSessionDto user)
        {
            _currentUser = user;
            bool inJournal = true;

            while (inJournal)
            {
                Console.Clear();
                LogoView.Display();
                ConsoleHelper.Header("The archives: historical records.");

                // Fetch all readings and all journal entries for the user
                var readings = _journalService.GetUserReadings(_currentUser.Id).ToList();
                var journalEntries = _journalService.GetUserJournal(_currentUser.Id).ToList();

                if (!readings.Any())
                {
                    ConsoleHelper.WriteLine("The archives are empty. No records found.", ConsoleColor.Gray);
                    ConsoleHelper.Wait();
                    return;
                }

                foreach (var entry in readings.OrderByDescending(e => e.PerformedAt).Take(10))
                {
                    bool hasNote = journalEntries.Any(j => j.ReadingId == entry.ReadingId && j.UserId == _currentUser.Id);
                    string noteStatus = hasNote ? "[NOTE]" : "[NO NOTE]";
                    ConsoleHelper.MenuOption(entry.ReadingId.ToString().Substring(0, 8),
                        $"{entry.PerformedAt:yyyy-MM-dd HH:mm} | {entry.SpreadName} {noteStatus}");
                }

                ConsoleHelper.Divider();
                ConsoleHelper.MenuOption("Q", "Return to command center");

                var choice = ConsoleHelper.Input("ENTER RECORD ID OR COMMAND", allowBack: true).ToUpper();

                if (choice == "Q")
                {
                    inJournal = false;
                }
                else if (choice == "BACK")
                {
                    return;
                }
                else
                {
                    var selected = readings.FirstOrDefault(e => e.ReadingId.ToString().StartsWith(choice.ToLower()));

                    if (selected != null)
                    {
                        // Pass a fresh journalEntries list each time
                        ShowReadingDetails(selected.ReadingId, _journalService.GetUserJournal(_currentUser.Id).ToList());
                    }
                    else
                    {
                        ConsoleHelper.Alert("Record not found. Please verify your input.");
                    }
                }
            }
        }

        private void ShowReadingDetails(Guid readingId, List<JournalEntryDto> journalEntries)
        {
            Console.Clear();
            LogoView.Display();

            // Always offer to replay the reading first
            if (ConsoleHelper.Confirm("Would you like to replay this reading? (Y/N)"))
            {
                _readingMenu.ReplayReading(readingId);
            }

            var entries = journalEntries.Where(e => e.ReadingId == readingId).ToList();

            if (entries == null || !entries.Any())
            {
                Console.WriteLine();
                if (ConsoleHelper.Confirm("Would you like to add a note for this reading? (Y/N)"))
                {
                    var header = ConsoleHelper.Input("Enter a title for your journal note");
                    var content = ConsoleHelper.Input("Enter your journal note:");
                    try
                    {
                        var newEntry = _journalService.AddNote(readingId, _currentUser.Id, header, content);
                        if (newEntry != null)
                        {
                            ConsoleHelper.Alert("Note has been added.");
                        }
                    }
                    catch (Exception ex)
                    {
                        ConsoleHelper.Alert($"Unable to add note: {ex.Message}");
                    }
                }
                ConsoleHelper.Wait();
                return;
            }

            // If a journal entry exists, prompt to show it
            if (ConsoleHelper.Confirm("A note exists for this reading. Would you like to view it? (Y/N)"))
            {
                var firstEntry = entries.First();

                ConsoleHelper.Header($"Record: {firstEntry.ReadingId.ToString().ToUpper()}");
                ConsoleHelper.WriteLine($"Date: {firstEntry.ReadingDate:f}", ConsoleColor.Green);
                ConsoleHelper.WriteLine($"Spread: {firstEntry.SpreadName}", ConsoleColor.Green);
                Console.WriteLine();

                foreach (var entry in entries)
                {
                    ConsoleHelper.Divider();
                    ConsoleHelper.WriteLine($"ENTRY ID: {entry.Id}", ConsoleColor.DarkGray);
                    ConsoleHelper.WriteLine($"HEADER: {entry.Header}", ConsoleColor.Yellow);
                    ConsoleHelper.WriteLine($"WRITTEN: {entry.CreatedAt:f}", ConsoleColor.Green);
                    if (entry.UpdatedAt.HasValue)
                        ConsoleHelper.WriteLine($"LAST UPDATED: {entry.UpdatedAt.Value:f}", ConsoleColor.Green);
                    ConsoleHelper.Type("CONTENT: ", ConsoleColor.Yellow);
                    ConsoleHelper.WriteLine(entry.TextContent);
                }

                ConsoleHelper.Divider();
            }

            if (entries.Any() && ConsoleHelper.Confirm("Would you like to update this note? (Y/N)"))
            {
                var entryToUpdate = entries.First();
                var newHeader = ConsoleHelper.Input("Enter a new title (leave blank to keep current)");
                var newContent = ConsoleHelper.Input("Enter new content for your journal note");

                var updateDto = new JournalUpdateDto
                {
                    Id = entryToUpdate.Id,
                    NewHeader = string.IsNullOrWhiteSpace(newHeader) ? entryToUpdate.Header : newHeader,
                    NewTextContent = newContent
                };

                try
                {
                    var updatedEntry = _journalService.UpdateNote(updateDto);
                    if (updatedEntry != null)
                    {
                        ConsoleHelper.Alert("Note has been updated.");
                    }
                }
                catch (Exception ex)
                {
                    ConsoleHelper.Alert($"Unable to update note: {ex.Message}");
                }
            }

            ConsoleHelper.Wait();
        }
    }
}
