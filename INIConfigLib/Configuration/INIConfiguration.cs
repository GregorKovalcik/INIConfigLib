using System;
using System.Collections.Generic;
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
        public List<Section> Sections { get; protected set; }
    }
}
