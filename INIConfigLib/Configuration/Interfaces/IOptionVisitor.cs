using INIConfigLib.Configuration.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INIConfigLib.Configuration.Interfaces
{
    public interface IOptionVisitor
    {
        void Visit(Option option);
    }
}
