using Mehlmann_Medieval_Component.Localisations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mehlmann_Medieval_Component.Events
{
    public class GameEvent_Option : ComponentBase
    {
        public string Name { get; set; }
        public string Localisation { get; set; }
        public GameEvent LeadsToEvent { get; set; }
    }
}
