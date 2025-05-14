using ECommerce.Models.ViewModels.Products;
using ECommerce.Services.Abstracts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ECommerce.Views.Shared.ViewComponents;

public class CategorySelectListViewComponent : ViewComponent
{

    private readonly ICategoryService _categoryService;

    public CategorySelectListViewComponent(ICategoryService categoryService)
    {
        _categoryService = categoryService;
    }

    public IViewComponentResult Invoke()
    {
        ProductAddViewModel viewModel = new();
        
        List<SelectListItem> listItems = new();
        
        var categories = _categoryService.GetAll();
        foreach (var category in categories)
        {
            SelectListItem selectListItem = new()
            {
                Text = category.Name,
                Value = category.Id.ToString()
            };
            listItems.Add(selectListItem);
        }

        viewModel.Categories = listItems;

        return View(viewModel);
    }
    
}