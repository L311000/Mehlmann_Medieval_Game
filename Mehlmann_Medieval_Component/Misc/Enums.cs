using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Mehlmann_Medieval_Component.Misc
{
    public enum Language
    {
        English, German, None
    }

    public enum LanguageTAG
    {
        ENG, GER, NONE
    }

    public enum CharacterGender
    {
        Male, Female
    }

    public enum CharacterSexualOrientation
    {
        Heterosexual, Homosexual, Non_Sexual
    }

    public enum ConditionOperator
    {
        Smaller, Bigger, Equal, Not_Equal, Smaller_OR_Equal, Bigger_OR_Equal
    }

    public static class EnumExtensions
    {
        public static LanguageTAG ToTag(this Language l)
        {
            if (l == Language.English)
            {
                return LanguageTAG.ENG;
            }
            else if (l == Language.German)
            {
                return LanguageTAG.GER;
            }
            else
            {
                return LanguageTAG.NONE;
            }
        }

        public static Language ToLanguage(this LanguageTAG tag)
        {
            if (tag == LanguageTAG.ENG)
            {
                return Language.English;
            }
            else if (tag == LanguageTAG.GER)
            {
                return Language.German;
            }
            else
            {
                return Language.None;
            }
        }
    }
}
