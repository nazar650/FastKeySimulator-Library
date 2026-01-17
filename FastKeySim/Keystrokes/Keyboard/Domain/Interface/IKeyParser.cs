using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastKeySimulator.Keystrokes.Keyboard.Domain.Interface
{
    internal interface IKeyParser
    {
        (int,List<string>) KeyCombinationParser(string name,int count,List<string> _nameKey);
    }
}
