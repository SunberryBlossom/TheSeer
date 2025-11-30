using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheSeer.Interfaces;
using TheSeer.UI.Screens;

namespace TheSeer.Managers
{
    internal static class ScreenManager
    {
        private static readonly List<IScreen> Screens = new List<IScreen> 
            {
                new StartupScreen(),
            };
    }
}
