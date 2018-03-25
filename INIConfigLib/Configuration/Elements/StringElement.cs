using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INIConfigLib.Configuration.Elements
{
    public class StringElement : Element
    {
        public string DefaultValue { get; protected set; }
        private string value = null;
        public string Value
        {
            get { return value ?? DefaultValue; }
            set { this.value = value; }
        }


        public StringElement(string defaultValue)
        {
            DefaultValue = defaultValue;
        }


        // TODO: escape in parser and builder? maybe here...
    }
}
