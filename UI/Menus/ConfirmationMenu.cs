using System;
using System.Collections.Generic;
using TheSeer.Services;

namespace TheSeer.UI.Menus
{
    /// <summary>
    /// Reusable confirmation menu for yes/no decisions with arrow-key navigation
    /// </summary>
    internal class ConfirmationMenu : BaseMenu
    {
        private readonly string _title;
        private readonly string _question;
        private readonly string _yesText;
        private readonly string _noText;

        public ConfirmationMenu(
            Narrator narrator,
            string title,
            string question,
            string yesText = "Yes",
            string noText = "No") : base(narrator)
        {
            _title = title;
            _question = question;
            _yesText = yesText;
            _noText = noText;
        }

        protected override List<string> GetMenuOptions()
        {
            return [_yesText, _noText];
        }

        /// <summary>
        /// Shows confirmation menu and returns true if user selects "Yes"
        /// </summary>
        public override bool Show()
        {
            int choice = ShowInteractiveMenu(_title, _question);
            return choice == 1; // True if first option (Yes) selected
        }
    }
}