using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INIConfigLib.Configuration
{
    /// <summary>
    /// Represents one section of a configuration. Contains a list of Options.
    /// </summary>
    public class Section
    {
        public List<Option> Options { get; protected set; }
    }
}
