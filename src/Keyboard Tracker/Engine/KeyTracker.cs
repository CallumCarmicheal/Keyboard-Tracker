using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Keyboard_Tracker.Engine {
    class KeyTracker {
        public static bool AllowSpamming = false;
        public static bool ListenForKeys = true;
        public static int TotalKeysPressed = 0;
        public static int SessionID = 0;        // 0  = First Session
        public static int TotalSessions = -1;   // -1 = NO SESSIONS
        public static string NextSessionName = "Defualt Name";

        public static Dictionary<int, KeySession> KeySessions = new Dictionary<int, KeySession>();
    }
}
