using Mehlmann_Medieval_Component.Graphical;
using Mehlmann_Medieval_Component.Localisations;
using Mehlmann_Medieval_Component.Misc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mehlmann_Medieval_Component.Characters
{
    public class Family : ComponentBase
    {
        public Localisation DisplayedName {  get; set; }
        public Localisation Prefix { get; set; }
        public Family_Status Status { get; set; }
        public List<Character> Members { get; set; }
        public List<Family> CadetFamilies { get; set; }
        public bool Extinct { get; set; } = false;
        public bool IsCadetFamily { get; set; } = false;
        public CoA CoatOfArms { get; set; }
        public long Renown {  get; set; }
    }
}
