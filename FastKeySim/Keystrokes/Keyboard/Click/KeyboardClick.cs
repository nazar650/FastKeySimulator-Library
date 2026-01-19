using FastKeySimulator.Structure.Input;
using System.Runtime.InteropServices;
using static FastKeySimulator.Structure.Input.Input;
namespace FastKeySimulator.Keystrokes.Keyboard.Click
{
    internal class KeyboardClick
    {
        [DllImport("user32.dll", SetLastError = true)]
        static extern uint SendInput(uint nInputs, [In] INPUT[] pInputs, int cbSize);
       
      
        public void Click(ushort[] name)
        {
           
            
        int count = name.Length;
            INPUT[] keyboard = new INPUT[count * 2];
            for (int i = 0; i < count; i++)
            {
                keyboard[i].type = 1;
                keyboard[i].U.ki.wScan = name[i];
                keyboard[i].U.ki.dwFlags = 0x0008;
            }
            for (int i = 0; i < count; i++)
            {
                keyboard[count + i].type = 1;
                keyboard[count + i].U.ki.wScan = name[i];
                keyboard[count + i].U.ki.dwFlags = 0x0008 | 0x0002;
            }

            SendInput((uint)keyboard.Length, keyboard, Marshal.SizeOf(typeof(INPUT)));
        }
    }
}
