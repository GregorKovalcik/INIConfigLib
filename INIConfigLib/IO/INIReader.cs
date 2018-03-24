using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INIConfigLib.IO
{
    /// <summary>
    /// Provides reading configuration from a file/string/stream.
    /// Reading is available in two modes:
    ///   * strict - unknown options/sections are not allowed.
    ///   * relaxed - unknown options/sections are stored as string.
    /// </summary>
    public class INIReader : INIIO
    {
    }
}
