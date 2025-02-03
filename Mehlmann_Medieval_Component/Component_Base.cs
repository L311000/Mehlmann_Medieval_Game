using Mehlmann_Medieval_Component.Localisations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mehlmann_Medieval_Component
{
    public abstract class Component_Base
    {
        public long ID {  get; set; }
        public Localisation Name { get; set; } = null;
    }
}
