using FastKeySimulator.Keystrokes.Keyboard.Domain.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace FastKeySimulator.Keystrokes.Keyboard.Domain
{
    internal class KeyParser : IKeyParser
    {
        string nameKey = "";
        string _name = "";
        bool flags = false;

        public (int,List<string>) KeyCombinationParser(string name,int count, List<string> _nameKey)
        {
            _name = name.Replace(" ", "");
            for (int i = 0; i < _name.Length; i++)
            {
                if (flags)
                {
                    flags = false;
                    continue;
                }
                if (_name[i] == '+' && !flags)
                {
                    if (nameKey != "")
                    {
                        count++;
                        _nameKey.Add(nameKey);
                    }
                    nameKey = "";
                    if (_name.Length > i + 1 && _name[i + 1] == '+')
                    {
                        count++;
                        _nameKey.Add("+");
                        flags = true;
                        continue;
                    }
                }
                else
                {
                    nameKey += _name[i];
                    if (_name.Length <= i + 1)
                    {
                        count++;
                        _nameKey.Add(nameKey);
                    }
                }
            }
            return (count, _nameKey);

        }
    }
}
