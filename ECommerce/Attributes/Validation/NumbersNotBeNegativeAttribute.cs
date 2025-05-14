using System.ComponentModel.DataAnnotations;

namespace ECommerce.Attributes.Validation;

public class NumbersNotBeNegativeAttribute : ValidationAttribute
{
    protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
    {
        if (value is double number)
        {
            if (number<0)
            {
                return new ValidationResult("Girmiş olduğunuz değer negatif olamaz.");
            }
        }
        
        if (value is int intNumber)
        {
            if (intNumber<0)
            {
                return new ValidationResult("Girmiş olduğunuz değer negatif olamaz.");
            }
        }
        return ValidationResult.Success;
        
    }
}