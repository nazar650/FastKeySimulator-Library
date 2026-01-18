# FastKeySimulator
The **FastKeySimulator library** for C# allows programmatic control of the keyboard and mouse in Windows via the WinAPI. It uses the low-level **SendInput API**, which emulates physical key presses, mouse clicks, and cursor movements.
Key Features

---
## Key Features

### 1. Keyboard
- **Press any key** using its name
- **Release keys**
- **Supports multiple keys pressed simultaneously**
- **Layout-independent** (QWERTY, RUS, ENG, etc.)

### 2. Mouse
- **Left, Right, and Middle clicks**
- **Scroll wheel support**
- **Move the cursor to absolute coordinates**
- **Smooth cursor movement**
---
## Keyboard Simulation with FastKeySim
The **FastKeySim** class allows you to easily simulate keyboard and mouse input in your C# applications. You can press single keys or key combinations with a single method call, without worrying about low-level WinAPI details.The **KeyboardClick()** method allows you to simulate pressing single keys or key combinations on the keyboard with just one call. It handles both the press and release events, so Windows sees it as a real key press.

### How to use
```csharp
using FastKeySimulator;
internal class Program
{
    private static void Main(string[] args)
    {
        FastKeySim fast=new FastKeySim();
        Thread.Sleep(6000);
        // Press a single key
        fast.KeyBoardClick("w");
        // Press a key combination (Shift + w)
        fast.KeyBoardClick("Shift+w");
        // Press multiple keys (Alt + Shift)
        fast.KeyBoardClick("Alt+Shift);
    }
}
```
## Mouse Simulation with FastKeySim

- The FastKeySim class also provides powerful tools for simulating mouse input in your C# applications. It allows you to perform mouse clicks, scroll the mouse wheel, move the cursor to specific screen positions, and create smooth cursor movements — all with simple and high-level method calls.

- The MouseClick() method allows you to simulate left, right, and middle mouse button clicks. It automatically handles both the press and release events, so Windows recognizes the action as a real physical mouse click.

- The MouseScrollWheel() method allows you to simulate mouse wheel scrolling. You can scroll up or down by specifying the number of steps and control the scrolling speed using a time delay.

- The MouseSetCursorPos() method allows you to instantly move the mouse cursor to any position on the screen using absolute coordinates.

- The MouseShowMouse() method allows you to smoothly move the mouse cursor to a target position in multiple steps, creating a natural and human-like movement effect.

### How to use **MouseClick(string name)**
```csharp
using FastKeySimulator;
internal class Program
{
    private static void Main(string[] args)
    {
        FastKeySim fast=new FastKeySim();
        Thread.Sleep(6000);

        // Left mouse click
        fast.MouseClick("Left");

        // Right mouse click
        fast.MouseClick("Right");

        // Middle mouse click
        fast.MouseClick("Middle");

    }
}
```
### How to use **MouseScrollWheel(int count, int time)**
- **count** — Number of scroll steps
   - Positive value → scroll up
   - Negative value → scroll down
- **time** — Delay (in milliseconds) between scroll steps
```csharp
using FastKeySimulator;
internal class Program
{
    private static void Main(string[] args)
    {
        FastKeySim fast=new FastKeySim();
        Thread.Sleep(6000);
        // Scroll up 3 steps
        fast.MouseScrollWheel(3, 10);

        // Scroll down 2 steps
        fast.MouseScrollWheel(-2, 15);

    }
}
```
###  How to use  **MouseSetCursorPos(int x, int y)**
Moves the mouse cursor to an absolute screen position.
- **x** — X coordinate (pixels)
- **y** — Y coordinate (pixels)
```csharp
