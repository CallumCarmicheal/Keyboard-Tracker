using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Keyboard_Tracker.Engine {
    struct PressedKey {
        public int Session; // NOT NEEDED, LEFT IN CASE OF USAGED NEEDED LATER
        public int Amount;
    }

    struct KeySession {
        public int ID;
        public string Name;
        public int TotalPressed;
        public Dictionary<int, PressedKey> Keys;
    }
}
