using Mehlmann_Medieval_Component.Localisations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mehlmann_Medieval_Component.Characters
{
    public class Family_Status : ComponentBase
    {
        public string DisplayedName { get; set; }
        public long RequiredRenown {  get; set; }
        public int Level { get; set; }
    }
}
