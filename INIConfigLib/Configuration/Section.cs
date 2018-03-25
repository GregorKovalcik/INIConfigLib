using INIConfigLib.Configuration.Interfaces;
using INIConfigLib.IO;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
        public string[] Comment { get; protected set; }
        public string[] Documentation { get; protected set; }
        public string Identifier { get; protected set; }
        
        internal List<Option> options = new List<Option>();
        public ReadOnlyCollection<Option> Options { get { return options.AsReadOnly(); } }


        public Section(string identifier, string[] documentation = null)
        {
            Identifier = identifier;
            Documentation = documentation;
            Comment = null;
        }


        /// <summary>
        /// Provides an easy access to a section option.
        /// </summary>
        /// <param name="identifier"></param>
        /// <returns></returns>
        public Option this[string identifier]
        {
            get
            {
                return options
                    .Where(option => option.Identifier.Equals(identifier))
                    .First();
            }
        }


        public void Accept(ISectionVisitor visitor)
        {
            visitor.Visit(this);
        }


        public static Section FromString()
        {
            return null;
        }
    }
}
