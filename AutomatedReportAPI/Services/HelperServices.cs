using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace AutomatedReportAPI.Services
{
    public static class HelperServices
    {
        public static string GetDisplayName(this Enum value)
        {

            Type type = value.GetType();
            string name = Enum.GetName(type, value);
            if (name != null)
            {
                FieldInfo field = type.GetField(name);
                if (field != null)
                {
                    DisplayAttribute attr = Attribute.GetCustomAttribute(field, typeof(DisplayAttribute)) as DisplayAttribute;
                    if (attr != null)
                    {
                        return attr.Name;
                    }
                }
            }
            return null;
        }
        public static List<string> GetErrors(this ModelStateDictionary modelState)
        {
            List<string> errors = new();

            foreach (var modelStateValue in modelState.Values)
            {
                foreach (var modelError in modelStateValue.Errors)
                {
                    errors.Add(modelError.ErrorMessage);
                }
            }

            return errors;
        }
    }
}
