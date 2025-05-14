using ECommerce.Models;
using ECommerce.Services.Abstracts;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce.Controllers;

public class CategoriesController(ICategoryService categoryService) : Controller
{
    public IActionResult Index()
    {
        var categories = categoryService.GetAll();
        return View(categories);
    }


    [HttpGet]
    public IActionResult Add()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Add(Category category)
    {
        if (!ModelState.IsValid)
        {
            return View();
        }
        
        categoryService.Add(category);
        return RedirectToAction("Index","Categories");
    }

    [HttpGet]
    public IActionResult Detail(int id)
    {
        var category = categoryService.GetById(id);
        return View(category);
    }
    
    
}