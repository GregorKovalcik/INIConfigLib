using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INIConfigLib.Configuration
{
    /// <summary>
    /// Stores the actual INI configuration, conforming to a provided INIFormat.
    /// </summary>
    public class INIConfiguration
    {
        internal List<Section> sections = new List<Section>();
        public ReadOnlyCollection<Section> Sections { get { return sections.AsReadOnly(); } }

    }
}
