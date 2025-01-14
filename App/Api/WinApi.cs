﻿using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace App
{
    internal class WinApi
    {
        [DllImport("user32.dll")]
        public static extern bool PostMessage(IntPtr hWnd, uint Msg, uint wParam, uint lParam);

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool FlashWindowEx(ref FLASHWINFO pwfi);

        [StructLayout(LayoutKind.Sequential)]
        private struct FLASHWINFO
        {
            public uint cbSize;
            public IntPtr hwnd;
            public uint dwFlags;
            public uint uCount;
            public uint dwTimeout;
        }

        private const uint FLASHW_ALL = 0x3;
        private const uint FLASHW_TIMERNOFG = 0xC;

        internal static void FlashWindow(Process process)
        {
            var pwfi = new FLASHWINFO();

            pwfi.cbSize = Convert.ToUInt32(Marshal.SizeOf(pwfi));
            pwfi.hwnd = process.MainWindowHandle;
            pwfi.dwFlags = FLASHW_ALL | FLASHW_TIMERNOFG;
            pwfi.uCount = uint.MaxValue;
            pwfi.dwTimeout = 0;

            FlashWindowEx(ref pwfi);
        }

        internal static void PostF24(Process process)
        {
            PostMessage(process.MainWindowHandle, 0x0100, 0x87, 0);
            PostMessage(process.MainWindowHandle, 0x0101, 0x87, 0);
        }
    }
}