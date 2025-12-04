using System;
using TheSeer.Models;
using TheSeer.Models.Enums;
using TheSeer.Utilities.Helpers;

namespace TheSeer.Services
{
    internal class Narrator
    {
        private const int NormalSpeed = 30;
        private const int SlowSpeed = 50;
        private const int FastSpeed = 15;

        // ==================== WELCOME & FAREWELL ====================

        public void Welcome()
        {
            ConsoleHelper.Clear();
            ConsoleHelper.TypeHeader("The Seer Awakens");
            ConsoleHelper.PauseForEffect(500);
            
            ConsoleHelper.TypeMystical("The mists part before you, revealing an ancient chamber...");
            ConsoleHelper.PauseForEffect(800);
            
            ConsoleHelper.TypeMystical("Candles flicker in the darkness, casting dancing shadows upon worn tapestries.");
            ConsoleHelper.PauseForEffect(800);
            
            ConsoleHelper.TypeWriteLine("A hooded figure sits at a table covered in cards and crystals.", ConsoleHelper.Colors.Mystical, SlowSpeed);
            ConsoleHelper.PauseForEffect(1000);
            
            ConsoleHelper.WriteBlankLine();
            ConsoleHelper.TypeDramatic("\"Welcome, traveler. I am The Seer.\"");
            ConsoleHelper.PauseForEffect(800);
            
            ConsoleHelper.TypeWriteLine("\"The cards have whispered of your coming...\"", ConsoleHelper.Colors.Mystical, NormalSpeed);
            ConsoleHelper.WriteBlankLine();
            ConsoleHelper.PauseForEffect(500);
        }

        public void Farewell()
        {
            ConsoleHelper.WriteBlankLine();
            ConsoleHelper.TypeDivider('─', 60, 5);
            ConsoleHelper.WriteBlankLine();
            
            ConsoleHelper.TypeMystical("The Seer's eyes grow distant, gazing beyond the veil...");
            ConsoleHelper.PauseForEffect(800);
            
            ConsoleHelper.TypeWriteLine("\"Your path is yours to walk, traveler.\"", ConsoleHelper.Colors.Mystical, SlowSpeed);
            ConsoleHelper.PauseForEffect(600);
            
            ConsoleHelper.TypeWriteLine("\"May the cards guide you through the darkness ahead...\"", ConsoleHelper.Colors.Mystical, SlowSpeed);
            ConsoleHelper.PauseForEffect(1000);
            
            ConsoleHelper.WriteBlankLine();
            ConsoleHelper.TypeWrite("The candles dim, and the mists close once more.", ConsoleHelper.Colors.Mystical, NormalSpeed);
            ConsoleHelper.WriteBlankLine();
            ConsoleHelper.WriteBlankLine();
            ConsoleHelper.PauseForEffect(1500);
        }

        // ==================== SPREAD NARRATIVES ====================

        public void IntroduceSpread(Spread spread)
        {
            ConsoleHelper.WriteBlankLine();
            ConsoleHelper.TypeHeader(spread.Name);
            
            ConsoleHelper.TypeWriteLine("The Seer's fingers trace ancient symbols upon the table...", ConsoleHelper.Colors.Mystical, NormalSpeed);
            ConsoleHelper.PauseForEffect(600);
            
            ConsoleHelper.WriteBlankLine();
            ConsoleHelper.TypeWrite("\"", ConsoleHelper.Colors.Mystical, FastSpeed);
            ConsoleHelper.TypeWrite(spread.Description, ConsoleHelper.Colors.Normal, NormalSpeed);
            ConsoleHelper.TypeWriteLine("\"", ConsoleHelper.Colors.Mystical, FastSpeed);
            ConsoleHelper.WriteBlankLine();
            ConsoleHelper.PauseForEffect(800);
        }

