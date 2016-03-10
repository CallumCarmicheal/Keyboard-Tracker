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

namespace Keyboard_Tracker {
    class KeyListener {

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
            IntPtr KeyState = (Program.AllowSpamming ? (IntPtr)WM_KEYDOWN : (IntPtr)WM_KEYUP);
            bool ListenForKeys = Program.ListenForKeys;
            bool KeyDown = (nCode >= 0 && wParam == KeyState);

            if (ListenForKeys && KeyDown) {
                int vkCode = Marshal.ReadInt32(lParam);
                Program.TotalKeysPressed++;
                if(!Program.PressedKeys.Keys.Contains(vkCode)) {
                    Program.PressedKeys.Add(vkCode, 1);
                } else {
                    Program.PressedKeys[vkCode]++;
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
