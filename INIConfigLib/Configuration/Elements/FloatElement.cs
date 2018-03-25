using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INIConfigLib.Configuration.Elements
{
    public class FloatElement : Element
    {
        public double Value { get; protected set; }


        public FloatElement(double value)
        {
            Value = value;
        }
    }
}
