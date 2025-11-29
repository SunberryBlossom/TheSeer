using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheSeer.Interfaces;

namespace TheSeer.UI.Screens
{
    internal class StartupScreen : Screen, IScreen
    {
        // ASCII Art for The Seer

        private static readonly string AsciiArt = @"";
        public void Display()
        {
            Console.WriteLine(AsciiArt);
            
        }
    }
}
