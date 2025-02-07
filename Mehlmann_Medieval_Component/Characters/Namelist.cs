using Mehlmann_Medieval_Component.Localisations;
using Mehlmann_Medieval_Component.Misc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mehlmann_Medieval_Component.Characters
{
    public class Namelist : ComponentBase
    {
        public Localisation DisplayedName {  get; set; }
        public List<Localisation> FirstNamesMale { get; set; } = [];
        public List<Localisation> FirstNamesFemale { get; set; } = [];

        public List<Localisation> MiddleNamesMale { get; set; } = [];
        public List<Localisation> MiddleNamesFemale { get; set; } = [];

        public List<Localisation> FamilyNames { get; set; } = [];

    }
}
