using System.Runtime.InteropServices;
using static FastKeySimulator.Structure.Input.Input;

namespace FastKeySimulator.Keystrokes.Mouse.Domain.ScrollWheel
{
    internal class MouseScrollWheel
    {
        [DllImport("user32.dll", SetLastError = true)]
        static extern uint SendInput(uint nInputs, [In] INPUT[] pInputs, int cbSize);
        INPUT[] mouse = new INPUT[2];
        public MouseScrollWheel()
        {
            mouse[0].type = 0;
            mouse[1].type = 0;
        }
        public async Task ScrollWheelAsync(int count, int timeDelay)
        {
            if (timeDelay < 0)
            {
                timeDelay = 0;
            }
            mouse[0].U.mi.dwFlags = 0x0800;
            float steps = (float)count / timeDelay;
            float Scroll = 0;
            for (int i = 0; i < timeDelay; i++)
            {
                Scroll += steps;
                int Temp = (int)Scroll;
                Scroll -= Temp;
                mouse[0].U.mi.mouseData = Temp;
                SendInput(1, mouse, Marshal.SizeOf(typeof(INPUT)));
                await Task.Delay(1);
            }
        }
        
        
    }
}
