using INIConfigLib.Configuration.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INIConfigLib.Configuration
{
    /// <summary>
    /// Builder used to create a custom configuration.
    /// </summary>
    public class INIConfigBuilder
    {
        INIConfiguration configuration;
        Section currentSection = null;

        public INIConfigBuilder()
        {
            configuration = new INIConfiguration();
        }

        public INIConfiguration GetResult()
        {
            return configuration;
        }

        public INIConfigBuilder Section(string identifier, string[] documentation = null, bool isOptional = false)
        {
            Section section = new Section(identifier, documentation, isOptional);
            currentSection = section;
            configuration.sections.Add(section);
            return this;
        }

        public INIConfigBuilder Option(string identifier, string[] documentation = null, bool isOptional = false)
        {
            // TODO
            Option option = new Option(identifier, null);
            currentSection.options.Add(option);
            return this;
        }

    }
}
