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
        public string Name {  get; set; }
        public List<string> FirstNamesMale { get; set; } = new List<string>();
        public List<string> FirstNamesFemale { get; set; } = new List<string>();

        public List<string> MiddleNamesMale { get; set; } = new List<string>();
        public List<string> MiddleNamesFemale { get; set; } = new List<string>();

        public List<string> FamilyNames { get; set; } = new List<string>();

    }
}
