using System.ComponentModel.DataAnnotations;
using ECommerce.Attributes.Validation;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ECommerce.Models.ViewModels.Products;

public class ProductAddViewModel
{
    [Required(ErrorMessage = "İsim Alanı Zorunludur.")]
    public string Name { get; set; }
    
    
    [NumbersNotBeNegative]
    public double Price { get; set; }
    
    
    [NumbersNotBeNegative]
    public int CategoryId { get; set; }

    public List<SelectListItem> Categories { get; set; } = new List<SelectListItem>();
}