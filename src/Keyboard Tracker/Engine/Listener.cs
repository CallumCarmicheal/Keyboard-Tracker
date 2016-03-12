using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Threading;

namespace Keyboard_Tracker.Engine {
    class Listener {

        public const int WH_KEYBOARD_LL = 13;
        public const int WM_KEYDOWN = 0x0100;
        public const int WM_KEYUP = 0x0101;
        public const int SW_HIDE = 0;
        public static IntPtr _hookID = IntPtr.Zero;
        public static LowLevelKeyboardProc _proc = HookCallback;

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern IntPtr SetWindowsHookEx(int idHook, LowLevelKeyboardProc lpfn, IntPtr hMod, uint dwThreadId);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern IntPtr CallNextHookEx(IntPtr hhk, int nCode, IntPtr wParam, IntPtr lParam);

        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern IntPtr GetModuleHandle(string lpModuleName);

        public delegate IntPtr LowLevelKeyboardProc(int nCode, IntPtr wParam, IntPtr lParam);

        public static IntPtr HookCallback(int nCode, IntPtr wParam, IntPtr lParam) {
            IntPtr KeyState = (KeyTracker.AllowSpamming ? (IntPtr)WM_KEYDOWN : (IntPtr)WM_KEYUP);

            bool ListenForKeys = KeyTracker.ListenForKeys;
            bool KeyDown = (nCode >= 0 && wParam == KeyState);

            // Log some stuff for debugging
            if(System.Diagnostics.Debugger.IsAttached) {
                System.Diagnostics.Debugger.Log(0, 
                    "KeyTracker - Engine", 
                    "HookCallback(" + nCode + ", " + wParam + ", " + ((Keys)(Marshal.ReadInt32(lParam))).ToString() + ");" + 
                    Environment.NewLine);
            }

            if (ListenForKeys && KeyDown) {
                // Increment our global Total key presses
                KeyTracker.TotalKeysPressed++;

                // Make sure our key has not changed since the key press started
                int sessionID = KeyTracker.SessionID;

                /* Session Checking and Creation */ {
                    // Create our Session if it does not exist
                    if (!KeyTracker.KeySessions.Keys.Contains(sessionID)) {
                        // Create our session 
                        KeySession session = new KeySession() {
                            // Session Identifiers
                            ID = sessionID,
                            Name = KeyTracker.NextSessionName,

                            // Keys
                            TotalPressed = 0,
                            Keys = new Dictionary<int, PressedKey>(),

                            // Application Tracking
                            UseApplicationTracking = false,
                            ApplicationToTrack = IntPtr.Zero,
                        }; KeyTracker.KeySessions.Add(sessionID, session);

                        KeyTracker.TotalSessions++;
                    }
                }

                /* Check if session is application specific */ {
                    bool useAppTracking = KeyTracker.KeySessions[sessionID].UseApplicationTracking;
                    if (useAppTracking) {
                        // Welp this does not pass the PID... Good Job ME ;-;
                        // TODO :: SOMETIME
                    }
                }

                /* Adding key to current session */ {
                    // Our pressed Key
                    int vkCode = Marshal.ReadInt32(lParam);

                    // Create our key class
                    PressedKey pk = new PressedKey();
                    pk.Session = sessionID;
                    pk.Amount = 0;

                    // Check if our key already exists
                    if (KeyTracker.KeySessions[sessionID].Keys.Keys.Contains(vkCode)) {
                        // Set our amount 
                        pk.Amount = KeyTracker.KeySessions[sessionID].Keys[vkCode].Amount;
                    }

                    // Increment our Pressed amount
                    pk.Amount++;

                    // Increment our global Total key presses
                    KeySession ks = KeyTracker.KeySessions[sessionID]; ks.TotalPressed++;
                    KeyTracker.KeySessions[sessionID] = ks;

                    // Set our Key
                    KeyTracker.KeySessions[sessionID].Keys[vkCode] = pk;
                }
            }

            return CallNextHookEx(_hookID, nCode, wParam, lParam);
        } 

        public static IntPtr SetHook(LowLevelKeyboardProc proc) {
            using (Process curProcess = Process.GetCurrentProcess()) {
                using (ProcessModule curModule = curProcess.MainModule) {
                    return SetWindowsHookEx(WH_KEYBOARD_LL, proc, GetModuleHandle(curModule.ModuleName), 0);
                }
            }
        }
    }
}
