using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INIConfigLib.Configuration.Elements
{
    public class UnsignedElement : Element
    {
        public ulong Value { get; protected set; }


        public UnsignedElement(ulong value)
        {
            Value = value;
        }

        // TODO: hexa prefix in parser, or rather here?
    }
}
