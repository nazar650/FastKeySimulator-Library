using FastKeySimulator.Keystrokes.Mouse.Domain.Interface;
using FastKeySimulator.Structure.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using static FastKeySimulator.Structure.Input.Input;

namespace FastKeySimulator.Keystrokes.Mouse.Domain
{
    internal class ShowMouse : IShowMouse
    {

        [DllImport("user32.dll", SetLastError = true)]
        static extern uint SendInput(uint nInputs, [In] INPUT[] pInputs, int cbSize);
        public void Show_Mouse(int x, int y, int steps, int time, Input.INPUT[] mouse)
        {
            if (time < 0)
            {
                time = 0;
            }
            float stepXTemp = (float)x / steps;
            float stepYTemp = (float)y / steps;
            int stepX = (int)stepXTemp;
            int stepY = (int)stepYTemp;
            stepXTemp = (stepXTemp - stepX) * steps;
            stepYTemp = (stepYTemp - stepY) * steps;
            mouse[0].U.mi.dwFlags = 0x0001;
            for (int i = 0; i < steps; i++)
            {
                mouse[0].U.mi.dx = stepX;
                mouse[0].U.mi.dy = stepY;
                SendInput(1, mouse, Marshal.SizeOf(typeof(Input.INPUT)));
                Thread.Sleep(time);
            }
            mouse[0].U.mi.dx = (int)stepXTemp;
            mouse[0].U.mi.dy = (int)stepYTemp;
            SendInput(1, mouse, Marshal.SizeOf(typeof(Input.INPUT)));

        }
    }
}
