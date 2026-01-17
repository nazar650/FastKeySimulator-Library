using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace FastKeySimulator.Structure.Input
{
    internal class Input
    {

        [StructLayout(LayoutKind.Sequential)]
       public struct INPUT
        {
            public int type; // 1 = клавіатура, 0 = миша
            public InputUnion U;
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct InputUnion
        {
            [FieldOffset(0)] public KEYBDINPUT ki;
            [FieldOffset(0)] public MOUSEINPUT mi;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct KEYBDINPUT
        {
            public ushort wVk;
            public ushort wScan;       // Scan code (фізичний код)
             public uint dwFlags;       // 0=натискання, KEYEVENTF_KEYUP=відпускання
             public uint time;          // Час
            public IntPtr dwExtraInfo; // Додаткова інформація
        }
        [StructLayout(LayoutKind.Sequential)]
        public struct MOUSEINPUT
        {
            public int dx;          // положення миші по X
            public int dy;          // положення миші по Y
             public int mouseData;  // додаткові дані (наприклад, коліщатко)
             public uint dwFlags;    // прапори дій миші (натискання, рух, колесо)
             public uint time;       // час події (0 = система сама)
             public IntPtr dwExtraInfo; // додаткові дані
        }
    }
}
