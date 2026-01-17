using FastKeySimulator.Structure.Input;
using System.Runtime.InteropServices;
using static FastKeySimulator.Structure.Input.Input;
using FastKeySimulator.Keystrokes.Keyboard.Domain.Interface;
using FastKeySimulator.Keystrokes.Keyboard.Domain;
using FastKeySimulator.Structure.ScanCode.Keyboard;
namespace FastKeySimulator.Keystrokes.Keyboard.Click
{
    internal class KeyboardClick
    {
        [DllImport("user32.dll", SetLastError = true)]
        static extern uint SendInput(uint nInputs, [In] INPUT[] pInputs, int cbSize);
        ScanCode[] scanCode=new ScanCode[0];
        int count = 0;
        List<string> _nameKey = new List<string>();
       IKeyParser keyParser = new KeyParser();
        private void CreateScanCode()
        {
            scanCode = new ScanCode[count];
            for (int i = 0; i < count; i++)
            {
                scanCode[i] = new ScanCode(_nameKey[i]);
            }
        }
        public void Click(string name)
        {
            (count, _nameKey) = keyParser.KeyCombinationParser(name, count, _nameKey);
            CreateScanCode();
            INPUT[] keyboard = new INPUT[count * 2];
            for (int i = 0; i < count; i++)
            {
                keyboard[i].type = 1;
                keyboard[i].U.ki.wScan = scanCode[i].Scancode();
                keyboard[i].U.ki.dwFlags = 0x0008;
            }
            for (int i = 0; i < count; i++)
            {
                keyboard[count + i].type = 1;
                keyboard[count + i].U.ki.wScan = scanCode[i].Scancode();
                keyboard[count + i].U.ki.dwFlags = 0x0008 | 0x0002;
            }

            SendInput((uint)keyboard.Length, keyboard, Marshal.SizeOf(typeof(INPUT)));
        }
    }
}
