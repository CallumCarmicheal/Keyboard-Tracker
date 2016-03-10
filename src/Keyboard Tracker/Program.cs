using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Keyboard_Tracker {
    static class Program {

        public static bool AllowSpamming = false;
        public static bool ListenForKeys = true;
        public static int TotalKeysPressed = 0;
        public static Dictionary<int, int> PressedKeys = new Dictionary<int, int>();


        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            // Setup our Key Listener
            KeyListener._hookID = KeyListener.SetHook(KeyListener._proc);

            // Application Thread
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new GUI());
        }

        public static int GetAmountForKey(Keys key) {
            int amt = 0; try { amt = Program.PressedKeys[(int)key]; } catch { }
            return amt;
        }
    }
}
