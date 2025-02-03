using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mehlmann_Medieval_Component.WPF
{
    public class WPF_Binding
    {
        public object FrameworkElement { get; set; }
        public string FrameworkElementProperty { get; set; }
        public object LinkedObject { get; set; }
        public string LinkedObjectProperty { get; set; }


        public bool UpdateLinkedObject(object newValue)
        {
            bool result = false;
            try
            {
                LinkedObject.GetType().GetProperty(LinkedObjectProperty).SetValue(LinkedObject, newValue);
                result = true;
            }
            catch (Exception)
            {
            }
            
            return result;
        }

        public bool UpdateFrameworkElement(object newValue)
        {
            bool result = false;
            try
            {
                FrameworkElement.GetType().GetProperty(FrameworkElementProperty).SetValue(FrameworkElement, newValue);
                result = true;
            }
            catch (Exception)
            {

            }
            return result;
        }

        public void UpdateBoth(object newValue)
        {
            UpdateLinkedObject(newValue);
            UpdateFrameworkElement(newValue);
        }
    }
}
