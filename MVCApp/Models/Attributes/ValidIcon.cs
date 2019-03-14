using System;
using System.ComponentModel.DataAnnotations;

namespace MVCApp
{
    public class ValidIcon : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var icon = (validationContext.ObjectInstance as GetPlace).Icon;

            var arr = new string[] {"museum", "theatre", "lodging" };

            var IsToDo = false;
            int pos = Array.IndexOf(arr, icon);
            if (pos == -1)
            {
                IsToDo = true;
            }
            var res = IsToDo ? new ValidationResult("Icon must have name as 'museum', 'theatre' or 'lodging'") : null;

            return res;
        }
    }
}