using Mehlmann_Medieval_Component.Misc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mehlmann_Medieval_Component.Localisations
{
    public class LocalisationCollection
    {
        public Language Language { get; set; }
        public List<Localisation> Collection {  get; set; }
    }
}
