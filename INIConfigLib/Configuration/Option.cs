using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INIConfigLib.Configuration
{
    /// <summary>
    /// Represents one option of a configuration section.
    /// </summary>
    public class Option
    {
        public string[] Comment { get; protected set; }
        public string[] Documentation { get; protected set; }
        public string Identifier { get; protected set; }
        
        public Option(string identifier, string[] documentation = null)
        {
            Identifier = identifier;
            Documentation = documentation;
            Comment = null;
        }

    }
}
