using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INIConfigLib.Configuration.Elements
{
    public class BooleanElement : Element
    {
        public bool Value { get; protected set; }

        
        public BooleanElement(bool value)
        {
            Value = value;
        }


        // TODO: move to reader/writer, or rather not...
        //private static readonly string[] TRUE_VALUES = new string[] { "1", "t", "y", "on", "yes", "enabled" };
        //private static readonly string[] FALSE_VALUES = new string[] { "0", "f", "n", "off", "no", "disabled" };


    }
}
