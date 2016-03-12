using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Keyboard_Tracker.Engine {
    struct PressedKey {
        // The owner's session
        public int Session; // NOT NEEDED, LEFT IN CASE OF USAGED NEEDED LATER

        // The amount of times the key has been pressed
        public int Amount;
    }

    struct KeySession {
        // Session Identifer(s)
        public int ID;
        public string Name;

        // Total Keys Pressed
        public int TotalPressed;
        
        // Application Specific Tracking
        public bool UseApplicationTracking;
        public IntPtr ApplicationToTrack;

        // Pressed Keys
        public Dictionary<int, PressedKey> Keys;
    }
}
