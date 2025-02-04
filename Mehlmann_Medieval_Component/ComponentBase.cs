using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mehlmann_Medieval_Component
{
    public abstract class ComponentBase
    {
        public string InternalName { get; set; } = null;
        public long? ID { get; set; } = null;
    }
}
