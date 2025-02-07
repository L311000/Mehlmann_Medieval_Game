using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mehlmann_Medieval_Component.Localisations
{
    public class Localisation
    {
        public string Name { get; set; }
        public int Priority { get; set; }
        public string Text { get; set; }
        public bool IsCustom { get; set; }

        public string CreateExportText()
        {
            return $"{Name}:{Priority} \"{Text}\"";
        }
    }
}
