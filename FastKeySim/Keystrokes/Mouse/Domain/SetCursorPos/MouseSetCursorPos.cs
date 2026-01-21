using System.Runtime.InteropServices;


namespace FastKeySimulator.Keystrokes.Mouse.Domain.SetCursorPos
{
    internal class MouseSetCursorPos
    {
        [DllImport("user32.dll")]
        static extern uint SetCursorPos(int x, int y);
        public void SetCursorPosition(int x, int y)
        {
            SetCursorPos(x, y);
        }
    }
}
