using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INIConfigLib.Configuration.Elements
{
    public class SignedElement : Element
    {
        public long Value { get; protected set; }


        public SignedElement(long value)
        {
            Value = value;
        }
    }
}
