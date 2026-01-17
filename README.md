# FastKeySimulator
The **FastKeySimulator library** for C# allows programmatic control of the keyboard and mouse in Windows via the WinAPI. It uses the low-level **SendInput API**, which emulates physical key presses, mouse clicks, and cursor movements.
Key Features

---
## Key Features

### 1️⃣ Keyboard
- **Press any key** using its name
- **Release keys**
- **Supports multiple keys pressed simultaneously**
- **Layout-independent** (QWERTY, RUS, ENG, etc.)

### 2️⃣ Mouse
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
    }
}
