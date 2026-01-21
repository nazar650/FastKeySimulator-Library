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
            public int type;
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
            public ushort wScan;     
             public uint dwFlags;       
             public uint time;       
            public IntPtr dwExtraInfo; 
        }
        [StructLayout(LayoutKind.Sequential)]
        public struct MOUSEINPUT
        {
            public int dx;        
            public int dy;          
             public int mouseData; 
             public uint dwFlags;   
             public uint time;       
             public IntPtr dwExtraInfo;
        }
    }
}