        public void BeginReading(ReadingType type)
        {
            ConsoleHelper.WriteBlankLine();
            ConsoleHelper.TypeDivider('═', 60, 5);
            ConsoleHelper.WriteBlankLine();
            
            ConsoleHelper.TypeMystical("The Seer closes their eyes, hands hovering over the deck...");
            ConsoleHelper.PauseForEffect(1000);
            
            ConsoleHelper.TypeWriteLine("The cards begin to hum with ancient power.", ConsoleHelper.Colors.Mystical, SlowSpeed);
            ConsoleHelper.PauseForEffect(1200);
            
            ConsoleHelper.WriteBlankLine();
            ConsoleHelper.TypeDramatic("The reading begins...");
            ConsoleHelper.WriteBlankLine();
            ConsoleHelper.PauseForEffect(800);
        }

        public void CompleteReading()
        {
            ConsoleHelper.WriteBlankLine();
            ConsoleHelper.TypeDivider('═', 60, 5);
            ConsoleHelper.WriteBlankLine();
            
            ConsoleHelper.TypeWriteLine("The Seer's eyes open slowly, returning from the vision...", ConsoleHelper.Colors.Mystical, SlowSpeed);
            ConsoleHelper.PauseForEffect(1000);
            
            ConsoleHelper.TypeWriteLine("\"The cards have spoken. Heed their wisdom well, traveler.\"", ConsoleHelper.Colors.Mystical, NormalSpeed);
            ConsoleHelper.WriteBlankLine();
            ConsoleHelper.PauseForEffect(500);
        }

        // ==================== CARD REVEALS ====================

        public void RevealCard(Card card, SpreadPosition position, int cardIndex, int totalCards)
        {
            ConsoleHelper.WriteBlankLine();
            ConsoleHelper.TypeDivider('─', 50, 5);
            ConsoleHelper.WriteBlankLine();
            
            // Dramatic card reveal
            ConsoleHelper.TypeMystical($"The Seer draws the {GetOrdinal(cardIndex)} card...");
            ConsoleHelper.PauseForEffect(1000);
            
            ConsoleHelper.TypeWriteLine("The card turns, revealing its face...", ConsoleHelper.Colors.Mystical, SlowSpeed);
            ConsoleHelper.PauseForEffect(1200);
            
            ConsoleHelper.WriteBlankLine();
            
            // Position information
            ConsoleHelper.Write("Position: ", ConsoleHelper.Colors.Info);
            ConsoleHelper.TypeWriteLine(position.Name, ConsoleHelper.Colors.Header, NormalSpeed);
            
            ConsoleHelper.Write("Meaning: ", ConsoleHelper.Colors.Info);
            ConsoleHelper.TypeWriteLine(position.Meaning, ConsoleHelper.Colors.Normal, FastSpeed);
            
            ConsoleHelper.WriteBlankLine();
            ConsoleHelper.PauseForEffect(500);
            
            // Card name reveal
            string orientation = card.IsReversed ? "REVERSED" : "UPRIGHT";
            ConsoleColor cardColor = card.IsReversed ? ConsoleHelper.Colors.Reversed : ConsoleHelper.Colors.CardName;
            
            ConsoleHelper.Write("Card: ", ConsoleHelper.Colors.Info);
            ConsoleHelper.RevealText($"{card.Name} ({orientation})", cardColor);
            
            ConsoleHelper.PauseForEffect(800);
            
            // Card meaning
            ConsoleHelper.WriteBlankLine();
            if (card.IsReversed)
            {
                ConsoleHelper.TypeWriteLine("The card appears inverted... a warning, perhaps...", ConsoleHelper.Colors.Warning, NormalSpeed);
                ConsoleHelper.PauseForEffect(600);
            }
            
            ConsoleHelper.TypeWrite("\"", ConsoleHelper.Colors.Mystical, FastSpeed);
            ConsoleHelper.TypeWrite(card.GetMeaning(), ConsoleHelper.Colors.Normal, NormalSpeed);
            ConsoleHelper.TypeWriteLine("\"", ConsoleHelper.Colors.Mystical, FastSpeed);
            
            ConsoleHelper.WriteBlankLine();
            ConsoleHelper.PauseForEffect(1500);
        }

        // ==================== FULL READING DISPLAY ====================

        public void NarrateReading(Reading reading, Spread spread)
        {
            IntroduceSpread(spread);
            BeginReading(reading.Type);
            
            for (int i = 0; i < reading.Cards.Count; i++)
            {
                RevealCard(reading.Cards[i], spread.Positions[i], i + 1, reading.Cards.Count);
            }
            
            CompleteReading();
        }

