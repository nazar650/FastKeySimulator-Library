using FastKeySimulator.Keystrokes.Keyboard.Click;
using FastKeySimulator.Keystrokes.Mouse.Domain.Click;
using FastKeySimulator.Keystrokes.Mouse.Domain.Interface;

namespace FastKeySimulator
{
    public class FastKeySim
    {
        KeyboardClick keyboard = new KeyboardClick();
        IMouseClick mouse = new MouseClick();
        public void KeyBoardClick(string name)
        {
            keyboard.Click(name);
        }
        public void MouseClick(string name)
        {
            mouse.Click(name);
        }
        public void MouseScrollWheel(int count,int time)
        {
            mouse.ScrollWheel(count,time);
        }
        public void MouseSetCursorPos(int x,int y)
        {
            mouse.SetCursorPosition(x,y);
        }
        public void MouseShowMouse(int x,int y,int steps,int time)
        {
            mouse.ShowMouse(x,y,steps,time);
        }
    }
}
