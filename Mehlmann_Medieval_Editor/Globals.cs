using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mehlmann_Medieval_Editor
{
    public static class Globals
    {
        public static long Counter_ID { get; set; } = 0;

        public static long GetID()
        {
            Counter_ID++;
            return Counter_ID-1;
        }
    }
}
