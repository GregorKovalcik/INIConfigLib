using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INIConfigLib.IO
{
    /// <summary>
    /// Provides writing configuration to a file/string/stream.
    /// Writing is available in two modes: 
    ///   * minimal - optional options with default values are hidden.
    ///   * full - all options are written, including the optional ones.
    /// </summary>
    public class INIWriter : INIIO
    {
    }
}
