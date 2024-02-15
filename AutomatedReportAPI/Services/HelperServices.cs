using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace AutomatedReportAPI.Services
{
    public static class HelperServices
    {        
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
