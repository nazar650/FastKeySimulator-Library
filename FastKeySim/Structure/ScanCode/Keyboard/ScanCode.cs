namespace FastKeySimulator.Structure.ScanCode.Keyboard
{
    internal class ScanCode
    {
        private ushort scancode;
        public ScanCode(string scancodeKey)
        {
            switch (scancodeKey?.ToLower())
            {
                case "esc":
                    scancode = 1;
                    break;
                case "1":
                    scancode = 2;
                    break;
                case "2":
                    scancode = 3;
                    break;
                case "3":
                    scancode = 4;
                    break;
                case "4":
                    scancode = 5;
                    break;
                case "5":
                    scancode = 6;
                    break;
                case "6":
                    scancode = 7;
                    break;
                case "7":
                    scancode = 8;
                    break;
                case "8":
                    scancode = 9;
                    break;
                case "9":
                    scancode = 10;
                    break;
                case "0":
                    scancode = 11;
                    break;
                case "-":
                    scancode = 12;
                    break;
                case "=":
                    scancode = 13;
                    break;
                case "bs" or "backspace":
                    scancode = 14;
                    break;
                case "Tab" or "tab":
                    scancode = 15;
                    break;
                case "q":
                    scancode = 16;
                    break;
                case "w":
                    scancode = 17;
                    break;
                case "e":
                    scancode = 18;
                    break;
                case "r":
                    scancode = 19;
                    break;
                case "t":
                    scancode = 20;
                    break;
                case "y":
                    scancode = 21;
                    break;
                case "u":
                    scancode = 22;
                    break;
                case "i":
                    scancode = 23;
                    break;
                case "o":
                    scancode = 24;
                    break;
                case "p":
                    scancode = 25;
                    break;
                case "[":
                    scancode = 26;
                    break;
                case "]":
                    scancode = 27;
                    break;
                case "enter":
                    scancode = 28;
                    break;
                case "CTRL" or "Ctrl" or "ctrl":
                    scancode = 29;
                    break;
                case "a":
                    scancode = 30;
                    break;
                case "s":
                    scancode = 31;
                    break;
                case "d":
                    scancode = 32;
                    break;
                case "f":
                    scancode = 33;
                    break;
                case "g":
                    scancode = 34;
                    break;
                case "h":
                    scancode = 35;
                    break;
                case "j":
                    scancode = 36;
                    break;
                case "k":
                    scancode = 37;
                    break;
                case "l":
                    scancode = 38;
                    break;
                case ";":
                    scancode = 39;
                    break;
                case "'":
                    scancode = 40;
                    break;
                case "`":
                    scancode = 41;
                    break;
                case "lshift" or "shift":
                    scancode = 42;
                    break;
                case @"\":
                    scancode = 43;
                    break;
                case "z":
                    scancode = 44;
                    break;
                case "x":
                    scancode = 45;
                    break;
                case "c":
                    scancode = 46;
                    break;
                case "v":
                    scancode = 47;
                    break;
                case "b":
                    scancode = 48;
                    break;
                case "n":
                    scancode = 49;
                    break;
                case "m":
                    scancode = 50;
                    break;
                case ",":
                    scancode = 51;
                    break;
                case ".":
                    scancode = 52;
                    break;
                case "/":
                    scancode = 53;
                    break;
                case "rshift":
                    scancode = 54;
                    break;
                case "prtsc" or "print screen" or "printscreen":
                    scancode = 55;
                    break;
                case "alt":
                    scancode = 56;
                    break;
                case "space":
                    scancode = 57;
                    break;
                case "caps":
                    scancode = 58;
                    break;
                case "f1":
                    scancode = 59;
                    break;
                case "f2":
                    scancode = 60;
                    break;
                case "f3":
                    scancode = 61;
                    break;
                case "f4":
                    scancode = 62;
                    break;
                case "f5":
                    scancode = 63;
                    break;
                case "f6":
                    scancode = 64;
                    break;
                case "f7":
                    scancode = 65;
                    break;
                case "f8":
                    scancode = 66;
                    break;
                case "f9":
                    scancode = 67;
                    break;
                case "f10":
                    scancode = 68;
                    break;
                case "num" or"numlock":
                    scancode = 69;
                    break;
                case "scroll":
                    scancode = 70;
                    break;
                case "home":
                    scancode = 71;
                    break;
                case "up":
                    scancode = 72;
                    break;
                case "pgup":
                    scancode = 73;
                    break;
                case "left":
                    scancode = 75;
                    break;
                case "center":
                    scancode = 76;
                    break;
                case "right":
                    scancode = 77;
                    break;
                case "+":
                    scancode = 78;
                    break;
                case "end":
                    scancode = 79;
                    break;
                case "down":
                    scancode = 80;
                    break;
                case "pgdn":
                    scancode = 81;
                    break;
                case "ins" or "insert":
                    scancode = 82;
                    break;
                case "del" or "delete":
                    scancode = 83;
                    break;
                case "f11":
                    scancode = 87;
                    break;
                case "f12":
                    scancode = 88;
                    break;
                case "lwin" or "leftwin" or "win"  or "windows":
                    scancode = 91;
                    break;
                default:
                    scancode = 1;
                    break;


            }
        }
        public ushort Scancode()
        {
            return scancode;
        }
    }
}
