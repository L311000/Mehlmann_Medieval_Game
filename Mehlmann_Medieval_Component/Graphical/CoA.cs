using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mehlmann_Medieval_Component.Graphical
{
    public class CoA : ComponentBase
    {
        public List<CoA_Emblem> Emblems { get; set; }
        public string Background { get; set; }
        public CoA_Color Color1 { get; set; }
        public CoA_Color Color2 { get; set; }
        public CoA Customised {  get; set; }
    }
}
