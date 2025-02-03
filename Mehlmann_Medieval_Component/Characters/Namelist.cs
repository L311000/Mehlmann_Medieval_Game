using Mehlmann_Medieval_Component.Localisations;
using Mehlmann_Medieval_Component.Misc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mehlmann_Medieval_Component.Characters
{
    public class Namelist
    {
        public Localisation Name {  get; set; }
        public List<Localisation> FirstNamesMale { get; set; } = new List<Localisation>();
        public List<Localisation> FirstNamesFemale { get; set; } = new List<Localisation>();

        public List<Localisation> MiddleNamesMale { get; set; } = new List<Localisation>();
        public List<Localisation> MiddleNamesFemale { get; set; } = new List<Localisation>();

        public List<Localisation> FamilyNames { get; set; } = new List<Localisation>();

    }
}
