using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INIConfigLib.Configuration.Elements
{
    public class EnumElement : Element
    {
        public string[] EnumSet { get; protected set; }

        public string DefaultValue { get; protected set; }
        private string value = null;
        public string Value
        {
            get
            {
                return value ?? DefaultValue;
            }
            set
            {
                if (EnumSet.Contains(value))
                {
                    this.value = value;
                }
                else
                {
                    throw new ArgumentException("EnumSet does not contain the enum value!");
                }
            }
        }


        public EnumElement(string[] enumSet, string defaultValue)
        {
            EnumSet = enumSet;
            DefaultValue = defaultValue;
        }
    }
}
