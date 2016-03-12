using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Keyboard_Tracker.Engine {
    class KeyTracker {
        // Swap between keyDown and keyUp
        public static bool AllowSpamming = false;

        // Listen for key presses
        public static bool ListenForKeys = true;


        // Global total keys that have been pressed
        public static int TotalKeysPressed = 0;

        // 0  = First Session
        public static int SessionID = 0;                        
        
        // -1 = NO SESSIONS
        public static int TotalSessions = -1;
        
        // The next sessions name (DEFINED BY THE LOGGER IF SESSION DOES NOT EXIST)
        public static string NextSessionName = "Defualt Name";

        // All the keys that have been pressed
        public static Dictionary<int, KeySession> KeySessions = new Dictionary<int, KeySession>();

        // Get the session via ID
        public static KeySession getSessionByID(int ID, ref bool Exists) {
            if(!KeySessions.Keys.Contains(ID)) 
                return default(KeySession);
            return KeySessions[ID];
        }

        public static void setKeySessionByID(KeySession session, int ID) {
            lock (KeySessions) {
                KeySessions[ID] = session;
            }
        }
    }
}
