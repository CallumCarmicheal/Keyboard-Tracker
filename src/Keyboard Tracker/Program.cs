using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Keyboard_Tracker.Engine;

namespace Keyboard_Tracker {
    static class Program {

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            // Enable Display
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            // Setup our Key Listener
            Listener._hookID = Listener.SetHook(Listener._proc);

            // Application Thread
            Application.Run(new Forms.Main());
        }

        public static int GetAmountForKey(Keys key) {
            //int amt = 0; try { amt = Engine.Static.KeySessions[(int)key]; } catch { }
            return 0;
        }
    }
}
