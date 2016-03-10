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
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool UnhookWindowsHookEx(IntPtr hhk);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern IntPtr CallNextHookEx(IntPtr hhk, int nCode, IntPtr wParam, IntPtr lParam);

        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern IntPtr GetModuleHandle(string lpModuleName);

        [DllImport("kernel32.dll")]
        public static extern IntPtr GetConsoleWindow();

        [DllImport("user32.dll")]
        public static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

        public delegate IntPtr LowLevelKeyboardProc(int nCode, IntPtr wParam, IntPtr lParam);

        public static IntPtr HookCallback(int nCode, IntPtr wParam, IntPtr lParam) {
            IntPtr KeyState = (KeyTracker.AllowSpamming ? (IntPtr)WM_KEYDOWN : (IntPtr)WM_KEYUP);
            bool ListenForKeys = KeyTracker.ListenForKeys;
            bool KeyDown = (nCode >= 0 && wParam == KeyState);

            if (ListenForKeys && KeyDown) {
                try {
                    // Increment our global Total key presses
                    KeyTracker.TotalKeysPressed++;

                    // Make sure our key has not changed since the key press started
                    int sessionID = KeyTracker.SessionID;

                    // Our pressed Key
                    int vkCode = Marshal.ReadInt32(lParam);

                    // Create our key class
                    PressedKey pk = new PressedKey();
                    pk.Session = sessionID;
                    pk.Amount = 0;

                    // Create our Session if it does not exist
                    if (!KeyTracker.KeySessions.Keys.Contains(sessionID)) {
                        // Create our session 
                        KeySession session = new KeySession();
                        session.ID = sessionID;
                        session.TotalPressed = 0;
                        session.Name = KeyTracker.NextSessionName;
                        session.Keys = new Dictionary<int, PressedKey>();
                        KeyTracker.KeySessions.Add(sessionID, session);
                        KeyTracker.TotalSessions++;
                    }

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
                } catch(Exception ex) {
                    // Display our exception in the debugger if connected
                    if(System.Diagnostics.Debugger.IsAttached) {
                        string output = "";

                        // Set our leftmost output to time
                        output += System.DateTime.Now.ToString("[dd-MM-yy HH:mm:ss] ");

                        // Add our Exception
                        output += ex.ToString();
                    }

                    // Exceptions not getting thrown
                    //throw ex;
                }
                
            } // */

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
