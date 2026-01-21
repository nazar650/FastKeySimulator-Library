using System.Runtime.InteropServices;
using static FastKeySimulator.Structure.Input.Input;

namespace FastKeySimulator.Keystrokes.Mouse.Domain.Click
{
    internal class MouseClick
    {
        [DllImport("user32.dll", SetLastError = true)]
        static extern uint SendInput(uint nInputs, [In] INPUT[] pInputs, int cbSize);

        INPUT[] mouse = new INPUT[2];
        public MouseClick()
        {
            mouse[0].type = 0;
            mouse[1].type = 0;
        }
        public void Click(string nameKey)
        {
            if (string.Equals(nameKey, "left", StringComparison.OrdinalIgnoreCase))
            {
                mouse[0].U.mi.dwFlags = 0x0002;
                mouse[1].U.mi.dwFlags = 0x0004;
            }
            if (string.Equals(nameKey, "right", StringComparison.OrdinalIgnoreCase))
            {
                mouse[0].U.mi.dwFlags = 0x0008;
                mouse[1].U.mi.dwFlags = 0x0010;
            }
            if (string.Equals(nameKey, "middle", StringComparison.OrdinalIgnoreCase))
            {
                mouse[0].U.mi.dwFlags = 0x0020;
                mouse[0].U.mi.dwFlags = 0x0040;
            }
            SendInput((uint)mouse.Length, mouse, Marshal.SizeOf(typeof(INPUT)));
        }
    }
    
}