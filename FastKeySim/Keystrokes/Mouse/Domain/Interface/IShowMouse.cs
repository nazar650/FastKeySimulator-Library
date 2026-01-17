using FastKeySimulator.Structure.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastKeySimulator.Keystrokes.Mouse.Domain.Interface
{
    internal interface IShowMouse
    {
        void Show_Mouse(int x, int y, int steps, int time, Input.INPUT[] mouse);
    }
}