        // ==================== TRANSITIONS ====================

        public void TransitionToMenu(string menuName)
        {
            ConsoleHelper.WriteBlankLine();
            ConsoleHelper.TypeWriteLine("The Seer gestures toward the shadows...", ConsoleHelper.Colors.Mystical, NormalSpeed);
            ConsoleHelper.PauseForEffect(500);
            ConsoleHelper.Clear();
        }

        public void TransitionToReading()
        {
            ConsoleHelper.WriteBlankLine();
            ConsoleHelper.TypeMystical("The Seer's hands move over the deck, ancient and knowing...");
            ConsoleHelper.PauseForEffect(800);
            ConsoleHelper.WriteBlankLine();
        }

        // ==================== MYSTICAL MESSAGES ====================

        public void SpeakWisdom(string message)
        {
            ConsoleHelper.WriteBlankLine();
            ConsoleHelper.TypeWrite("The Seer whispers: \"", ConsoleHelper.Colors.Mystical, NormalSpeed);
            ConsoleHelper.TypeWrite(message, ConsoleHelper.Colors.Normal, NormalSpeed);
            ConsoleHelper.TypeWriteLine("\"", ConsoleHelper.Colors.Mystical, NormalSpeed);
            ConsoleHelper.WriteBlankLine();
            ConsoleHelper.PauseForEffect(800);
        }

        public void WarnTraveler(string warning)
        {
            ConsoleHelper.WriteBlankLine();
            ConsoleHelper.TypeWrite("The Seer's voice grows stern: \"", ConsoleHelper.Colors.Warning, SlowSpeed);
            ConsoleHelper.TypeWrite(warning, ConsoleHelper.Colors.Warning, SlowSpeed);
            ConsoleHelper.TypeWriteLine("\"", ConsoleHelper.Colors.Warning, SlowSpeed);
            ConsoleHelper.WriteBlankLine();
            ConsoleHelper.PauseForEffect(1000);
        }

        // ==================== HELPER METHODS ====================

        private string GetOrdinal(int number)
        {
            return number switch
            {
                1 => "first",
                2 => "second",
                3 => "third",
                4 => "fourth",
                5 => "fifth",
                _ => $"{number}th"
            };
        }

        // ==================== AUTHENTICATION NARRATIVES ====================

        public void WelcomeNewTraveler()
        {
            ConsoleHelper.WriteBlankLine();
            ConsoleHelper.TypeMystical("\"Ah, a new face in the darkness...\"");
            ConsoleHelper.PauseForEffect(600);
            ConsoleHelper.TypeWriteLine("\"Tell me, traveler, by what name are you known?\"", ConsoleHelper.Colors.Mystical, NormalSpeed);
            ConsoleHelper.WriteBlankLine();
        }

        public void WelcomeReturningTraveler()
        {
            ConsoleHelper.WriteBlankLine();
            ConsoleHelper.TypeMystical("\"I sense a familiar presence...\"");
            ConsoleHelper.PauseForEffect(600);
            ConsoleHelper.TypeWriteLine("\"Speak your name, so I may know you once more.\"", ConsoleHelper.Colors.Mystical, NormalSpeed);
            ConsoleHelper.WriteBlankLine();
        }

        public void GreetUser(string username)
        {
            ConsoleHelper.WriteBlankLine();
            ConsoleHelper.TypeWrite("\"Welcome, ", ConsoleHelper.Colors.Mystical, NormalSpeed);
            ConsoleHelper.TypeWrite(username, ConsoleHelper.Colors.CardName, SlowSpeed);
            ConsoleHelper.TypeWriteLine(".\"", ConsoleHelper.Colors.Mystical, NormalSpeed);
            ConsoleHelper.PauseForEffect(600);
            ConsoleHelper.TypeWriteLine("\"The cards await your inquiry...\"", ConsoleHelper.Colors.Mystical, NormalSpeed);
            ConsoleHelper.WriteBlankLine();
            ConsoleHelper.PauseForEffect(500);
        }
    }
}
