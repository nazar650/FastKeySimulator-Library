using FastKeySimulator.Keystrokes.Mouse.Domain;
using FastKeySimulator.Keystrokes.Mouse.Domain.Interface;
using FastKeySimulator.Structure.Input;
using System.Runtime.InteropServices;
using static FastKeySimulator.Structure.Input.Input;

namespace FastKeySimulator.Keystrokes.Mouse.Domain.Click
{
    internal class MouseClick : IMouseClick
    {
        [DllImport("user32.dll", SetLastError = true)]
        static extern uint SendInput(uint nInputs, [In] INPUT[] pInputs, int cbSize);
        [DllImport("user32.dll")]
        static extern uint SetCursorPos(int x, int y);
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
        public void ScrollWheel(int count, int time)
        {
            if (time < 0)
            {
                time = 0;
            }
            mouse[0].U.mi.dwFlags = 0x0800;
            for (int i = 0; i < time; i++)
            {
                mouse[0].U.mi.mouseData = count;
                SendInput(1, mouse, Marshal.SizeOf(typeof(INPUT)));
                Thread.Sleep(time);
            }
        }
        public void ShowMouse(int x, int y, int steps, int time)
        {
            IShowMouse showMouse = new ShowMouse();
            showMouse.Show_Mouse(x, y, steps, time, mouse);

        }
        public void SetCursorPosition(int x, int y)
        {
            SetCursorPos(x, y);
        }

    }
}
























