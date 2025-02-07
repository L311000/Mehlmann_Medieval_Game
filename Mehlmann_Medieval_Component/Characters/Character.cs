using Mehlmann_Medieval_Component;
using Mehlmann_Medieval_Component.Localisations;
using Mehlmann_Medieval_Component.Misc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;

namespace Mehlmann_Medieval_Component.Characters
{
    public class Character : ComponentBase
    {
        public CharacterGender Gender { get; set; }
        public Localisation FirstName { get; set; }
        public List<Localisation> MiddleNames { get; set; }
        public Family Family { get; set; }
        public Character_SocialClass SocialClass { get; set; }
        public Character Father { get; set; }
        public Character Mother { get; set; }
        public List<Character> Children { get; set; }
        public long Wealth { get; set; }
        public long Piety { get; set; }
        public long Prestige { get; set; }
        public DateOnly DateBirth { get; set; }
        public int Age { get; set; }
        public DateOnly DateDeath { get; set; }
        public bool IsCustom { get; set; }
        public bool IsAlive {  get; set; }
        public bool IsAI { get; set; } = true;
        public bool IsMissing { get; set; }
        public int Fertility { get; set; }
        public Culture Culture { get; set; }
        public bool IsMarried { get; set; }
        public bool IsBetrothed { get; set; }
        public List<Character> Spouses { get; set; }
    }
}
