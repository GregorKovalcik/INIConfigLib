using INIConfigLib.Configuration.Elements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INIConfigLib.Configuration.Options
{
    /// <summary>
    /// Represents one option of a configuration section.
    /// </summary>
    public class Option
    {
        public string[] Comment { get; protected set; }
        public string[] Documentation { get; protected set; }
        public string Identifier { get; protected set; }
        public bool IsOptional { get; protected set; }

        public Element[] Element { get; protected set; }

        public Option(string identifier, Element[] elements, string[] documentation = null, bool isOptional = false)
        {
            Identifier = identifier;
            Element = elements;

            Documentation = documentation;
            Comment = null;
            IsOptional = isOptional;
        }


        private static void CheckAreElementsSameType(Element[] element)
        {
            if (element.Length > 0)
            {
                Type firstElementType = element[0].GetType();
                for (int i = 1; i < element.Length; i++)
                {
                    if (element[i].GetType() != firstElementType)
                    {
                        throw new ArgumentException("Option array of elements are not of the same type!");
                    }
                }
            }
        }
    }
}
