using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace TheaterSystem.Infrastructure.Extensions;

public static class ModelStateExtension
{
    public static List<string> GetErrors(this ModelStateDictionary modelState)
    {
        List<string> errors = new();
        foreach (var item in modelState.Values)
        {
            errors.AddRange(item.Errors.Select(error => error.ErrorMessage));
        }
        return errors;
    }
}