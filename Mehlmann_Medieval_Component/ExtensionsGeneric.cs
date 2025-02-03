﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mehlmann_Medieval_Component
{
    public static class ExtensionsGeneric
    {
        public static object GetPropertyValue(this object o, string propertyName)
        {
            object value = null;
            try
            {
                value = o.GetType().GetProperty(propertyName).GetValue(o);
            }
            catch (Exception)
            {
                return null;
            }
            return value;
        }

        public static bool SetPropertyValue(this object o, string propertyName, object value)
        {
            try
            {
                o.GetType().GetProperty(propertyName).SetValue(o, value);
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        public static string ToStringNN(this object o)
        {
            string text = "";
            try
            {
                text = o.ToString();
                if (string.IsNullOrWhiteSpace(text))
                {
                    return "";
                }
                else
                {
                    return text;
                }
            }
            catch (Exception)
            {
                return "";
            }
        }
    }
}
