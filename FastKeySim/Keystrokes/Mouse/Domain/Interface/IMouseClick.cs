namespace FastKeySimulator.Keystrokes.Mouse.Domain.Interface
{
    internal interface IMouseClick
    {
        void Click(string nameKey);
        void ScrollWheel(int count, int time);
        void SetCursorPosition(int x, int y);
        void ShowMouse(int x, int y, int steps, int time);
    }
}