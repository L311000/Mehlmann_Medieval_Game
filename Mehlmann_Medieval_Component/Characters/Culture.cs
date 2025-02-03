using Mehlmann_Medieval_Component.Localisations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mehlmann_Medieval_Component.Characters
{
    public class Culture
    {
        public Namelist Names { get; set; }
        public bool UsesMiddleNames { get; set; }
        public int MaxAmountMiddleNames { get; set; }
        public int MinAmountMiddleNames { get; set; } = 0;
        public int Father_Name_Chance { get; set; }
        public int Mother_Name_Chance { get; set; }

        public Random RND { get; set; } = new();
    }
}
