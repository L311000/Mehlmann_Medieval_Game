using Mehlmann_Medieval_Component.Characters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mehlmann_Medieval_Component.Misc.Conditions
{
    public class Conditions_Character
    {
        public bool Wealth(Character c, ConditionOperator op, long val)
        {
            return op.Compare<long>(c.Wealth, val);
        }

        public bool Piety(Character c, ConditionOperator op, long val)
        {
            return op.Compare<long>(c.Piety, val);
        }

        public bool Prestige(Character c, ConditionOperator op, long val)
        {
            return op.Compare<long>(c.Prestige, val);
        }

        public bool Age(Character c, ConditionOperator op, int val)
        {
            return op.Compare<int>(c.Age, val);
        }

        public bool Date_of_Birth(Character c, ConditionOperator op, DateOnly d)
        {
            return op.Compare<DateOnly>(c.DateBirth, d);
        }

        public bool Date_Of_Death(Character c, ConditionOperator op, DateOnly d)
        {
            return op.Compare<DateOnly>(c.DateDeath, d);
        }

        public bool Adult(Character c, int ageAdult)
        {
            return (c.Age >= ageAdult);
        }

        public bool Culture(Character c, Culture culture)
        {
            return c.Culture == culture;
        }

        public bool Alive(Character c)
        {
            return c.IsAlive;
        }

        public bool Is_Mother_Alive(Character c)
        {
            if (c.Mother != null)
            {
                return c.Mother.IsAlive;
            }
            return false;
        }

        public bool Is_Father_Alive(Character c)
        {
            if (c.Father != null)
            {
                return c.Father.IsAlive;
            }
            return false;
        }

        public bool Both_Parents_Alive(Character c)
        {
            if (Is_Mother_Alive(c) && Is_Father_Alive(c))
            {
                return true;
            }
            return false;
        }

        public bool IsMale(Character c)
        {
            return c.Gender == CharacterGender.Male;
        }

        public bool IsFemale(Character c)
        {
            return c.Gender == CharacterGender.Female;
        }

        public bool Is_AI(Character c)
        {
            return c.IsAI;
        }

        public bool Has_Children(Character c)
        {
            return c.Children != null && c.Children.Count > 0;
        }

        public bool Has_Child_Alive(Character c)
        {
            if (c.Children != null)
            {
                foreach (Character child in c.Children)
                {
                    if (child.IsAlive)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public bool Can_Have_Children(Character c)
        {
            if (c.Fertility <= 0)
            {
                return false;
            }
            return true;
        }

        public int Children(Character c)
        {
            if (c.Children != null)
            {
                return c.Children.Count;
            }
            else
            { 
                return 0;
            }
        }
    }
}
