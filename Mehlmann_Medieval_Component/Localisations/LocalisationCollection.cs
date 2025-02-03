using Mehlmann_Medieval_Component.Misc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using System.Xml.Linq;

namespace Mehlmann_Medieval_Component.Localisations
{
    public class LocalisationCollection
    {
        public Language Language { get; set; }
        public List<Localisation> Collection { get; set; } = new();

        public void Add(Localisation l)
        {
            if (l != null)
            {
                Collection.Add(l);
            }
        }

        public void Remove(Localisation l)
        {
            if (l != null)
            {
                Collection.Remove(l);
            }
        }

        public void Replace(Localisation l)
        {
            if (l != null)
            {
                var loc = Collection.Where(x => x == l).FirstOrDefault();
                if (loc != null)
                {
                    loc = l;
                }
            }
        }

        public Localisation Get(int index)
        {
            try
            {
                return Collection[index];
            }
            catch (Exception)
            {
                return null;
            }
        }

        public Localisation Get(string property, string value)
        {
            try
            {
                return Collection.FirstOrDefault(x => x.GetPropertyValue(property).ToStringNN() == value);
            }
            catch (Exception)
            {
                return null;
            }
        }
        public string CreateExportText()
        {
            string text = $"l_{Language.ToString()}:\n";
            foreach (var l in Collection)
            {
                text += " " + l.CreateExportText();
                text += "\n";
            }
            return text;
        }


    }
}
